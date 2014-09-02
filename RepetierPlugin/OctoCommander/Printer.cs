using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using OctoCommander.Properties;
using RepetierHostExtender.interfaces;

namespace OctoCommander
{
    public class Printer
    {
        public string Address { get; set; }

        public string APIKey { get; set; }

        public string Error { get; set; }

        public string State { get; set; }

        public string PrintTimeLeft { get; set; }

        public string CurrentJob { get; set; }

        public float? Progress { get; set; }

        public string TargetExtruderTemperature { get; set; }

        public string CurrentExtruderTemperature { get; set; }

        public string TargetBedTemperature { get; set; }

        public string CurrentBedTemperature { get; set; }

        public bool IsPaused { get; set; }

        public bool IsPrinting { get; set; }

        public bool IsConnected { get; set; }

        public string GetUri(string part)
        {
            return string.Format(Settings.Default.UriFormat, Address, part, APIKey);
        }

        public async Task Refresh(IHost host)
        {
            IsConnected = false;

            Reset();

            try
            {
                var hasError = false;

                hasError = await LoadVersion();
                if (!hasError)
                {
                    hasError = await LoadConnection();
                }
                if (!hasError)
                {
                    hasError = await LoadState();
                }

                Error = hasError ? "The Printer has an Error." : "-";
                IsConnected = true;
            }
            catch (Exception)
            {
                Error = "Failed to load State";
                host.LogError("Failed to connect to printer");
            }
        }

        private async Task<bool> LoadVersion()
        {
            var hasError = false;

            var wc = new WebClient();
            var versionJson = await wc.DownloadStringTaskAsync(GetUri("version"));
            dynamic version = Newtonsoft.Json.Linq.JObject.Parse(versionJson);

            return hasError;
        }

        private async Task<bool> LoadConnection()
        {
            var hasError = false;

            var wc = new WebClient();
            var connectionJson = await wc.DownloadStringTaskAsync(GetUri("connection"));
            dynamic connection = Newtonsoft.Json.Linq.JObject.Parse(connectionJson);

            return hasError;
        }

        private async Task<bool> LoadState()
        {
            var hasError = false;

            var wc = new WebClient();
            var stateJson = await wc.DownloadStringTaskAsync(GetUri("state"));
            dynamic state = Newtonsoft.Json.Linq.JObject.Parse(stateJson);

            if (state["state"] != null)
            {
                State = state["state"]["stateString"];
                if (state["state"]["flags"] != null)
                {
                    IsPrinting = Convert.ToBoolean(state["state"]["flags"]["printing"]);
                    IsPaused = Convert.ToBoolean(state["state"]["flags"]["paused"]);
                    hasError = Convert.ToBoolean(state["state"]["flags"]["error"]);
                }
            }

            if (state["temperatures"] != null)
            {
                if (state["temperatures"]["bed"] != null)
                {
                    CurrentBedTemperature = (string) state["temperatures"]["bed"]["current"];
                    TargetBedTemperature = (string) state["temperatures"]["bed"]["target"];
                }

                if (state["temperatures"]["extruder"] != null)
                {
                    CurrentExtruderTemperature = (string) state["temperatures"]["extruder"]["current"];
                    TargetExtruderTemperature = (string) state["temperatures"]["extruder"]["target"];
                }
            }

            if (state["progress"] != null)
            {
                PrintTimeLeft = state["progress"]["printTimeLeft"];
                if (state["progress"]["completion"] != null)
                {
                    Progress = (float) state["progress"]["completion"];
                }
                else
                {
                    Progress = null;
                }
            }

            if (state["job"] != null)
            {
                CurrentJob = state["job"]["filename"];
            }

            return hasError;
        }

        private void Reset()
        {
            Error = "-";
            State = string.Empty;
            IsPrinting = false;
            IsPaused = false;
            CurrentBedTemperature = string.Empty;
            TargetBedTemperature = string.Empty;
            CurrentExtruderTemperature = string.Empty;
            TargetExtruderTemperature = string.Empty;
            PrintTimeLeft = string.Empty;
            Progress = null;
            CurrentJob = string.Empty;
        }

        public async Task Print(string gcode, string filename)
        {
            try
            {
                var address = GetUri("load");

                var filepath = Path.Combine(Path.GetTempPath(), filename);
                File.WriteAllText(filepath, gcode);

                var wc = new WebClient();
                var response = await wc.UploadFileTaskAsync(address, "POST", filepath);
                
                Error = "-";
            }
            catch (Exception)
            {
                Error = "Failed to Print";
                throw;
            }
        }

    }
}