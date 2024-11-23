namespace DAT
{
    partial class ThongKeDoanhThu
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
            this.chartDoanhThuThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuThang)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDoanhThuThang
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThuThang.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThuThang.Legends.Add(legend1);
            this.chartDoanhThuThang.Location = new System.Drawing.Point(61, 94);
            this.chartDoanhThuThang.Name = "chartDoanhThuThang";
            this.chartDoanhThuThang.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDoanhThuThang.Series.Add(series1);
            this.chartDoanhThuThang.Size = new System.Drawing.Size(882, 300);
            this.chartDoanhThuThang.TabIndex = 0;
            this.chartDoanhThuThang.Text = "chart1";
            // 
            // ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 551);
            this.Controls.Add(this.chartDoanhThuThang);
            this.Name = "ThongKeDoanhThu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuThang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThuThang;
    }
}

