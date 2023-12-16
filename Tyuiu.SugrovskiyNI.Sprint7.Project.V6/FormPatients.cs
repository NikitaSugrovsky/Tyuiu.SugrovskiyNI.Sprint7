using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tyuiu.SugrovskiyNI.Sprint7.Project.V6
{
    public partial class FormPatients : Form
    {
        public FormPatients()
        {
            InitializeComponent();
        }

        private void button_update_SNI_Click(object sender, EventArgs e)
        {
            string Number = textBox_Number_SNI.Text;
            string Patron = textBox_patron_SNI.Text;
            string Surname = textBox_surname_SNI.Text;
            string Name = textBox_Name_SNI.Text;
            string phone_number = textBox_numphon_SNI.Text;
            string date = textBox_date_SNI.Text;

            string DataToSave = $"{Number};{Surname};{Name};{Patron};{date};{phone_number}";

            try
            {
                string filePath = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile.csv";

                // Проверяем наличие заголовков перед открытием потока для записи
                if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
                {
                    string header = "Номер;Отчество;Фамилия:Имя;Дата рождения;Номер телефона";
                    File.WriteAllText(filePath, header, Encoding.UTF8);
                }

                // Открываем файл для записи
                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8))
                {
                    // Записываем данные в новую строку
                    sw.WriteLine(DataToSave.Replace(",", ";"));
                }

                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                // Логгирование ошибок может быть более предпочтительным
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }

        private void button_doctor_1_SNI_Click(object sender, EventArgs e)
        {
            string Number = textBox_Number_SNI.Text;
            string Patron = textBox_patron_SNI.Text;
            string Surname = textBox_surname_SNI.Text;
            string Name = textBox_Name_SNI.Text;
            string phone_number = textBox_numphon_SNI.Text;
            string date = textBox_date_SNI.Text;

            string DataToSave = $"{Number};{Surname};{Name};{Patron};{date};{phone_number}";

            try
            {
                string filePath = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile_1.csv";

                // Проверяем наличие заголовков перед открытием потока для записи
                if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
                {
                    string header = "Номер;Отчество;Фамилия:Имя;Дата рождения;Номер телефона";
                    File.WriteAllText(filePath, header, Encoding.GetEncoding("Windows-1251"));
                }

                // Открываем файл для записи с указанием кодировки Windows-1251
                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.GetEncoding("Windows-1251")))
                {
                    // Записываем данные в новую строку
                    sw.WriteLine(DataToSave.Replace(",", ";"));
                }

                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                // Логгирование ошибок может быть более предпочтительным
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }

        }

        private void button_doctor_2_SNI_Click(object sender, EventArgs e)
        {
            string Number = textBox_Number_SNI.Text;
            string Patron = textBox_patron_SNI.Text;
            string Surname = textBox_surname_SNI.Text;
            string Name = textBox_Name_SNI.Text;
            string phone_number = textBox_numphon_SNI.Text;
            string date = textBox_date_SNI.Text;

            string DataToSave = $"{Number};{Surname};{Name};{Patron};{date};{phone_number}";

            try
            {
                string filePath = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile_2.csv";

                // Проверяем наличие заголовков перед открытием потока для записи
                if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
                {
                    string header = "Номер;Отчество;Фамилия:Имя;Дата рождения;Номер телефона";
                    File.WriteAllText(filePath, header, Encoding.GetEncoding("Windows-1251"));
                }

                // Открываем файл для записи с указанием кодировки Windows-1251
                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.GetEncoding("Windows-1251")))
                {
                    // Записываем данные в новую строку
                    sw.WriteLine(DataToSave.Replace(",", ";"));
                }

                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                // Логгирование ошибок может быть более предпочтительным
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }

        private void button_doctor_3_SNI_Click(object sender, EventArgs e)
        {
            string Number = textBox_Number_SNI.Text;
            string Patron = textBox_patron_SNI.Text;
            string Surname = textBox_surname_SNI.Text;
            string Name = textBox_Name_SNI.Text;
            string phone_number = textBox_numphon_SNI.Text;
            string date = textBox_date_SNI.Text;

            string DataToSave = $"{Number};{Surname};{Name};{Patron};{date};{phone_number}";

            try
            {
                string filePath = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile_3.csv";

                // Проверяем наличие заголовков перед открытием потока для записи
                if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
                {
                    string header = "Номер;Отчество;Фамилия:Имя;Дата рождения;Номер телефона";
                    File.WriteAllText(filePath, header, Encoding.GetEncoding("Windows-1251"));
                }

                // Открываем файл для записи с указанием кодировки Windows-1251
                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.GetEncoding("Windows-1251")))
                {
                    // Записываем данные в новую строку
                    sw.WriteLine(DataToSave.Replace(",", ";"));
                }

                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                // Логгирование ошибок может быть более предпочтительным
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }

        private void button_doctor_4_SNI_Click(object sender, EventArgs e)
        {
            string Number = textBox_Number_SNI.Text;
            string Patron = textBox_patron_SNI.Text;
            string Surname = textBox_surname_SNI.Text;
            string Name = textBox_Name_SNI.Text;
            string phone_number = textBox_numphon_SNI.Text;
            string date = textBox_date_SNI.Text;

            string DataToSave = $"{Number};{Surname};{Name};{Patron};{date};{phone_number}";

            try
            {
                string filePath = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile_4.csv";

                // Проверяем наличие заголовков перед открытием потока для записи
                if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
                {
                    string header = "Номер;Отчество;Фамилия:Имя;Дата рождения;Номер телефона";
                    File.WriteAllText(filePath, header, Encoding.GetEncoding("Windows-1251"));
                }

                // Открываем файл для записи с указанием кодировки Windows-1251
                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.GetEncoding("Windows-1251")))
                {
                    // Записываем данные в новую строку
                    sw.WriteLine(DataToSave.Replace(",", ";"));
                }

                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                // Логгирование ошибок может быть более предпочтительным
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }
    }
}
