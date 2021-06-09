using PrinterAgentLibrary.Models;
using System.Threading.Tasks;

namespace PrinterAgentLibrary
{
    public interface IPrinterSnmpData
    {
        Task<PrinterModel> GetPrinterData(string ipAddress, string snmpCommunity = "public");
    }
}