using Npgsql;
using System;

namespace PostgresqlDBInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Save?");
            var ans = Console.ReadLine();

            if(ans == "y")
            {
                Save();
                Console.WriteLine("Saved");
            }
        }

        private static void Save()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=root;Password=Asdf1234;Database=TMS;");
            conn.Open();

            // Define a query
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO payroll.name VALUES ('Engr. Kier Musngi, CpE');", conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            // Close connection
            conn.Close();
        }
    }
}
