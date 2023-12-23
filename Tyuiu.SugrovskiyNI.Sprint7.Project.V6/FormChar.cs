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

        private string filePath = @"C:\Users\Admin\source\repos\Tyuiu.SugrovskiyNI.Sprint7\Tyuiu.SugrovskiyNI.Sprint7.Project.V6\bin\Debug\OutputFile_5.csv";
        private int columnIndex = 0;
        public FormChar()
        {
            InitializeComponent();
            dataService = new DataService();


        }
        private List<double> chartData;
        public void UpdateChart(List<double> data)
        {
            // Обновите график с использованием переданных данных
            SetChartData(data);

            // Перерисуйте график
            chart_Line_SNI.Invalidate();
        }

        public void SetChartData(List<double> data)
        {
            chartData = data;

        }


        private void button_charLine_SNI_Click(object sender, EventArgs e)
        {
            List<double> outpatientData = dataService.GetDataForColumn(filePath, columnIndex);

            Series series = new Series("График данных");
            series.ChartType = SeriesChartType.Line;

            // Добавляем точки с использованием Y значения для отображения данных из столбца
            for (int i = 0; i < outpatientData.Count; i++)
            {
                series.Points.AddXY(i + 1, outpatientData[i]); // i + 1, чтобы индексы начинались с 1
            }

            chart_Line_SNI.Series.Add(series);
        }
    
        private void chart_Line_SNI_Click(object sender, EventArgs e)
        {

        }
    }
}
