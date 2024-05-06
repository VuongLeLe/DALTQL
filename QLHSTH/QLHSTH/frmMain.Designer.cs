
namespace QLHSTH
{
    partial class frmMain
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
            this.Strip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.HT = new System.Windows.Forms.ToolStripMenuItem();
            this.DN = new System.Windows.Forms.ToolStripMenuItem();
            this.DX = new System.Windows.Forms.ToolStripMenuItem();
            this.Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.DM = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HS = new System.Windows.Forms.ToolStripMenuItem();
            this.GV = new System.Windows.Forms.ToolStripMenuItem();
            this.BC = new System.Windows.Forms.ToolStripMenuItem();
            this.BCNV = new System.Windows.Forms.ToolStripMenuItem();
            this.BCL = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoGiáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanTri = new System.Windows.Forms.ToolStripMenuItem();
            this.SaoLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.PhucHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NV = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Strip1
            // 
            this.Strip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip1,
            this.toolStrip2});
            this.Strip1.Location = new System.Drawing.Point(0, 427);
            this.Strip1.Name = "Strip1";
            this.Strip1.Size = new System.Drawing.Size(739, 22);
            this.Strip1.TabIndex = 3;
            this.Strip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(118, 17);
            this.toolStrip1.Text = "toolStripStatusLabel1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(118, 17);
            this.toolStrip2.Text = "toolStripStatusLabel2";
            // 
            // HT
            // 
            this.HT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DN,
            this.DX,
            this.Thoat});
            this.HT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HT.Name = "HT";
            this.HT.Size = new System.Drawing.Size(78, 21);
            this.HT.Text = "Hệ thống";
            // 
            // DN
            // 
            this.DN.Name = "DN";
            this.DN.Size = new System.Drawing.Size(144, 22);
            this.DN.Text = "Đăng nhập";
            this.DN.Click += new System.EventHandler(this.DN_Click);
            // 
            // DX
            // 
            this.DX.Name = "DX";
            this.DX.Size = new System.Drawing.Size(144, 22);
            this.DX.Text = "Đăng xuất";
            this.DX.Click += new System.EventHandler(this.DX_Click);
            // 
            // Thoat
            // 
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(144, 22);
            this.Thoat.Text = "Thoát";
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // DM
            // 
            this.DM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcVụToolStripMenuItem,
            this.HS,
            this.GV});
            this.DM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DM.Name = "DM";
            this.DM.Size = new System.Drawing.Size(83, 21);
            this.DM.Text = "Danh mục";
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chứcVụToolStripMenuItem.Text = "Bảng điểm";
            this.chứcVụToolStripMenuItem.Click += new System.EventHandler(this.chứcVụToolStripMenuItem_Click);
            // 
            // HS
            // 
            this.HS.Name = "HS";
            this.HS.Size = new System.Drawing.Size(180, 22);
            this.HS.Text = "Học sinh";
            this.HS.Click += new System.EventHandler(this.nhanViênToolStripMenuItem_Click);
            // 
            // GV
            // 
            this.GV.Name = "GV";
            this.GV.Size = new System.Drawing.Size(180, 22);
            this.GV.Text = "Giáo Viên";
            this.GV.Click += new System.EventHandler(this.giáoViênToolStripMenuItem_Click);
            // 
            // BC
            // 
            this.BC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BCNV,
            this.BCL,
            this.báoCáoGiáoViênToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.báoCáoMônHọcToolStripMenuItem,
            this.báoCáoLớpHọcToolStripMenuItem});
            this.BC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BC.Name = "BC";
            this.BC.Size = new System.Drawing.Size(68, 21);
            this.BC.Text = "Báo cáo";
            // 
            // BCNV
            // 
            this.BCNV.Name = "BCNV";
            this.BCNV.Size = new System.Drawing.Size(185, 22);
            this.BCNV.Text = "Báo cáo Điểm";
            // 
            // BCL
            // 
            this.BCL.Name = "BCL";
            this.BCL.Size = new System.Drawing.Size(185, 22);
            this.BCL.Text = "Báo cáo học sinh";
            // 
            // báoCáoGiáoViênToolStripMenuItem
            // 
            this.báoCáoGiáoViênToolStripMenuItem.Name = "báoCáoGiáoViênToolStripMenuItem";
            this.báoCáoGiáoViênToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.báoCáoGiáoViênToolStripMenuItem.Text = "Báo cáo giáo viên";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo chức vụ";
            // 
            // báoCáoMônHọcToolStripMenuItem
            // 
            this.báoCáoMônHọcToolStripMenuItem.Name = "báoCáoMônHọcToolStripMenuItem";
            this.báoCáoMônHọcToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.báoCáoMônHọcToolStripMenuItem.Text = "Báo cáo môn học";
            // 
            // báoCáoLớpHọcToolStripMenuItem
            // 
            this.báoCáoLớpHọcToolStripMenuItem.Name = "báoCáoLớpHọcToolStripMenuItem";
            this.báoCáoLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.báoCáoLớpHọcToolStripMenuItem.Text = "Báo cáo lớp học";
            // 
            // QuanTri
            // 
            this.QuanTri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaoLuu,
            this.PhucHoi});
            this.QuanTri.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanTri.Name = "QuanTri";
            this.QuanTri.Size = new System.Drawing.Size(71, 21);
            this.QuanTri.Text = "Quản trị";
            // 
            // SaoLuu
            // 
            this.SaoLuu.Name = "SaoLuu";
            this.SaoLuu.Size = new System.Drawing.Size(130, 22);
            this.SaoLuu.Text = "Sao lưu";
            this.SaoLuu.Click += new System.EventHandler(this.SaoLuu_Click);
            // 
            // PhucHoi
            // 
            this.PhucHoi.Name = "PhucHoi";
            this.PhucHoi.Size = new System.Drawing.Size(130, 22);
            this.PhucHoi.Text = "Phục hồi";
            this.PhucHoi.Click += new System.EventHandler(this.PhucHoi_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Aquamarine;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HT,
            this.DM,
            this.NV,
            this.BC,
            this.QuanTri,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NV
            // 
            this.NV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcVụToolStripMenuItem3,
            this.mônHọcToolStripMenuItem,
            this.lớpHọcToolStripMenuItem});
            this.NV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NV.Name = "NV";
            this.NV.Size = new System.Drawing.Size(84, 21);
            this.NV.Text = "Nghiệp vụ";
            // 
            // chứcVụToolStripMenuItem3
            // 
            this.chứcVụToolStripMenuItem3.Name = "chứcVụToolStripMenuItem3";
            this.chứcVụToolStripMenuItem3.Size = new System.Drawing.Size(130, 22);
            this.chứcVụToolStripMenuItem3.Text = "Chức vụ";
            this.chứcVụToolStripMenuItem3.Click += new System.EventHandler(this.chứcVụToolStripMenuItem3_Click);
            // 
            // mônHọcToolStripMenuItem
            // 
            this.mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            this.mônHọcToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.mônHọcToolStripMenuItem.Text = "Môn học";
            this.mônHọcToolStripMenuItem.Click += new System.EventHandler(this.mônHọcToolStripMenuItem_Click_1);
            // 
            // lớpHọcToolStripMenuItem
            // 
            this.lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            this.lớpHọcToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.lớpHọcToolStripMenuItem.Text = "Lớp học";
            this.lớpHọcToolStripMenuItem.Click += new System.EventHandler(this.lớpHọcToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 21);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.BackgroundImage = global::QLHSTH.Properties.Resources.phan_mem_quan_ly_diem_quan_ly_ket_qua_hoc_tap;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(739, 449);
            this.Controls.Add(this.Strip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Strip1.ResumeLayout(false);
            this.Strip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Strip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip2;
        private System.Windows.Forms.ToolStripMenuItem HT;
        private System.Windows.Forms.ToolStripMenuItem DN;
        private System.Windows.Forms.ToolStripMenuItem DX;
        private System.Windows.Forms.ToolStripMenuItem Thoat;
        private System.Windows.Forms.ToolStripMenuItem DM;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HS;
        private System.Windows.Forms.ToolStripMenuItem BC;
        private System.Windows.Forms.ToolStripMenuItem BCNV;
        private System.Windows.Forms.ToolStripMenuItem BCL;
        private System.Windows.Forms.ToolStripMenuItem QuanTri;
        private System.Windows.Forms.ToolStripMenuItem SaoLuu;
        private System.Windows.Forms.ToolStripMenuItem PhucHoi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GV;
        private System.Windows.Forms.ToolStripMenuItem báoCáoGiáoViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoMônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoLớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem NV;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpHọcToolStripMenuItem;
    }
}

