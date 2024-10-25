using NUnit.Framework;
using System.Data;

namespace RaspisanieElektrichekPO.Controller.Tests
{
    [TestFixture]
    public class OstanovkiTests
    {
        private string connectionString = "Server=DESKTOP-CLKTO14\\SQLEXPRESS;Database=RaspisanieElektrichekTest;Trusted_Connection=True;\r\n";

        [SetUp]
        public void SetUp()
        {
            // Инициализация перед каждым тестом
        }

        [TearDown]
        public void TearDown()
        {
            // Очистка после каждого теста
        }

        [Test]
        public void UpdateOstanovki_ReturnsDataTable()
        {
            // Arrange
            Ostanovki ostanovki = new Ostanovki(connectionString);

            // Act
            DataTable result = ostanovki.UpdateOstanovki();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<DataTable>(result);
        }

        [Test]
        public void AddOstanovki_InsertsNewRecord()
        {
            // Arrange
            Ostanovki ostanovki = new Ostanovki(connectionString);
            string nazvanie = "Test Ostanovka";

            // Act
            ostanovki.AddOstanovki(nazvanie);

            // Assert
            // Add your assertions here to verify that the record was inserted correctly
        }

        //[Test]
        //public void DeleteOstanovki_DeletesRecord()
       // {
            // Arrange
            //Ostanovki ostanovki = new Ostanovki(connectionString);
            //int idToDelete = 1; // Specify the ID of the record to delete

            // Act
            //ostanovki.DeleteOstanovki(idToDelete);

            // Assert
            // Add your assertions here to verify that the record was deleted correctly
        //}
    }
}
