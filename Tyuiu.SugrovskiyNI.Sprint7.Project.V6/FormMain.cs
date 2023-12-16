using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Lib;
using System.IO;
using Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Test;


namespace Tyuiu.SugrovskiyNI.Sprint7.Project.V6
{
    public partial class FormMain : Form
    {
        string resourceName = @"C:\DataSprint6\InPutFileTask7V28.csv";
        string doctor_1n = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile_1.csv";
        string doctor_2n = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile_2.csv";
        string doctor_3n = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile_3.csv";
        string doctor_4n = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile_4.csv";

        public FormMain()
        {
            InitializeComponent();
            button_doctor_SNI.Click += button_doctor_SNI_Click;
            button_Search_SNI.Click += button_Search_SNI_Click;
            comboBox_SNI.SelectedIndexChanged += comboBox_SNI_SelectedIndexChanged;
            dataGridView_SNI.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }


        private void buttonHelp_SNI_Click_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void dataGridView_SNI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_SNI.Rows[e.RowIndex];


            }
        }

        private void button_doctor_SNI_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(resourceName, Encoding.GetEncoding("Windows-1251")))
                {
                    DataTable dataTable = new DataTable();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (var value in values)
                            {
                                dataTable.Columns.Add(value, typeof(string));
                            }
                        }
                        else
                        {
                            dataTable.Rows.Add(values);
                        }
                    }

                    // Привязка данных к DataGridView
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_SNI.DataSource = bindingSource;

                    // Отключаем сортировку для каждой колонки
                    foreach (DataGridViewColumn column in dataGridView_SNI.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void buttonSave_SNI_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter("OutputFile.csv", false, Encoding.UTF8))
                {
                    // Записываем заголовочную строку
                    writer.WriteLine(string.Join(";", dataGridView_SNI.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText)));

                    // Записываем строки данных
                    foreach (DataGridViewRow row in dataGridView_SNI.Rows)
                    {
                        var values = row.Cells.Cast<DataGridViewCell>().Select(cell => (cell.Value ?? "").ToString());
                        writer.WriteLine(string.Join(";", values));
                    }

                    MessageBox.Show("Данные успешно сохранены в CSV файл!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void comboBox_SNI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SNI != null && dataGridView_SNI != null && dataGridView_SNI.Columns.Count > 0)
            {
                string selectedColumnName = comboBox_SNI.SelectedItem.ToString();

                // Получаем уникальные значения из выбранного столбца
                var uniqueValues = dataGridView_SNI.Rows.Cast<DataGridViewRow>()
                                      .Select(row => row.Cells[selectedColumnName].Value)
                                      .Where(value => value != null)
                                      .Distinct()
                                      .ToList();

                // Очищаем старые элементы перед добавлением новых
                comboBox_SNI.Items.Clear();
                comboBox_SNI.Items.AddRange(uniqueValues.ToArray());

                // Применяем фильтр снова
                ApplyFilter(textBoxSearch_SNI.Text);
            }
        }

        private void button_Search_SNI_Click(object sender, EventArgs e)
        {
            ApplyFilter(textBoxSearch_SNI.Text);
        }
        private void ApplyFilter(string searchText)
        {
            if (dataGridView_SNI.DataSource is DataTable dataTable)
            {
                if (comboBox_SNI.SelectedItem != null)
                {
                    string columnName = comboBox_SNI.SelectedItem.ToString();

                    if (!string.IsNullOrEmpty(columnName))
                    {
                        dataTable.DefaultView.RowFilter = $"{columnName} LIKE '%{searchText}%'";

                        // Снимаем выделение со всех ячеек перед применением нового фильтра
                        dataGridView_SNI.ClearSelection();

                        // Проходим по всем строкам и выделяем ячейки с найденным текстом
                        foreach (DataGridViewRow row in dataGridView_SNI.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Value != null && cell.Value.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    cell.Selected = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        // Если поиск по пустому столбцу, снимаем выделение со всех ячеек
                        dataGridView_SNI.ClearSelection();
                    }
                }
            }
        }

        private void updatе_SNI_Click(object sender, EventArgs e)
        {
            FormPatients formPatients = new FormPatients();
            formPatients.ShowDialog();
        }

        private void button_doctor1_SNI_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(doctor_1n, Encoding.GetEncoding("Windows-1251")))
                {
                    DataTable dataTable = new DataTable();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (var value in values)
                            {
                                dataTable.Columns.Add(value, typeof(string));
                            }
                        }
                        else
                        {
                            dataTable.Rows.Add(values);
                        }
                    }

                    // Привязка данных к DataGridView
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_SNI.DataSource = bindingSource;

                    // Отключаем сортировку для каждой колонки
                    foreach (DataGridViewColumn column in dataGridView_SNI.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void button_updatе_SNI_Click(object sender, EventArgs e)
        {
            FormPatients formPatients = new FormPatients();
            formPatients.ShowDialog();

        }

        private void buttonSave_1_SNI_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter("OutputFile_1.csv", false, Encoding.UTF8))
                {
                    // Записываем заголовочную строку
                    writer.WriteLine(string.Join(";", dataGridView_SNI.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText)));

                    // Записываем строки данных
                    foreach (DataGridViewRow row in dataGridView_SNI.Rows)
                    {
                        var values = row.Cells.Cast<DataGridViewCell>().Select(cell => (cell.Value ?? "").ToString());
                        writer.WriteLine(string.Join(";", values));
                    }

                    MessageBox.Show("Данные успешно сохранены в CSV файл!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_doctor_2_SNI_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(doctor_2n, Encoding.GetEncoding("Windows-1251")))
                {
                    DataTable dataTable = new DataTable();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (var value in values)
                            {
                                dataTable.Columns.Add(value, typeof(string));
                            }
                        }
                        else
                        {
                            dataTable.Rows.Add(values);
                        }
                    }

                    // Привязка данных к DataGridView
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_SNI.DataSource = bindingSource;

                    // Отключаем сортировку для каждой колонки
                    foreach (DataGridViewColumn column in dataGridView_SNI.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void buttonSave_2_SNI_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter("OutputFile_2.csv", false, Encoding.UTF8))
                {
                    // Записываем заголовочную строку
                    writer.WriteLine(string.Join(";", dataGridView_SNI.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText)));

                    // Записываем строки данных
                    foreach (DataGridViewRow row in dataGridView_SNI.Rows)
                    {
                        var values = row.Cells.Cast<DataGridViewCell>().Select(cell => (cell.Value ?? "").ToString());
                        writer.WriteLine(string.Join(";", values));
                    }

                    MessageBox.Show("Данные успешно сохранены в CSV файл!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_3_SNI_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(doctor_3n, Encoding.GetEncoding("Windows-1251")))
                {
                    DataTable dataTable = new DataTable();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (var value in values)
                            {
                                dataTable.Columns.Add(value, typeof(string));
                            }
                        }
                        else
                        {
                            dataTable.Rows.Add(values);
                        }
                    }

                    // Привязка данных к DataGridView
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_SNI.DataSource = bindingSource;

                    // Отключаем сортировку для каждой колонки
                    foreach (DataGridViewColumn column in dataGridView_SNI.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void button_doctor_3_SNI_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(doctor_3n, Encoding.GetEncoding("Windows-1251")))
                {
                    DataTable dataTable = new DataTable();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (var value in values)
                            {
                                dataTable.Columns.Add(value, typeof(string));
                            }
                        }
                        else
                        {
                            dataTable.Rows.Add(values);
                        }
                    }

                    // Привязка данных к DataGridView
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_SNI.DataSource = bindingSource;

                    // Отключаем сортировку для каждой колонки
                    foreach (DataGridViewColumn column in dataGridView_SNI.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void button_doctor_4_SNI_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(doctor_4n, Encoding.GetEncoding("Windows-1251")))
                {
                    DataTable dataTable = new DataTable();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (var value in values)
                            {
                                dataTable.Columns.Add(value, typeof(string));
                            }
                        }
                        else
                        {
                            dataTable.Rows.Add(values);
                        }
                    }

                    // Привязка данных к DataGridView
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_SNI.DataSource = bindingSource;

                    // Отключаем сортировку для каждой колонки
                    foreach (DataGridViewColumn column in dataGridView_SNI.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void buttonSave_4_SNI_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(doctor_3n, Encoding.GetEncoding("Windows-1251")))
                {
                    DataTable dataTable = new DataTable();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (var value in values)
                            {
                                dataTable.Columns.Add(value, typeof(string));
                            }
                        }
                        else
                        {
                            dataTable.Rows.Add(values);
                        }
                    }

                    // Привязка данных к DataGridView
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_SNI.DataSource = bindingSource;

                    // Отключаем сортировку для каждой колонки
                    foreach (DataGridViewColumn column in dataGridView_SNI.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
                
            
        
