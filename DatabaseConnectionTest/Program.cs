using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace DatabaseConnectionTest
{
    public static class Program
    {
        private static void Main()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["MarketPrices"].ConnectionString;

            Console.WriteLine(connectionString);

            using (var conn = new OracleConnection(connectionString))
            {
                conn.Open();

                var sql = "select 1 from dual";

                using (var command = new OracleCommand(sql, conn))
                {
                    command.CommandType = CommandType.Text;
                    var result = command.ExecuteScalar();
                    Console.WriteLine(result);
                }
            }
        }
    }
}
