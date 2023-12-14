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
        public FormMain()
        {
            InitializeComponent();
            button3.Click += button3_Click;
        }



        private void buttonHelp_SNI_Click_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void dataGridView_SNI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader(resourceName))
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

                    dataGridView_SNI.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
