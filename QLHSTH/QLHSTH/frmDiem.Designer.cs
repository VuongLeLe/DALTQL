namespace QLHSTH
{
    partial class frmDiem
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
            this.cbMHS = new System.Windows.Forms.ComboBox();
            this.txtDHK2 = new System.Windows.Forms.TextBox();
            this.txtDHK1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDiem = new System.Windows.Forms.DataGridView();
            this.cbMM = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDGK1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDGK2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMHS
            // 
            this.cbMHS.FormattingEnabled = true;
            this.cbMHS.Location = new System.Drawing.Point(155, 69);
            this.cbMHS.Name = "cbMHS";
            this.cbMHS.Size = new System.Drawing.Size(160, 21);
            this.cbMHS.TabIndex = 80;
            // 
            // txtDHK2
            // 
            this.txtDHK2.Location = new System.Drawing.Point(468, 165);
            this.txtDHK2.Name = "txtDHK2";
            this.txtDHK2.Size = new System.Drawing.Size(160, 20);
            this.txtDHK2.TabIndex = 79;
            // 
            // txtDHK1
            // 
            this.txtDHK1.Location = new System.Drawing.Point(468, 101);
            this.txtDHK1.Name = "txtDHK1";
            this.txtDHK1.Size = new System.Drawing.Size(160, 20);
            this.txtDHK1.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Tên học sinh:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Điểm học kỳ 1:";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSua.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.Location = new System.Drawing.Point(684, 159);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 29);
            this.btnSua.TabIndex = 74;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.BackColor = System.Drawing.Color.Aquamarine;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Location = new System.Drawing.Point(684, 112);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 29);
            this.btnXoa.TabIndex = 73;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnthem.BackColor = System.Drawing.Color.Aquamarine;
            this.btnthem.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthem.Location = new System.Drawing.Point(684, 69);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(81, 29);
            this.btnthem.TabIndex = 72;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnreturn.BackColor = System.Drawing.Color.PaleGreen;
            this.btnreturn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnreturn.Location = new System.Drawing.Point(338, 420);
            this.btnreturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(128, 41);
            this.btnreturn.TabIndex = 71;
            this.btnreturn.Text = "Quay về";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 47);
            this.panel1.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(227, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 46);
            this.label1.TabIndex = 51;
            this.label1.Text = "Quản lý điểm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtDiem
            // 
            this.dtDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDiem.Location = new System.Drawing.Point(12, 215);
            this.dtDiem.Name = "dtDiem";
            this.dtDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDiem.Size = new System.Drawing.Size(790, 200);
            this.dtDiem.TabIndex = 69;
            this.dtDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDiem_CellContentClick);
            this.dtDiem.Click += new System.EventHandler(this.dtDiem_Click);
            // 
            // cbMM
            // 
            this.cbMM.FormattingEnabled = true;
            this.cbMM.Location = new System.Drawing.Point(155, 120);
            this.cbMM.Name = "cbMM";
            this.cbMM.Size = new System.Drawing.Size(160, 21);
            this.cbMM.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Tên môn:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Điểm giữa học kỳ 1:";
            // 
            // txtDGK1
            // 
            this.txtDGK1.Location = new System.Drawing.Point(468, 69);
            this.txtDGK1.Name = "txtDGK1";
            this.txtDGK1.Size = new System.Drawing.Size(160, 20);
            this.txtDGK1.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Điểm giữa học kỳ 2:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(335, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "Điểm học kỳ 2:";
            // 
            // txtDGK2
            // 
            this.txtDGK2.Location = new System.Drawing.Point(468, 133);
            this.txtDGK2.Name = "txtDGK2";
            this.txtDGK2.Size = new System.Drawing.Size(160, 20);
            this.txtDGK2.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "Điểm trung bình cả năm:";
            // 
            // txtDTB
            // 
            this.txtDTB.BackColor = System.Drawing.SystemColors.Control;
            this.txtDTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDTB.Location = new System.Drawing.Point(155, 161);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(160, 15);
            this.txtDTB.TabIndex = 89;
            this.txtDTB.TextChanged += new System.EventHandler(this.txtDTB_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(155, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 2);
            this.label9.TabIndex = 90;
            this.label9.Text = "label9";
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 463);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDGK2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDGK1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMHS);
            this.Controls.Add(this.txtDHK2);
            this.Controls.Add(this.txtDHK1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtDiem);
            this.Name = "frmDiem";
            this.Text = "frmDiem";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMHS;
        private System.Windows.Forms.TextBox txtDHK2;
        private System.Windows.Forms.TextBox txtDHK1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtDiem;
        private System.Windows.Forms.ComboBox cbMM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDGK1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDGK2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Label label9;
    }
}