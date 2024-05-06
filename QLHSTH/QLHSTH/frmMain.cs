using DTO;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSTH
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public bool bDangNhap;
        frmDangNhap fDN;
        frmdmChucVu frmcv;
        frmdmGiaoVien frmgv;
        frmdmHocSinh frmhs;
        frmLopHoc frmlh;
        frmMonHoc frmmh;
        frmDiem frmD;

        public static NguoiDung_DTO NguoiDung;


        private void frmMain_Load(object sender, EventArgs e)
        {
            HienThiMenu();
            

            
        }

        private void HienThiMenu()
        {
            DN.Enabled = !bDangNhap;
            DX.Enabled = bDangNhap;
            DM.Enabled = bDangNhap;
            BC.Enabled = bDangNhap;
            NV.Enabled = bDangNhap;

            if (bDangNhap == true)
            {
                toolStrip1.Text = "Người dùng: " + NguoiDung.STen;
                toolStrip2.Text = "Thời điểm đăng nhập: " + DateTime.Now;
                // Hiển thị menu theo quyền, ví dụ:
                // 1. hieutruong: sử dụng tất cả menu
                // 2. giaovien: không sử dụng các menu: Danh mục, Nghiệp vụ
                int iQuyen;
                if (NguoiDung == null)
                {
                    iQuyen = 0;
                }
                else
                {
                    iQuyen = int.Parse(NguoiDung.IQuyen.ToString());
                }
                switch (iQuyen)
                {
                    case 1:
                        DM.Enabled = true;
                        break;
                    case 2:
                        DM.Enabled = true;
                            HS.Enabled = false;
                            GV.Enabled = false;
                        NV.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                toolStrip1.Text = "Chưa đăng nhập";
                toolStrip2.Text = "";
                DM.Enabled = false;
            }
        }

        private void DN_Click(object sender, EventArgs e)
        {
            fDN = new frmDangNhap();
            if (fDN.ShowDialog() == DialogResult.OK)
            {
                string sTen = fDN.txtTen.Text;
                string sMatKhau = fDN.txtMatKhau.Text;

                NguoiDung = new NguoiDung_DTO();
                NguoiDung = NguoiDung_BUS.LayNguoiDung(sTen, sMatKhau);
                if (NguoiDung != null)
                {
                    bDangNhap = true;
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                    bDangNhap = false;
                }
                HienThiMenu();
            }
        }

        private void DX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Xac nhan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // Đóng tất cả form đang mở
                foreach (Form f in this.MdiChildren)
                {
                    if (!f.IsDisposed)
                        f.Close();
                    

                }
                // Đăng xuất và thiết lập lại menu
                bDangNhap = false;
                
                HienThiMenu();
                if (fDN.ShowDialog() == DialogResult.OK)
                {
                    string sTen = fDN.txtTen.Text;
                    string sMatKhau = fDN.txtMatKhau.Text;

                    NguoiDung = new NguoiDung_DTO();
                    NguoiDung = NguoiDung_BUS.LayNguoiDung(sTen, sMatKhau);
                    if (NguoiDung != null)
                    {
                        bDangNhap = true;
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                        bDangNhap = false;
                    }
                    HienThiMenu();
                }

            }
            return;
        }

        

        private void Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoat?", "Xac nhan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
            return;
        }

       

        

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmgv == null || frmgv.IsDisposed)
            {
                frmgv = new frmdmGiaoVien();

                frmgv.Show();

            }
        }

        private void nhanViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmhs == null || frmhs.IsDisposed)
            {
                frmhs = new frmdmHocSinh();

                frmhs.Show();

            }
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmlh == null || frmlh.IsDisposed)
            {
                frmlh = new frmLopHoc();
                frmlh.Show();


            }
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmmh == null || frmmh.IsDisposed)
            {
                frmmh = new frmMonHoc();
                frmmh.Show();


            }
        }

        
        private void SaoLuu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
            saoluuFolder.Description = "Chọn thư mục lưu trữ";
            if (saoluuFolder.ShowDialog() == DialogResult.OK)
            {
                string sDuongDan = saoluuFolder.SelectedPath;
                if (CSDL_BUS.SaoLuu(sDuongDan) == true)
                    MessageBox.Show("Đã sao lưu dữ liệu vào" + sDuongDan);
                else
                    MessageBox.Show("Thao tác không thành công!");
            }
        }

        private void PhucHoi_Click(object sender, EventArgs e)
        {
            OpenFileDialog phuchoiFile = new OpenFileDialog();
            phuchoiFile.Filter = "*.bak|*.bak"; phuchoiFile.Title = "Chọn tập tin cần phục hồi(.bak)";
            if (phuchoiFile.ShowDialog() == DialogResult.OK && phuchoiFile.CheckFileExists == true)
            {
                string sDuongDan = phuchoiFile.FileName;
                if (CSDL_BUS.PhucHoi(sDuongDan) == true)
                    MessageBox.Show("Phục hồi thành công");
                else
                    MessageBox.Show("Phục hồi thất bại");
            }
        }

        private void chứcVụToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (frmcv == null || frmcv.IsDisposed)
            {
                frmcv = new frmdmChucVu();
                frmcv.Show();


            }
        }

        private void mônHọcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (frmmh == null || frmmh.IsDisposed)
            {
                frmmh = new frmMonHoc();
                frmmh.Show();


            }
        }

        private void lớpHọcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (frmlh == null || frmlh.IsDisposed)
            {
                frmlh = new frmLopHoc();
                frmlh.Show();


            }
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmD == null || frmD.IsDisposed)
            {
                frmD = new frmDiem();
                frmD.Show();


            }
        }
    }
}
