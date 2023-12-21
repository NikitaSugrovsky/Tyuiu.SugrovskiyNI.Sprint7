
namespace Tyuiu.SugrovskiyNI.Sprint7.Project.V6
{
    partial class FormChar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_Line_SNI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_charLine_SNI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Line_SNI)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Line_SNI
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Line_SNI.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Line_SNI.Legends.Add(legend1);
            this.chart_Line_SNI.Location = new System.Drawing.Point(12, 21);
            this.chart_Line_SNI.Name = "chart_Line_SNI";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Lime;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_Line_SNI.Series.Add(series1);
            this.chart_Line_SNI.Size = new System.Drawing.Size(776, 354);
            this.chart_Line_SNI.TabIndex = 0;
            this.chart_Line_SNI.Text = "chart1";
            this.chart_Line_SNI.Click += new System.EventHandler(this.chart_Line_SNI_Click);
            // 
            // button_charLine_SNI
            // 
            this.button_charLine_SNI.Location = new System.Drawing.Point(637, 394);
            this.button_charLine_SNI.Name = "button_charLine_SNI";
            this.button_charLine_SNI.Size = new System.Drawing.Size(151, 44);
            this.button_charLine_SNI.TabIndex = 1;
            this.button_charLine_SNI.Text = "Построить график";
            this.button_charLine_SNI.UseVisualStyleBackColor = true;
            this.button_charLine_SNI.Click += new System.EventHandler(this.button_charLine_SNI_Click);
            // 
            // FormChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_charLine_SNI);
            this.Controls.Add(this.chart_Line_SNI);
            this.Name = "FormChar";
            this.Text = "FormChar";
            ((System.ComponentModel.ISupportInitialize)(this.chart_Line_SNI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Line_SNI;
        private System.Windows.Forms.Button button_charLine_SNI;
    }
}