using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RaspisanieElektrichekPO.Controller
{
    public class Reis
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable byfferTable;

        public Reis(string Conn)
        {
            connection = new SqlConnection(Conn);
            byfferTable = new DataTable();
        }

        //1
        public DataTable UpdateReis()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Reis", connection);
            byfferTable.Clear();
            dataAdapter.Fill(byfferTable);
            connection.Close();
            return byfferTable;
        }

        public void AddReis(string Marshryt, string VremyaOtpr, string VremyaPrib)
        {
            connection.Open();
            command = new SqlCommand($"INSERT INTO Reis(Marshryt, VremyaOtpr, VremyaPrib) VALUES(@Marshryt, @VremyaOtpr, @VremyaPrib)", connection);
            command.Parameters.AddWithValue("@Marshryt", Marshryt);
            command.Parameters.AddWithValue("@VremyaOtpr", VremyaOtpr);
            command.Parameters.AddWithValue("@VremyaPrib", VremyaPrib);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteReis(int ID)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM Reis WHERE ID={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
