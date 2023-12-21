using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
        private List<double> chartData;

        public void SetChartData(List<double> data)
        {
            chartData = data;
        }


        private void button_charLine_SNI_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile_5.csv";
            int columnIndex = 0;

            // Получаем данные из DataService
            chartData = dataService.GetDataForColumn(filePath, columnIndex);

            // Очищаем существующие серии графика
            chart_Line_SNI.Series.Clear();

            // Добавляем новую серию данных
            Series series = new Series("График данных");
            series.ChartType = SeriesChartType.Line;

            for (int i = 0; i < chartData.Count; i++)
            {
                series.Points.AddXY(i + 1, chartData[i]);
            }

            // Добавляем серию на график
            chart_Line_SNI.Series.Add(series);

        }
    
    private void chart_Line_SNI_Click(object sender, EventArgs e)
        {

        }
    }
}
