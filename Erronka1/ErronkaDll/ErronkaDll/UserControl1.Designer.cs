﻿namespace ErronkaDll
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // PieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea1);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.PieChart.Legends.Add(legend1);
            this.PieChart.Location = new System.Drawing.Point(154, 31);
            this.PieChart.Name = "PieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "PieLabelStyle=Disabled";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.PieChart.Series.Add(series1);
            this.PieChart.Size = new System.Drawing.Size(462, 374);
            this.PieChart.TabIndex = 0;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PieChart);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
    }
}
