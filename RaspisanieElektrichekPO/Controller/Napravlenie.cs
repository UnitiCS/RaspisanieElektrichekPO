using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RaspisanieElektrichekPO.Controller
{
    public class Napravlenie
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable byfferTable;

        public Napravlenie(string Conn)
        {
            connection = new SqlConnection(Conn);
            byfferTable = new DataTable();
        }

        //1
        public DataTable UpdateNapravlenie()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Napravlenie", connection);
            byfferTable.Clear();
            dataAdapter.Fill(byfferTable);
            connection.Close();
            return byfferTable;
        }

        public void AddNapravlenie(string PynknOtpr, string PynknNaznach, string Rassroynie)
        {
            connection.Open();
            command = new SqlCommand($"INSERT INTO Napravlenie(PynknOtpr, PynknNaznach, Rassroynie) VALUES(@PynknOtpr, @PynknNaznach, @Rassroynie)", connection);
            command.Parameters.AddWithValue("@PynknOtpr", PynknOtpr);
            command.Parameters.AddWithValue("@PynknNaznach", PynknNaznach);
            command.Parameters.AddWithValue("@Rassroynie", Rassroynie);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteNapravlenie(int ID)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM Napravlenie WHERE ID={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
