namespace GrafikoaSalmentak
{
    partial class UserControl2
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
            this.GrafikoaSalmentak = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.GrafikoaSalmentak)).BeginInit();
            this.SuspendLayout();
            // 
            // GrafikoaSalmentak
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea1.Name = "ChartArea1";
            this.GrafikoaSalmentak.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GrafikoaSalmentak.Legends.Add(legend1);
            this.GrafikoaSalmentak.Location = new System.Drawing.Point(199, 81);
            this.GrafikoaSalmentak.Name = "GrafikoaSalmentak";
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "PointWidth=0.9";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GrafikoaSalmentak.Series.Add(series1);
            this.GrafikoaSalmentak.Size = new System.Drawing.Size(317, 300);
            this.GrafikoaSalmentak.TabIndex = 0;
            this.GrafikoaSalmentak.Text = "chart1";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrafikoaSalmentak);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.GrafikoaSalmentak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GrafikoaSalmentak;
    }
}
