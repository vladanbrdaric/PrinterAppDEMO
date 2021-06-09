using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace AddPrinterServiceBus.DatabaseAccess
{
    public class SqliteDataAccess
    {
        private readonly string connectionString = "Data Source=C:\\Users\\Vlado\\Desktop\\PrinterApp DEMO\\PrinterApplicationLibrary\\SqliteDB.db";

        // Loading data
        public List<T> LoadData<T, U>(string sqlStatement, U parameters, string connectionStringName)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatement, parameters).ToList();
                return rows;
            }
        }

        // Save / Process data
        public void SaveData<T>(string sqlStatement, T parameters, string connectionStringName)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Execute(sqlStatement, parameters);
            }
        }
    }
}
