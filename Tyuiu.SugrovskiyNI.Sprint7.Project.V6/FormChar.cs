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
        public FormChar()
        {
            InitializeComponent();
        }

        private void button_charLine_SNI_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            // Указываем путь к файлу и индекс столбца, который вы хотите отобразить на графике
            string filePath = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile_5.csv";
            int columnIndex = 9; // Измените индекс в соответствии с вашими требованиями

            List<double> data = DataService.GetDataForColumn(filePath, columnIndex);
        }
    }
    private void chart_Line_SNI_Click(object sender, EventArgs e)
        {

        }
    }
}
