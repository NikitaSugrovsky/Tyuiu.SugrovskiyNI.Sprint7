using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Lib
{
    public class DataService
    {
        public List<double> GetDataForColumn(string filePath, int columnIndex)
        {
            List<double> GetDataForColumn = new List<double>(); // Изменяем на List<double>

            try
            {
                using (var reader = new StreamReader(filePath, Encoding.GetEncoding("Windows-1251")))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        if (values.Length > columnIndex) // Используем переданный индекс
                        {
                            // Заменяем на List<double> и учитываем возможные ошибки при парсинге
                            if (double.TryParse(values[columnIndex].Trim().ToLower(), out double result))
                            {
                                GetDataForColumn.Add(result);
                            }
                            else
                            {
                                Console.WriteLine($"Error parsing value: {values[columnIndex]}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return GetDataForColumn;
        }
    }
}
