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
            List<double> data = new List<double>();

            try
            {
                using (var reader = new StreamReader(filePath, Encoding.GetEncoding("Windows-1251")))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        if (values.Length > columnIndex && double.TryParse(values[columnIndex], out double value))
                        {
                            data.Add(value);
                        }
                        else
                        {
                            // Обработка ошибок, например, если значение не является числом
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                // Обработка ошибок чтения файла
            }

            return data;
        }
    }
}
