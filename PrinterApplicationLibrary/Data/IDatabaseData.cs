using PrinterAgentLibrary.Models;
using PrinterApplicationLibrary.Models;
using System.Collections.Generic;

namespace PrinterApplicationLibrary.Data
{
    public interface IDatabaseData
    {
        List<PrinterFullModel> GetAllPrintersFromDB();
        List<string> GetIpAddressesFromDB();
        void InsertPrinterValuesFromAgent(PrinterModel printer);
    }
}