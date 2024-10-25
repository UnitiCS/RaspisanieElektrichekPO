using NUnit.Framework;
using System.Data;

namespace RaspisanieElektrichekPO.Controller.Tests
{
    [TestFixture]
    public class ElektrichkaTests
    {
        private const string ConnectionString = "Server=DESKTOP-CLKTO14\\SQLEXPRESS;Database=RaspisanieElektrichekTest;Trusted_Connection=True;\r\n";

        [SetUp]
        public void Setup()
        {
            // Здесь можно выполнить необходимую инициализацию перед каждым тестом
        }

        [Test]
        public void UpdateElektrichka_ReturnsDataTable()
        {
            // Arrange
            Elektrichka elektrichka = new Elektrichka(ConnectionString);

            // Act
            DataTable result = elektrichka.UpdateElektrichka();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<DataTable>(result);
        }

        [Test]
        public void AddElektrichka_InsertsDataIntoDatabase()
        {
            // Arrange
            Elektrichka elektrichka = new Elektrichka(ConnectionString);
            string nazvanie = "TestNazvanie";
            string tip = "TestTip";
            string klvoVagongv = "3";

            // Act
            elektrichka.AddElektrichka(nazvanie, tip, klvoVagongv);

            // Assert
            // Добавьте здесь проверки, чтобы убедиться, что данные были вставлены правильно.
            // Можно использовать другие методы класса Elektrichka для проверки добавленных данных или выполнить дополнительные запросы к базе данных.
        }

        //[Test]
       // public void DeleteElektrichka_RemovesDataFromDatabase()
        //{
            // Arrange
           // Elektrichka elektrichka = new Elektrichka(ConnectionString);
            //int idToDelete = 1; // Идентификатор записи, которую вы хотите удалить

            // Act
            //elektrichka.DeleteElektrichka(idToDelete);

            // Assert
            // Добавьте здесь проверки, чтобы убедиться, что данные были удалены правильно.
            // Можно использовать другие методы класса Elektrichka для проверки удаления данных или выполнить дополнительные запросы к базе данных.
        //}
    }
}
