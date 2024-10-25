using NUnit.Framework;
using RaspisanieElektrichekPO.Forms;
using System;
using System.Data;

namespace RaspisanieElektrichekPO.Controller.Tests
{
    [TestFixture]
    public class RasstoyanieTests
    {
        private const string ConnectionString = "Server=DESKTOP-CLKTO14\\SQLEXPRESS;Database=RaspisanieElektrichekTest;Trusted_Connection=True;\r\n";

        [Test]
        public void UpdateRasstoyanie_ReturnsDataTable()
        {
            // Arrange
            Rasstoyanie rasstoyanie = new Rasstoyanie(ConnectionString);

            // Act
            DataTable result = rasstoyanie.UpdateRasstoyanie();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }

        [Test]
        public void AddRasstoyanie_InsertsDataIntoDatabase()
        {
            // Arrange
            Rasstoyanie rasstoyanie = new Rasstoyanie(ConnectionString);
            string nachOstanovka = "3";
            string konechOstanovka = "5";
            string km = "10";

            // Act
            rasstoyanie.AddRasstoyanie(nachOstanovka, konechOstanovka, km);

            // Assert
            // Add your own assertions here to verify that the data was inserted correctly
        }

        [Test]
        public void DeleteRasstoyanie_RemovesDataFromDatabase()
        {
            // Arrange
            Rasstoyanie rasstoyanie = new Rasstoyanie(ConnectionString);
            int idToDelete = 1; // Specify the ID of the data to delete

            // Act
            rasstoyanie.DeleteRasstoyanie(idToDelete);

            // Assert
            // Add your own assertions here to verify that the data was deleted correctly
        }
    }
}
