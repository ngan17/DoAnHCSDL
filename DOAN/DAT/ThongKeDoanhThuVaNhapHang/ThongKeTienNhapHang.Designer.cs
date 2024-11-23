namespace DAT
{
    partial class ThongKeTienNhapHang
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
            this.chartTienNhapHang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTienNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTienNhapHang
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTienNhapHang.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTienNhapHang.Legends.Add(legend1);
            this.chartTienNhapHang.Location = new System.Drawing.Point(44, 60);
            this.chartTienNhapHang.Name = "chartTienNhapHang";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTienNhapHang.Series.Add(series1);
            this.chartTienNhapHang.Size = new System.Drawing.Size(1011, 363);
            this.chartTienNhapHang.TabIndex = 0;
            this.chartTienNhapHang.Text = "chart1";
            // 
            // ThongKeTienNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 623);
            this.Controls.Add(this.chartTienNhapHang);
            this.Name = "ThongKeTienNhapHang";
            this.Text = "ThongKeTienNhapHang";
            ((System.ComponentModel.ISupportInitialize)(this.chartTienNhapHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTienNhapHang;
    }
}