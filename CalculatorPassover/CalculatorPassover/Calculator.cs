using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPassover
{
    class Calculator : ICalculator
    {
        static SqlConnection conn;
        string Calculator4 = @"Data Source=Desktop-EGLVPS0\SQLEXPRESS;Initial Catalog=Calculator; integrated Security=true;";
    
        public Calculator()
        {
            conn = new SqlConnection($"{Calculator4}");
            conn.Open();

        }
        public void AddNumbers(int x, int y)
        {
            using (SqlCommand cmd = new SqlCommand($"Insert Into Input_X Values ({x}); Insert Into Input_Y Values ({y});", conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        public void PrintCalculator()
        {
            using (SqlCommand cmd = new SqlCommand("Show Result Calculator", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.Default))
                {
                    while (reader.Read() == true)
                    {
                        Console.WriteLine($"{reader["X"]} {reader["Y"]} {reader["Opearation"]} {reader["Result"]}");
                    }
                }
            }
        }


    }
}
