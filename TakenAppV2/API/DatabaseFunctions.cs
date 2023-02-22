using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary;
using MySql;
using MySql.Data.MySqlClient;

namespace API
{
    public class DatabaseFunctions
    {

        private MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public string connectionString;

        public DatabaseFunctions(string server, string database, string user, string password)
        {
            // genereren connection
            connectionString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={password};";
            con = new MySqlConnection(connectionString);
        }


        public List<Tasks> GetAllData()
        {
            List<Tasks> list = new List<Tasks>();
            con.Open();
            cmd = new MySqlCommand("SELECT * FROM taken", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Tasks
                {
                    id = dr.GetInt32("Id"),
                    subject = dr.GetString("Onderwerp"),
                    priorety = dr.GetInt32("Prioriteit"),
                    state = dr.GetString("Status"),
                    startdate = dr.GetDateTime("Begindatum")
                    enddate = dr.GetDateTime("Einddatum")
                });

            }
            con.Close();
            return list;
        }

        public void InsertTask(string subject, int priority, string status)
        {
            con.Open();
            cmd = new MySqlCommand($"INSER INTO taken (Onderwerp, Prioriteit, Status, Datum) " +
                                   $"VALUES ({subject}, {priority}, {status}, {DateTime.Now})");
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteTask(int id)
        {
            con.Open();
            cmd = new MySqlCommand($"DELETE * FROM taken WHERE Id = {id}");
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateTask(int id, string subject, int priority, string status)
        {
            con.Open();
            cmd = new MySqlCommand($"UPATE taken SET Onderwerp = {subject}, priority = {priority}" +
                                   $"Status = {status}  WHERE Id = {id}");
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
