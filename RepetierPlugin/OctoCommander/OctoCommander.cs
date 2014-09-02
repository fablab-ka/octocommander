using RepetierHostExtender.interfaces;

namespace OctoCommander
{
    public class OctoCommander : IHostPlugin
    {
        IHost host;

        /// <summary>
        /// Called first to allow filling some lists. Host is not fully set up at that moment.
        /// </summary>
        /// <param name="host"></param>
        public void PreInitalize(IHost _host)
        {
            host = _host;
        }

        /// <summary>
        /// Called after everything is initalized to finish parts, that rely on other initializations.
        /// Here you must create and register new Controls and Windows.
        /// </summary>
        public void PostInitialize()
        {
            // Add the CoolControl to the right tab
            var cool = new FabLabPrinter();
            cool.Connect(host);
            host.RegisterHostComponent(cool);

            // Add some text in the about dialog
            host.AboutDialog.RegisterThirdParty("OctoCommander", "\r\n\r\nOctoCommander written by FabLab\r\nUse it like you want.");
        }

        /// <summary>
        /// Last round of plugin calls. All controls exist, so now you may modify them to your wishes.
        /// </summary>
        public void FinializeInitialize()
        {
        }
    }
}
