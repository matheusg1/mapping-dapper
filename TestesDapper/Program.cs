using System;
using System.Data.SqlClient;
using Dapper;

namespace TestesDapper
{
    public class Program
    {
        static void Main(string[] args)
        {

            fazQuery(2);
        }

        public static void fazQuery(int id)
        {
            //Console.WriteLine("Hello World!");
            var cs = @"Data Source=DESKTOP-DH2UQUR;Initial Catalog=PCTESTE;Integrated Security=True;";

            using var con = new SqlConnection(cs);
            con.Open();

            var lista = con.Query<Department>("select * from Department where Id = @idParam", new { idParam = id });

            foreach (var item in lista)
            {
                Console.WriteLine(item);

            }
            con.Close();
        }
    }
}