using AddPrinterServiceBus.DatabaseAccess;
using AddPrinterServiceBus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddPrinterServiceBus.Data
{
    public class SqliteData
    {
        private const string connectionStringName = "SQLiteDb";
        SqliteDataAccess db = new SqliteDataAccess();

        /// <summary>
        /// Insert the printer from the user interface. If printers ip address already exsist in the database then update its description and location,
        /// otherwise insert provided printer with its properties in the database.
        /// </summary>
        /// <param name="printer">Printer basic object consist of three properties, ip address, description and location.</param>
        public void InsertNewPrinter(PrinterBasicModel printer)
        {
            string IpAddress = printer.IpAddress;
            string Description = printer.Description;
            string Location = printer.Location;

            // Queries
            string sqlSelect = @"SELECT * 
                                FROM Printers
                                WHERE IpAddress = @IpAddress";

            string sqlInsert = @"INSERT INTO Printers (IpAddress, Description, Location)
                                VALUES (@IpAddress, @Description, @Location)";

            string sqlUpdate = @"UPDATE Printers
	                            SET Description = @Description, Location = @Location
	                            WHERE IpAddress = @IpAddress";


            // Check if there is already provided IP Address in the database
            var ipExist = db.LoadData<PrinterBasicModel, dynamic>(sqlSelect, new { IpAddress, Description, Location }, connectionStringName).FirstOrDefault();
            //var ipExist = db.LoadData<PrinterModel, dynamic>(sqlSelect, new { IpAddress, Description, Location }, connectionStringName).FirstOrDefault();

            if (ipExist == null)
            {
                // Insert provided IP address, Description and Location into database
                db.SaveData(sqlInsert, new { IpAddress, Description, Location }, connectionStringName);
            }
            else
            {
                // Update existing record where provided IP address match IP address that already exist in the database.
                db.SaveData(sqlUpdate, new { IpAddress, Description, Location }, connectionStringName);
            }
        }
    }
}
