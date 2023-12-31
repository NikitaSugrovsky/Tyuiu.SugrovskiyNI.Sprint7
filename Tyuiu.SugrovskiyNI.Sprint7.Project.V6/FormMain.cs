﻿using System;
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
        string resourceName = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile_5.csv";
        string doctor_1n = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile_1.csv";
        string doctor_2n = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile_2.csv";
        string doctor_3n = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile_3.csv";
        string doctor_4n = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile_4.csv";

        public FormMain()
        {
            InitializeComponent();
            button_doctor_SNI.Click += button_doctor_SNI_Click;
            button_Search_SNI.Click += button_Search_SNI_Click;
            dataGridView_SNI.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        DataService ds = new DataService();



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

                    writer.WriteLine(string.Join(";", dataGridView_SNI.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText)));


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




        private void button_Search_SNI_Click(object sender, EventArgs e)
        {
            ApplyFilter(textBoxSearch_SNI.Text);

        }
        private void ApplyFilter(string searchText)
        {
            if (dataGridView_SNI.DataSource is DataTable dataTable)
            {
                // Применяем фильтр ко всем колонкам таблицы
                string filterExpression = string.Join(" OR ",
                    dataTable.Columns.Cast<DataColumn>().Select(column =>
                        $"{column.ColumnName} LIKE '%{searchText}%'"));

                dataTable.DefaultView.RowFilter = filterExpression;

                // Снимаем выделение ячеек
                dataGridView_SNI.ClearSelection();
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


                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_SNI.DataSource = bindingSource;


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


                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_SNI.DataSource = bindingSource;


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


                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_SNI.DataSource = bindingSource;


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


                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_SNI.DataSource = bindingSource;


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


                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView_SNI.DataSource = bindingSource;


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

        private void button_Help_s_SNI_Click(object sender, EventArgs e)
        {
            FormHelp FormHelp = new FormHelp();
            FormHelp.ShowDialog();
        }

        private void button_INFO_DOCTOR_1_SNI_Click(object sender, EventArgs e)
        {
            FormDoctor_1 FormDoctor_1 = new FormDoctor_1();
            FormDoctor_1.ShowDialog();
        }

        private void button_INFO_DOCTOR_2_SNI_Click(object sender, EventArgs e)
        {
            FormDoctor_2 FormDoctor_2 = new FormDoctor_2();
            FormDoctor_2.ShowDialog();
        }

        private void button_INFO_DOCTOR_3_SNI_Click(object sender, EventArgs e)
        {
            FormDoctor_3 FormDoctor_3 = new FormDoctor_3();
            FormDoctor_3.ShowDialog();
        }

        private void button_INFO_DOCTOR_4_SNI_Click(object sender, EventArgs e)
        {
            FormDoctor_4 FormDoctor_4 = new FormDoctor_4();
            FormDoctor_4.ShowDialog();
        }

        private void button_INFO_DOCTOR_5_SNI_Click(object sender, EventArgs e)
        {
            FormDoctor_5 FormDoctor_5 = new FormDoctor_5();
            FormDoctor_5.ShowDialog();
        }
        private void button_Help_s_SNI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Нажми сюда";
        }

        private void textBoxSearch_SNI_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_SNI.Text;

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

        private void button_Line_SNI_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile_5.csv";
            int columnIndex = 8;

            List<double> data = ds.GetDataForColumn(filePath, columnIndex);

            // Создайте экземпляр FormChar
            FormChar formChar = new FormChar();

            // Передайте данные в FormChar и обновите график
            formChar.UpdateChart(data);

            // Отобразите FormChar
            formChar.ShowDialog();
        }
    }
}

                
            
        
