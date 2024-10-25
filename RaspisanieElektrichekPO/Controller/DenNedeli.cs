using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RaspisanieElektrichekPO.Controller
{
    public class DenNedeli
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable byfferTable;

        public DenNedeli(string ConnStr)
        {
            connection = new SqlConnection(ConnStr);
            byfferTable = new DataTable();
        }

       //1
        public DataTable UpdateDenNedeli()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM DenNedeli", connection);
            byfferTable.Clear();
            dataAdapter.Fill(byfferTable);
            connection.Close();
            return byfferTable;
        }

        public void AddDenNedeli(string Nazvanie)
        {
            connection.Open();
            command = new SqlCommand($"INSERT INTO DenNedeli(Nazvanie) VALUES(@Nazvanie)", connection);
            command.Parameters.AddWithValue("@Nazvanie", Nazvanie);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteDenNedeli(int ID)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM DenNedeli WHERE ID={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
