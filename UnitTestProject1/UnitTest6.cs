using System;
using NUnit.Framework;
using System.Data;

namespace RaspisanieElektrichekPO.Controller.Tests
{
    [TestFixture]
    public class NapravlenieTests
    {
        private const string ConnectionString = "Server=DESKTOP-CLKTO14\\SQLEXPRESS;Database=RaspisanieElektrichekTest;Trusted_Connection=True;\r\n";

        [SetUp]
        public void Setup()
        {
            // Добавьте здесь код, который будет выполняться перед каждым тестом.
            // Например, можно создать и инициализировать тестовую базу данных.
        }

        [TearDown]
        public void TearDown()
        {
            // Добавьте здесь код, который будет выполняться после каждого теста.
            // Например, можно удалить тестовую базу данных или очистить ее содержимое.
        }

        [Test]
        public void UpdateNapravlenie_ReturnsDataTable()
        {
            // Arrange
            var napravlenie = new Napravlenie(ConnectionString);

            // Act
            var result = napravlenie.UpdateNapravlenie();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<DataTable>(result);
        }

        [Test]
        public void AddNapravlenie_AddsNewRecord()
        {
            // Arrange
            var napravlenie = new Napravlenie(ConnectionString);
            string pynknOtpr = "1";
            string pynknNaznach = "2";
            string rassroynie = "200";

            // Act
            napravlenie.AddNapravlenie(pynknOtpr, pynknNaznach, rassroynie);
            var updatedTable = napravlenie.UpdateNapravlenie();

            // Assert
            bool recordExists = false;
            foreach (DataRow row in updatedTable.Rows)
            {
                if (row["PynknOtpr"].ToString() == pynknOtpr &&
                    row["PynknNaznach"].ToString() == pynknNaznach &&
                    row["Rassroynie"].ToString() == rassroynie)

                {
                    recordExists = true;
                    break;
                }
            }

            // Изменим способ проверки наличия записи
            Assert.IsTrue(recordExists, "The added record does not exist in the table.");
        }


        [Test]
        public void DeleteNapravlenie_RemovesRecord()
        {
            // Arrange
            var napravlenie = new Napravlenie(ConnectionString);
            int testRecordId = 123; // Замените на существующий ID записи в вашей базе данных

            // Act
            napravlenie.DeleteNapravlenie(testRecordId);
            var updatedTable = napravlenie.UpdateNapravlenie();

            // Assert
            bool recordExists = false;
            foreach (DataRow row in updatedTable.Rows)
            {
                if ((int)row["ID"] == testRecordId)
                {
                    recordExists = true;
                    break;
                }
            }

            Assert.IsFalse(recordExists);
        }
    }
}
