using NUnit.Framework;
using RaspisanieElektrichekPO.Controller;
using System.Data;

namespace RaspisanieElektrichekPO.Tests
{
    [TestFixture]
    public class MarshrytTests
    {
        private string connectionString = "Server=DESKTOP-CLKTO14\\SQLEXPRESS;Database=RaspisanieElektrichekTest;Trusted_Connection=True;\r\n";

        [Test]
        public void UpdateMarshryt_ReturnsDataTable()
        {
            // Arrange
            var marshryt = new Marshryt(connectionString);

            // Act
            DataTable result = marshryt.UpdateMarshryt();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<DataTable>(result);
        }

        [Test]
        public void AddMarshryt_InsertsDataIntoDatabase()
        {
            // Arrange
            var marshryt = new Marshryt(connectionString);
            string nazvanie = "TestNazvanie";
            string napravlenie = "1";
            string elektrichka = "1";
            string denNedeli = "2";

            // Act
            marshryt.AddMarshryt(nazvanie, napravlenie, elektrichka, denNedeli);

            // Assert - You can add additional assertions here to verify the data was inserted correctly
        }

        [Test]
        public void DeleteMarshryt_DeletesDataFromDatabase()
        {
            // Arrange
            var marshryt = new Marshryt(connectionString);
            int idToDelete = 1; // Specify the ID of the record to delete

            // Act
            marshryt.DeleteMarshryt(idToDelete);

            // Assert - You can add additional assertions here to verify the data was deleted correctly
        }
    }
}
