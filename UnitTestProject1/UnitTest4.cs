using NUnit.Framework;
using System.Data;

namespace RaspisanieElektrichekPO.Controller.Tests
{
    [TestFixture]
    public class OtpravlenieTests
    {
        private const string ConnectionString = "Server=DESKTOP-CLKTO14\\SQLEXPRESS;Database=RaspisanieElektrichekTest;Trusted_Connection=True;\r\n";

        [SetUp]
        public void Setup()
        {
            // Выполняется перед каждым тестом
        }

        [TearDown]
        public void TearDown()
        {
            // Выполняется после каждого теста
        }

        [Test]
        public void UpdateOtpravlenie_ReturnsDataTable()
        {
            // Arrange
            Otpravlenie otpravlenie = new Otpravlenie(ConnectionString);

            // Act
            DataTable result = otpravlenie.UpdateOtpravlenie();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<DataTable>(result);
        }

        [Test]
        public void AddOtpravlenie_InsertsDataIntoDatabase()
        {
            // Arrange
            Otpravlenie otpravlenie = new Otpravlenie(ConnectionString);
            string reis = "3";
            string vremyaOtpr = "10:00";
            string vremyaPrib = "11:00";
            string ostanovka = "4";
            string dlitelnostStoyanki = "1";

            // Act
            otpravlenie.AddOtpravlenie(reis, vremyaOtpr, vremyaPrib, ostanovka, dlitelnostStoyanki);

            // Assert
            // Add your own assertions here to verify that the data is inserted correctly
        }

        [Test]
        public void DeleteOtpravlenie_DeletesDataFromDatabase()
        {
            // Arrange
            Otpravlenie otpravlenie = new Otpravlenie(ConnectionString);
            int idToDelete = 1; // Specify the ID of the item to delete for the test

            // Act
            otpravlenie.DeleteOtpravlenie(idToDelete);

            // Assert
            // Add your own assertions here to verify that the data is deleted correctly
        }
    }
}
