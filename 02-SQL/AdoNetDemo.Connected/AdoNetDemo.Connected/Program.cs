using System;
using System.Data.SqlClient;

namespace AdoNetDemo.Connected
{
    class Program
    {
        static void Main(string[] args)
        {
            // some way to connect/authenticate to DB.
            // we need the connection string.

            // connection strings are considered 
            var connectionstring = SecretConfiguration.ConnectionString;

            using (var connection = new SqlConnection(connectionstring))
            {
                //step 1: open connection to DB
                connection.Open();

                Console.WriteLine("Enter a condition: ");
                var condition = Console.ReadLine();
                if (condition != "")
                {
                    condition = "WHERE " + condition;
                }
                var commString = "SELECT Name FROM dbo.Artist " +condition;
                //step 2: Execute your query
                using (var command = new SqlCommand(commString, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //for INSERT, UPDATE, anything except SELECT..
                    // instead of .ExecuteReader(), you do .ExecuteNonQuery()


                    //step 3: process the results.
                    if(reader.HasRows)
                    {
                        //data reader is a sort of cursor that advances through the returned rows
                        while(reader.Read())
                        {
                            //preocess one row
                            var title = (string)reader["Name"];
                            Console.WriteLine("Artist Name: " + title);

                        }
                    }
                }
                //step 4: Close the connection
                connection.Close();
            }
        }
    }
}
