using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDB2
{
    class EmployeesService
    {
        private static string _connectionString;
        static EmployeesService()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"LAPTOP-05JSUJKP\SQLEXPRESS";
            builder.InitialCatalog = "SQLTest";
            builder.IntegratedSecurity = true;
            _connectionString = builder.ToString();
        }

        public static DataTable GetDataTable()
        {
            var dt = new DataTable();
            var sql = "SELECT id, name, address FROM employees ";

            //disposeがある場合はusingで囲む⇒finallyを使わないように
            using (var connection = new SqlConnection(_connectionString))
            using (var adapter = new SqlDataAdapter(sql, connection))
            {
                connection.Open();
                adapter.Fill(dt);
            }

            return dt;
        }
        public static List<EmployeesEntity> GetConnectString()
        {

            var errorMessages = new StringBuilder();         //エラーメッセージ
            var employeesList = new List<EmployeesEntity>();

            try
            {
                var sql = "SELECT id, name, address FROM employees ";


                //disposeがある場合はusingで囲む⇒finallyを使わないように
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employeesList.Add(new EmployeesEntity(
                                Convert.ToInt32(reader["id"]),
                                Convert.ToString(reader["name"]),
                                Convert.ToString(reader["address"])
                                ));

                        }
                    }
                }

            }
            catch (SqlException e)
            {
                for (int i = 0; i < e.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + e.Errors[i].Message + "\n" +
                        "LineNumber: " + e.Errors[i].LineNumber + "\n" +
                        "Source: " + e.Errors[i].Source + "\n" +
                        "Procedure: " + e.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
            return employeesList;

        }


    }
}
