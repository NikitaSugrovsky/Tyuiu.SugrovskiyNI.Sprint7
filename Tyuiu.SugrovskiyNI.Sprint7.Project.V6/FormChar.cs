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

namespace Tyuiu.SugrovskiyNI.Sprint7.Project.V6
{
    public partial class FormChar : Form
    {
        private readonly DataService dataService;


        public FormChar()
        {
            InitializeComponent();
            dataService = new DataService();


        }



        private void button_charLine_SNI_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile_5.csv";
            int columnIndex = 9; // Измените индекс в соответствии с вашими требованиями

            List<double> data = dataService.GetDataForColumn(filePath, columnIndex);

            // Присвойте данные к dataGridView_SNI
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = data.Select(value => new { Value = value }).ToList();
           
        }
    
    private void chart_Line_SNI_Click(object sender, EventArgs e)
        {

        }
    }
}
