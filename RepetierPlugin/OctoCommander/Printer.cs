using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using OctoCommander.Properties;

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

        public int? Progress { get; set; }

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

        public async Task Refresh()
        {
            IsConnected = false;

            try
            {
                var wc = new WebClient();
                var stateJson = await wc.DownloadStringTaskAsync(GetUri("state"));

                var state = System.Web.Helpers.Json.Decode(stateJson);
                State = state["state"]["stateString"];
                IsPrinting = Convert.ToBoolean(state["state"]["flags"]["printing"]);
                IsPaused = Convert.ToBoolean(state["state"]["flags"]["paused"]);
                var hasError = Convert.ToBoolean(state["state"]["flags"]["error"]);
                CurrentBedTemperature = state["temperatures"]["bed"]["current"].ToString();
                TargetBedTemperature = state["temperatures"]["bed"]["target"].ToString();
                CurrentExtruderTemperature = state["temperatures"]["extruder"]["current"].ToString();
                TargetExtruderTemperature = state["temperatures"]["extruder"]["target"].ToString();
                PrintTimeLeft = state["progress"]["printTimeLeft"];
                if (state["progress"]["progress"] != null)
                {
                    Progress = (int)state["progress"]["progress"];
                }
                else
                {
                    Progress = null;
                }
                CurrentJob = state["job"]["filename"];

                Error = hasError ? "The Printer has an Error." : "-";
                IsConnected = true;
            }
            catch (Exception)
            {
                Error = "Failed to load State";
                throw;
            }
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