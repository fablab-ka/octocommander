using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OctoCommander.Properties;
using RepetierHostExtender.geom;
using RepetierHostExtender.interfaces;

namespace OctoCommander
{
    public partial class FabLabPrinter : UserControl, IHostComponent
    {
        private IHost host;
        private Printer currentPrinter;
        private Timer refreshTimer;

        public FabLabPrinter()
        {
            InitializeComponent();

            refreshTimer = new Timer();
            refreshTimer.Interval = Settings.Default.PrinterRefreshInterval;
            refreshTimer.Tick += RefreshTimerTick;
        }

        /// <summary>
        /// Store reference to host for later use
        /// </summary>
        /// <param name="host">Host instance</param>
        public void Connect(IHost _host)
        {
            host = _host;
        }

        #region IHostComponent implementation

        public void ComponentActivated()
        {
            var printers = Settings.Default.GetPrinters();
            foreach (var printer in printers)
            {
                printerSelectionBox.Items.Add(printer);
            }

            printerSelectionBox.SelectedItem = printers.FirstOrDefault();
        }

        // Name inside component repository
        public string ComponentName { get { return "FabLab"; } }

        // Name for tab
        public string ComponentDescription { get { return "FabLab"; } }

        // Used for positioning.
        public int ComponentOrder { get { return 8000; } }

        // Where to add it. We want it on the right tab.
        public PreferredComponentPositions PreferredPosition { get { return PreferredComponentPositions.SIDEBAR; } }

        // Return the UserControl.
        public Control ComponentControl { get { return this; } }

        public ThreeDView Associated3DView { get; private set; }

        #endregion

        private void RefreshTimerTick(object sender, EventArgs e)
        {
            Task.Run(() => RefreshPrinter());
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            var printer = printerSelectionBox.SelectedItem as Printer;

            if (printer != null)
            {
                host.LogInfo("Trying to connect to " + printer);
                currentPrinter = printer;

                Task.Run(() => RefreshPrinter());
                refreshTimer.Start();
            }
            else
            {
                host.LogWarning("No printer selected, can't connect");
            }
        }

        private async void RefreshPrinter()
        {
            if (currentPrinter != null)
            {
                await currentPrinter.Refresh(host);
                
                Invoke((Action) UpdatePrinterData);

                if (!currentPrinter.IsConnected)
                {
                    refreshTimer.Stop();
                }
            }
        }

        private void UpdatePrinterData()
        {
            printerControlBox.Enabled = currentPrinter.IsConnected;
            if (currentPrinter.IsConnected)
            {
                printerStateLabel.Text = currentPrinter.State;

                temperaturesBox.Enabled = currentPrinter.State != "Offline";

                errorText.Text = currentPrinter.Error;
                pausedText.Text = currentPrinter.IsPaused ? "indeed" : "nope";
                printingText.Text = currentPrinter.IsPrinting ? "indeed" : "nope";

                bedTempText.Text = string.Format("{0} °C  /  {1} °C", currentPrinter.CurrentBedTemperature, currentPrinter.TargetBedTemperature);
                extruderTempText.Text = string.Format("{0} °C  /  {1} °C", currentPrinter.CurrentExtruderTemperature, currentPrinter.TargetExtruderTemperature);

                jobFilename.Text = currentPrinter.CurrentJob;
                progressText.Text = currentPrinter.PrintTimeLeft + " some unit";
                if (currentPrinter.Progress.HasValue && currentPrinter.IsPrinting)
                {
                    jobProgressBar.Value = (int)currentPrinter.Progress.Value; // TODO
                    jobBox.Enabled = true;
                }
                else
                {
                    jobBox.Enabled = false;
                }

                printBox.Enabled = !jobBox.Enabled && !host.IsSlicing;
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            var gcode = host.GCodeEditor.getContent(0);

            var name = Environment.MachineName + "_" + DateTime.Now.ToString("yyyy-MM-dd-H-mm-ss");
            Task.Run(() => currentPrinter.Print(gcode, name + ".gcode"));
        }

        private void openOctoPrintButton_Click(object sender, EventArgs e)
        {
            var printer = printerSelectionBox.SelectedItem as Printer;

            if (printer != null)
            {
                host.OpenLink("http://" + printer.Address);
            }
            else
            {
                host.LogWarning("No printer selected, can't open OctoPrint");
            }
        }
    }
}
