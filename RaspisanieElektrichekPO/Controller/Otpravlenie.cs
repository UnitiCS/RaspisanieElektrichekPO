using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RaspisanieElektrichekPO.Controller
{
    public class Otpravlenie
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable byfferTable;

        public Otpravlenie(string ConnStr)
        {
            connection = new SqlConnection(ConnStr);
            byfferTable = new DataTable();
        }

        //1
        public DataTable UpdateOtpravlenie()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Otpravlenie", connection);
            byfferTable.Clear();
            dataAdapter.Fill(byfferTable);
            connection.Close();
            return byfferTable;
        }

        public void AddOtpravlenie(string Reis, string VremyaOtpr, string VremyaPrib, string Ostanovka, string DlitelnostStoyanki)
        {
            connection.Open();
            command = new SqlCommand($"INSERT INTO Otpravlenie(Reis,VremyaOtpr,VremyaPrib,Ostanovka,DlitelnostStoyanki) VALUES(@Reis,@VremyaOtpr,@VremyaPrib,@Ostanovka,@DlitelnostStoyanki)", connection);
            command.Parameters.AddWithValue("@Reis", Reis);
            command.Parameters.AddWithValue("@VremyaOtpr", VremyaOtpr);
            command.Parameters.AddWithValue("@VremyaPrib", VremyaPrib);
            command.Parameters.AddWithValue("@Ostanovka", Ostanovka);
            command.Parameters.AddWithValue("@DlitelnostStoyanki", DlitelnostStoyanki);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteOtpravlenie(int ID)
        {
            connection.Open();
            command = new SqlCommand($"DELETE FROM Otpravlenie WHERE ID={ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
