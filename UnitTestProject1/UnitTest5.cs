using NUnit.Framework;
using System.Data;

namespace RaspisanieElektrichekPO.Controller.Tests
{
    [TestFixture]
    public class ReisTests
    {
        private const string ConnectionString = "Server=DESKTOP-CLKTO14\\SQLEXPRESS;Database=RaspisanieElektrichekTest;Trusted_Connection=True;\r\n";

        [Test]
        public void UpdateReis_ReturnsDataTable()
        {
            // Arrange
            Reis reis = new Reis(ConnectionString);

            // Act
            DataTable result = reis.UpdateReis();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
            Assert.IsTrue(result.Columns.Count > 0);
        }

        [Test]
        public void AddReis_InsertsNewRow()
        {
            // Arrange
            Reis reis = new Reis(ConnectionString);
            string marshryt = "3";
            string vremyaOtpr = "12:00";
            string vremyaPrib = "13:00";

            // Act
            reis.AddReis(marshryt, vremyaOtpr, vremyaPrib);
            DataTable updatedData = reis.UpdateReis();

            // Assert
            bool rowFound = false;
            foreach (DataRow row in updatedData.Rows)
            {
                if (row["Marshryt"].ToString() == marshryt &&
                    row["VremyaOtpr"].ToString() == vremyaOtpr &&
                    row["VremyaPrib"].ToString() == vremyaPrib)
                {
                    rowFound = true;
                    break;
                }
            }
            Assert.IsTrue(rowFound);
        }

        [Test]
        public void DeleteReis_RemovesExistingRow()
        {
            // Arrange
            Reis reis = new Reis(ConnectionString);
            int idToDelete = 1; // Provide an existing ID to delete

            // Act
            reis.DeleteReis(idToDelete);
            DataTable updatedData = reis.UpdateReis();

            // Assert
            bool rowFound = false;
            foreach (DataRow row in updatedData.Rows)
            {
                if (row["ID"].ToString() == idToDelete.ToString())
                {
                    rowFound = true;
                    break;
                }
            }
            Assert.IsFalse(rowFound);
        }
    }
}
