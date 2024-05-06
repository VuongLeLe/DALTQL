namespace QLHSTH
{
    partial class frmdmHocSinh
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
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtDSHS = new System.Windows.Forms.DataGridView();
            this.grPhai = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.btnThoatHS = new System.Windows.Forms.Button();
            this.btnXoaHS = new System.Windows.Forms.Button();
            this.btnSuaHS = new System.Windows.Forms.Button();
            this.btnThemHS = new System.Windows.Forms.Button();
            this.dtpNSHS = new System.Windows.Forms.DateTimePicker();
            this.txtTenHS = new System.Windows.Forms.TextBox();
            this.txtHoHS = new System.Windows.Forms.TextBox();
            this.txtMHS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimTenHS = new System.Windows.Forms.Button();
            this.txtTimTenHS = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSHS)).BeginInit();
            this.grPhai.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLop
            // 
            this.cbLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(394, 228);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(150, 21);
            this.cbLop.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(311, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 85;
            this.label8.Text = "Lớp học:";
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.Location = new System.Drawing.Point(175, 225);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(130, 20);
            this.txtSDT.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Số điện thoại:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "Danh sách học sinh";
            // 
            // dtDSHS
            // 
            this.dtDSHS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtDSHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDSHS.Location = new System.Drawing.Point(35, 271);
            this.dtDSHS.Name = "dtDSHS";
            this.dtDSHS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDSHS.Size = new System.Drawing.Size(745, 240);
            this.dtDSHS.TabIndex = 81;
            this.dtDSHS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDSHS_CellContentClick);
            // 
            // grPhai
            // 
            this.grPhai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grPhai.Controls.Add(this.radNu);
            this.grPhai.Controls.Add(this.radNam);
            this.grPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grPhai.Location = new System.Drawing.Point(70, 182);
            this.grPhai.Name = "grPhai";
            this.grPhai.Size = new System.Drawing.Size(198, 43);
            this.grPhai.TabIndex = 80;
            this.grPhai.TabStop = false;
            this.grPhai.Text = "Giới tính";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(108, 16);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(41, 17);
            this.radNu.TabIndex = 27;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(39, 14);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(50, 17);
            this.radNam.TabIndex = 26;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // btnThoatHS
            // 
            this.btnThoatHS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoatHS.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThoatHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatHS.Location = new System.Drawing.Point(676, 204);
            this.btnThoatHS.Name = "btnThoatHS";
            this.btnThoatHS.Size = new System.Drawing.Size(100, 45);
            this.btnThoatHS.TabIndex = 79;
            this.btnThoatHS.Text = "Thoát";
            this.btnThoatHS.UseVisualStyleBackColor = false;
            this.btnThoatHS.Click += new System.EventHandler(this.btnThoatHS_Click);
            // 
            // btnXoaHS
            // 
            this.btnXoaHS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaHS.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnXoaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHS.Location = new System.Drawing.Point(562, 204);
            this.btnXoaHS.Name = "btnXoaHS";
            this.btnXoaHS.Size = new System.Drawing.Size(100, 45);
            this.btnXoaHS.TabIndex = 77;
            this.btnXoaHS.Text = "Xóa";
            this.btnXoaHS.UseVisualStyleBackColor = false;
            this.btnXoaHS.Click += new System.EventHandler(this.btnXoaHS_Click);
            // 
            // btnSuaHS
            // 
            this.btnSuaHS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaHS.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSuaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHS.Location = new System.Drawing.Point(676, 146);
            this.btnSuaHS.Name = "btnSuaHS";
            this.btnSuaHS.Size = new System.Drawing.Size(100, 45);
            this.btnSuaHS.TabIndex = 75;
            this.btnSuaHS.Text = "Sửa";
            this.btnSuaHS.UseVisualStyleBackColor = false;
            this.btnSuaHS.Click += new System.EventHandler(this.btnSuaHS_Click);
            // 
            // btnThemHS
            // 
            this.btnThemHS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemHS.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThemHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHS.Location = new System.Drawing.Point(562, 146);
            this.btnThemHS.Name = "btnThemHS";
            this.btnThemHS.Size = new System.Drawing.Size(100, 45);
            this.btnThemHS.TabIndex = 74;
            this.btnThemHS.Text = "Thêm";
            this.btnThemHS.UseVisualStyleBackColor = false;
            this.btnThemHS.Click += new System.EventHandler(this.btnThemHS_Click);
            // 
            // dtpNSHS
            // 
            this.dtpNSHS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNSHS.Location = new System.Drawing.Point(394, 197);
            this.dtpNSHS.Name = "dtpNSHS";
            this.dtpNSHS.Size = new System.Drawing.Size(150, 20);
            this.dtpNSHS.TabIndex = 73;
            // 
            // txtTenHS
            // 
            this.txtTenHS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenHS.Location = new System.Drawing.Point(394, 152);
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.Size = new System.Drawing.Size(150, 20);
            this.txtTenHS.TabIndex = 71;
            // 
            // txtHoHS
            // 
            this.txtHoHS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHoHS.Location = new System.Drawing.Point(177, 152);
            this.txtHoHS.Name = "txtHoHS";
            this.txtHoHS.Size = new System.Drawing.Size(211, 20);
            this.txtHoHS.TabIndex = 70;
            // 
            // txtMHS
            // 
            this.txtMHS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMHS.Location = new System.Drawing.Point(177, 95);
            this.txtMHS.Name = "txtMHS";
            this.txtMHS.Size = new System.Drawing.Size(100, 20);
            this.txtMHS.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Họ tên học sinh:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Mã học sinh:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnTimTenHS);
            this.groupBox1.Controls.Add(this.txtTimTenHS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 42);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm học sinh";
            // 
            // btnTimTenHS
            // 
            this.btnTimTenHS.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTimTenHS.Location = new System.Drawing.Point(501, 9);
            this.btnTimTenHS.Name = "btnTimTenHS";
            this.btnTimTenHS.Size = new System.Drawing.Size(91, 27);
            this.btnTimTenHS.TabIndex = 1;
            this.btnTimTenHS.Text = "Tìm Tên";
            this.btnTimTenHS.UseVisualStyleBackColor = false;
            this.btnTimTenHS.Click += new System.EventHandler(this.btnTimTenHS_Click);
            // 
            // txtTimTenHS
            // 
            this.txtTimTenHS.Location = new System.Drawing.Point(117, 9);
            this.txtTimTenHS.Name = "txtTimTenHS";
            this.txtTimTenHS.Size = new System.Drawing.Size(366, 20);
            this.txtTimTenHS.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 47);
            this.panel1.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(224, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 46);
            this.label6.TabIndex = 51;
            this.label6.Text = "Quản lý học sinh";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Học phí: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtHP
            // 
            this.txtHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHP.Location = new System.Drawing.Point(444, 95);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(100, 20);
            this.txtHP.TabIndex = 88;
            // 
            // frmdmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 517);
            this.Controls.Add(this.txtHP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtDSHS);
            this.Controls.Add(this.grPhai);
            this.Controls.Add(this.btnThoatHS);
            this.Controls.Add(this.btnXoaHS);
            this.Controls.Add(this.btnSuaHS);
            this.Controls.Add(this.btnThemHS);
            this.Controls.Add(this.dtpNSHS);
            this.Controls.Add(this.txtTenHS);
            this.Controls.Add(this.txtHoHS);
            this.Controls.Add(this.txtMHS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmdmHocSinh";
            this.Text = "frmdmHocSinh";
            this.Load += new System.EventHandler(this.frmdmHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDSHS)).EndInit();
            this.grPhai.ResumeLayout(false);
            this.grPhai.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtDSHS;
        private System.Windows.Forms.GroupBox grPhai;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Button btnThoatHS;
        private System.Windows.Forms.Button btnXoaHS;
        private System.Windows.Forms.Button btnSuaHS;
        public System.Windows.Forms.Button btnThemHS;
        private System.Windows.Forms.DateTimePicker dtpNSHS;
        private System.Windows.Forms.TextBox txtTenHS;
        private System.Windows.Forms.TextBox txtHoHS;
        private System.Windows.Forms.TextBox txtMHS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimTenHS;
        private System.Windows.Forms.TextBox txtTimTenHS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHP;
    }
}