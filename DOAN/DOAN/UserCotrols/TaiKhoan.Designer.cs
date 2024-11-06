namespace DOAN.UserCotrols
{
    partial class TaiKhoan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uiButton4 = new Sunny.UI.UIButton();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.txt_tenTK = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiButton5 = new Sunny.UI.UIButton();
            this.txt_MatKhau = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txtMa = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txt_hash = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.cbo_role = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbo_tt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1287, 430);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uiButton4
            // 
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton4.Location = new System.Drawing.Point(697, 96);
            this.uiButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.Size = new System.Drawing.Size(100, 35);
            this.uiButton4.TabIndex = 26;
            this.uiButton4.Text = "Tìm kiếm";
            this.uiButton4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton3.Location = new System.Drawing.Point(506, 96);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(100, 35);
            this.uiButton3.TabIndex = 25;
            this.uiButton3.Text = "Sửa";
            this.uiButton3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton2.Location = new System.Drawing.Point(301, 99);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 24;
            this.uiButton2.Text = "Xoá ";
            this.uiButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton1.Location = new System.Drawing.Point(94, 99);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 23;
            this.uiButton1.Text = "Thêm";
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // txt_tenTK
            // 
            this.txt_tenTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenTK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_tenTK.Location = new System.Drawing.Point(201, 25);
            this.txt_tenTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_tenTK.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_tenTK.Name = "txt_tenTK";
            this.txt_tenTK.ShowText = false;
            this.txt_tenTK.Size = new System.Drawing.Size(191, 29);
            this.txt_tenTK.TabIndex = 20;
            this.txt_tenTK.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_tenTK.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txt_tenTK.TextChanged += new System.EventHandler(this.uiTextBox1_TextChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(47, 25);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(147, 23);
            this.uiLabel1.TabIndex = 16;
            this.uiLabel1.Text = "Tên tài khoản";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton5
            // 
            this.uiButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton5.Location = new System.Drawing.Point(885, 99);
            this.uiButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton5.Name = "uiButton5";
            this.uiButton5.Size = new System.Drawing.Size(100, 35);
            this.uiButton5.TabIndex = 27;
            this.uiButton5.Text = "Lưu";
            this.uiButton5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_MatKhau.Location = new System.Drawing.Point(560, 22);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MatKhau.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.ShowText = false;
            this.txt_MatKhau.Size = new System.Drawing.Size(196, 29);
            this.txt_MatKhau.TabIndex = 29;
            this.txt_MatKhau.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_MatKhau.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(453, 28);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(147, 23);
            this.uiLabel2.TabIndex = 28;
            this.uiLabel2.Text = "SaltPass";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtMa
            // 
            this.txtMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMa.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtMa.Location = new System.Drawing.Point(560, 61);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMa.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMa.Name = "txtMa";
            this.txtMa.ShowText = false;
            this.txtMa.Size = new System.Drawing.Size(196, 29);
            this.txtMa.TabIndex = 33;
            this.txtMa.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMa.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(412, 67);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(147, 23);
            this.uiLabel3.TabIndex = 32;
            this.uiLabel3.Text = "Mã nhân viên";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txt_hash
            // 
            this.txt_hash.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_hash.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_hash.Location = new System.Drawing.Point(201, 64);
            this.txt_hash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_hash.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_hash.Name = "txt_hash";
            this.txt_hash.ShowText = false;
            this.txt_hash.Size = new System.Drawing.Size(191, 29);
            this.txt_hash.TabIndex = 31;
            this.txt_hash.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_hash.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(47, 64);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(147, 23);
            this.uiLabel4.TabIndex = 30;
            this.uiLabel4.Text = "HashPass";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(796, 23);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(147, 23);
            this.uiLabel5.TabIndex = 30;
            this.uiLabel5.Text = "Trạng thái";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.Location = new System.Drawing.Point(796, 62);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(147, 23);
            this.uiLabel6.TabIndex = 34;
            this.uiLabel6.Text = "Role";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbo_role
            // 
            this.cbo_role.FormattingEnabled = true;
            this.cbo_role.Location = new System.Drawing.Point(903, 64);
            this.cbo_role.Name = "cbo_role";
            this.cbo_role.Size = new System.Drawing.Size(146, 24);
            this.cbo_role.TabIndex = 35;
            // 
            // cbo_tt
            // 
            this.cbo_tt.FormattingEnabled = true;
            this.cbo_tt.Location = new System.Drawing.Point(903, 25);
            this.cbo_tt.Name = "cbo_tt";
            this.cbo_tt.Size = new System.Drawing.Size(146, 24);
            this.cbo_tt.TabIndex = 36;
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbo_tt);
            this.Controls.Add(this.cbo_role);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_hash);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiButton5);
            this.Controls.Add(this.uiButton4);
            this.Controls.Add(this.uiButton3);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.txt_tenTK);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TaiKhoan";
            this.Size = new System.Drawing.Size(1349, 777);
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UITextBox txt_tenTK;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton uiButton5;
        private Sunny.UI.UITextBox txt_MatKhau;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtMa;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txt_hash;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private System.Windows.Forms.ComboBox cbo_role;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cbo_tt;
    }
}
