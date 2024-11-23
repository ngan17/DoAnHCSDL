namespace DAT.ThongKeBanHangCuaNV
{
    partial class ThongKeBanHangCuaNhanVien
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
            this.chartBanHangCuaNV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartBanHangCuaNV)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBanHangCuaNV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBanHangCuaNV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBanHangCuaNV.Legends.Add(legend1);
            this.chartBanHangCuaNV.Location = new System.Drawing.Point(60, 32);
            this.chartBanHangCuaNV.Name = "chartBanHangCuaNV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBanHangCuaNV.Series.Add(series1);
            this.chartBanHangCuaNV.Size = new System.Drawing.Size(1093, 581);
            this.chartBanHangCuaNV.TabIndex = 0;
            this.chartBanHangCuaNV.Text = "chart1";
            // 
            // ThongKeBanHangCuaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 702);
            this.Controls.Add(this.chartBanHangCuaNV);
            this.Name = "ThongKeBanHangCuaNhanVien";
            this.Text = "ThongKeBanHangCuaNV";
            ((System.ComponentModel.ISupportInitialize)(this.chartBanHangCuaNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartBanHangCuaNV;
    }
}