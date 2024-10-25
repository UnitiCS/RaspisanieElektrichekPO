using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace RaspisanieElektrichekPO.Controller
{
    public class Ostanovki
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable byfferTable;

        public Ostanovki (string ConnStr)
        {
            connection = new SqlConnection(ConnStr);
            byfferTable = new DataTable();

        }

        //1
        public DataTable UpdateOstanovki()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Ostanovki", connection);
            byfferTable.Clear();
            dataAdapter.Fill(byfferTable);
            connection.Close();
            return byfferTable;
        }

        public void AddOstanovki(string Nazvanie)
        {
            connection.Open();
            command = new SqlCommand($"INSERT INTO Ostanovki(Nazvanie) VALUES(@Nazvanie)", connection);
            command.Parameters.AddWithValue("@Nazvanie", Nazvanie);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteOstanovki(int ID)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM Ostanovki WHERE ID={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
