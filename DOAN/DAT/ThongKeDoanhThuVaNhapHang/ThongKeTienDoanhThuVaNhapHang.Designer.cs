namespace DAT
{
    partial class ThongKeTienDoanhThuVaNhapHang
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
            this.chartDoanhThuVaNhapHang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuVaNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDoanhThuVaNhapHang
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThuVaNhapHang.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThuVaNhapHang.Legends.Add(legend1);
            this.chartDoanhThuVaNhapHang.Location = new System.Drawing.Point(31, 73);
            this.chartDoanhThuVaNhapHang.Name = "chartDoanhThuVaNhapHang";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDoanhThuVaNhapHang.Series.Add(series1);
            this.chartDoanhThuVaNhapHang.Size = new System.Drawing.Size(1087, 601);
            this.chartDoanhThuVaNhapHang.TabIndex = 0;
            this.chartDoanhThuVaNhapHang.Text = "chart1";
            // 
            // ThongKeTienDoanhThuVaNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 768);
            this.Controls.Add(this.chartDoanhThuVaNhapHang);
            this.Name = "ThongKeTienDoanhThuVaNhapHang";
            this.Text = "ThongKeTienDoanhThuVaNhapHang";
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuVaNhapHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThuVaNhapHang;
    }
}