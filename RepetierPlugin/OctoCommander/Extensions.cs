using System;
using System.Collections.Generic;

namespace OctoCommander
{
    public static class Extensions
    {
        public static List<Printer> GetPrinters(this Properties.Settings settings)
        {
            var result = new List<Printer>();

            var printers = settings.Printers.Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);
            var printerAPIKeys = settings.PrinterAPIKeys.Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < printers.Length; i++)
            {
                result.Add(new Printer
                {
                    Address = printers[i],
                    APIKey = printerAPIKeys.Length > i ? printerAPIKeys[i] : string.Empty,
                });
            }

            return result;
        }
    }
}
