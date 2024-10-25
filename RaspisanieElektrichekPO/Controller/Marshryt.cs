using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RaspisanieElektrichekPO.Controller
{
    public class Marshryt
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable byfferTable;

        public Marshryt(string Conn)
        {
            connection = new SqlConnection(Conn);
            byfferTable = new DataTable();
        }

        //1
        public DataTable UpdateMarshryt()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Marshryt", connection);
            byfferTable.Clear();
            dataAdapter.Fill(byfferTable);
            connection.Close();
            return byfferTable;
        }

        public void AddMarshryt(string Nazvanie, string Napravlenie, string Elektrichka, string DenNedeli)
        {
            connection.Open();
            command = new SqlCommand($"INSERT INTO Marshryt(Nazvanie, Napravlenie, Elektrichka, DenNedeli) VALUES(@Nazvanie, @Napravlenie, @Elektrichka, @DenNedeli)", connection);
            command.Parameters.AddWithValue("@Nazvanie", Nazvanie);
            command.Parameters.AddWithValue("@Napravlenie", Napravlenie);
            command.Parameters.AddWithValue("@Elektrichka", Elektrichka);
            command.Parameters.AddWithValue("@DenNedeli", DenNedeli);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteMarshryt(int ID)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM Marshryt WHERE ID={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
