using Microsoft.VisualStudio.TestTools.UnitTesting;
using RaspisanieElektrichekPO.Controller;
using RaspisanieElektrichekPO.Forms;
using System.Data;

namespace RaspisanieElektrichekPO.Tests
{
    [TestClass]
    public class DenNedeliTests
    {
        private string connectionString = "Server=DESKTOP-CLKTO14\\SQLEXPRESS;Database=RaspisanieElektrichekTest;Trusted_Connection=True;\r\n";

        [TestMethod]
        public void UpdateDenNedeliTest()
        {
            // Arrange
            Controller.DenNedeli denNedeli = new Controller.DenNedeli(connectionString);

            // Act
            DataTable result = denNedeli.UpdateDenNedeli();

            // Assert
            Assert.IsNotNull(result);
            // Add more assertions if necessary
        }

        [TestMethod]
        public void AddDenNedeliTest()
        {
            // Arrange
            Controller.DenNedeli denNedeli = new Controller.DenNedeli(connectionString);
            string nazvanie = "Test";

            // Act
            denNedeli.AddDenNedeli(nazvanie);

            // Assert
            // Add assertions to check if the data was added correctly
        }

        [TestMethod]
        public void DeleteDenNedeliTest()
        {
            // Arrange
            Controller.DenNedeli denNedeli = new Controller.DenNedeli(connectionString);
            int id = 1; // Replace with the actual ID to delete

            // Act
            denNedeli.DeleteDenNedeli(id);

            // Assert
            // Add assertions to check if the data was deleted correctly
        }
    }
}
