using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Lib;
using System.IO;

namespace Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string filePath = @"C:\DataSprint6\InPutFileTask7V28.csv";

            AddDataToCSV(filePath);
        }

        private void AddDataToCSV(string filePath)
        {
            try
            {
                using (var writer = new StreamWriter(filePath, true)) // открываем файл для дозаписи
                {
                    // Пример добавления строки в формате "Врач;Пациенты"
                    writer.WriteLine("НовыйДоктор;Пациент1, Пациент2");
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок при записи в файл
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
