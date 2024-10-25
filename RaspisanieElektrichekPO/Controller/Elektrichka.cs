using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RaspisanieElektrichekPO.Controller
{
    public class Elektrichka
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable byfferTable;

        public Elektrichka(string Conn)
        {
            connection = new SqlConnection(Conn);
            byfferTable = new DataTable();
        }

        //1
        public DataTable UpdateElektrichka()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Elektrichka", connection);
            byfferTable.Clear();
            dataAdapter.Fill(byfferTable);
            connection.Close();
            return byfferTable;
        }

        public void AddElektrichka(string Nazvanie, string Tip, string KlvoVagongv)
        {
            connection.Open();
            command = new SqlCommand($"INSERT INTO Elektrichka(Nazvanie,Tip,KlvoVagongv) VALUES(@Nazvanie,@Tip,@KlvoVagongv)", connection);
            command.Parameters.AddWithValue("@Nazvanie", Nazvanie);
            command.Parameters.AddWithValue("@Tip", Tip);
            command.Parameters.AddWithValue("@KlvoVagongv", KlvoVagongv);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteElektrichka(int ID)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM Elektrichka WHERE ID={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
