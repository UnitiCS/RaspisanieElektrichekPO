using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RaspisanieElektrichekPO.Controller
{
    public class Rasstoyanie
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable bufferTable;

        public Rasstoyanie()
        {
            connection = new SqlConnection();
            bufferTable = new DataTable();
        }

        public Rasstoyanie(string Conn)
        {
            connection = new SqlConnection(Conn);
            bufferTable = new DataTable();
        }

        public DataTable UpdateRasstoyanie()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Rasstoyanie", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void AddRasstoyanie(string nachOstanovka, string konechOstanovka, string km)
        {
            connection.Open();
            command = new SqlCommand("INSERT INTO Rasstoyanie(NachOstanovka, KonechOstanovka, KM) VALUES (@NachOstanovka, @KonechOstanovka, @KM)", connection);
            command.Parameters.AddWithValue("@NachOstanovka", nachOstanovka);
            command.Parameters.AddWithValue("@KonechOstanovka", konechOstanovka);
            command.Parameters.AddWithValue("@KM", km);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteRasstoyanie(int id)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM Rasstoyanie WHERE ID = {id}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
