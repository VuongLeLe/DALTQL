using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSTH
{
    public partial class frmdmHocSinh : Form
    {
        public frmdmHocSinh()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmdmHocSinh_Load(object sender, EventArgs e)
        {
            txtMHS.Enabled = false;
            List<HocSinh_DTO> lstHocSinh = HocSinh_BUS.LayHocSinh();
            dtDSHS.DataSource = lstHocSinh;
            HienThiLopHocLenCombobox();
            HienThiDSHocSinhLenDatagrid();
        }

        private void dtDSHS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtDSHS.SelectedRows[0];
            txtMHS.Text = r.Cells["SMaHS"].Value.ToString();
            txtHoHS.Text = r.Cells["SHoLotHS"].Value.ToString();
            txtTenHS.Text = r.Cells["STenHS"].Value.ToString();
            if (r.Cells["SPhaiHS"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            
            dtpNSHS.Text = r.Cells["DTNgaySinh"].Value.ToString();
            txtSDT.Text = r.Cells["SSDTHS"].Value.ToString();
            txtHP.Text = r.Cells["SHP"].Value.ToString();
            cbLop.SelectedValue = r.Cells["SMaLop"].Value;
        }

        private void HienThiLopHocLenCombobox()
        {
            List<LopHoc_DTO> lstLopHoc = LopHoc_BUS.LayLopHoc();
            cbLop.DataSource = lstLopHoc;
            cbLop.DisplayMember = "STenLop";
            cbLop.ValueMember = "SMaLop";
        }

        private void HienThiDSHocSinhLenDatagrid()
        {
            List<HocSinh_DTO> lstHocSinh = HocSinh_BUS.LayHocSinh();
            dtDSHS.DataSource = lstHocSinh;
            dtDSHS.Columns["SMaHS"].HeaderText = "Mã số HS";
            dtDSHS.Columns["SHoLotHS"].HeaderText = "Họ lót";
            dtDSHS.Columns["STenHS"].HeaderText = "Tên HS";
            dtDSHS.Columns["SPhaiHS"].HeaderText = "Phái";
            dtDSHS.Columns["DTNgaySinh"].HeaderText = "Ngày sinh";
            dtDSHS.Columns["SSDTHS"].HeaderText = "Số điện thoại";
            dtDSHS.Columns["SHP"].HeaderText = "Học phí";
            dtDSHS.Columns["SMaLop"].HeaderText = "Mã lớp";
            dtDSHS.Columns["SMaHS"].Width = 60;
            dtDSHS.Columns["SHoLotHS"].Width = 120;
            dtDSHS.Columns["STenHS"].Width = 60;
            dtDSHS.Columns["SSDTHS"].Width = 120;
            dtDSHS.Columns["SPhaiHS"].Width = 60;
            dtDSHS.Columns["DTNgaySinh"].Width = 120;
            dtDSHS.Columns["SMaLop"].Width = 60;
        }

        private void btnThoatHS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemHS_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if ( txtHoHS.Text == "" || txtTenHS.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            
            if (txtSDT.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại phải là 10 số!");
                return;
            }
            
            HocSinh_DTO hs = new HocSinh_DTO();
            hs.SHoLotHS = txtHoHS.Text;
            hs.STenHS = txtTenHS.Text;
            if (radNam.Checked == true)
            {
                hs.SPhaiHS = "Nam";
            }
            else
            {
                hs.SPhaiHS = "Nữ";
            }
            hs.DTNgaySinh = DateTime.Parse(dtpNSHS.Text);
            hs.SSDTHS = txtSDT.Text;
            hs.SHP = txtHP.Text;
            hs.SMaLop = cbLop.SelectedValue.ToString();
            if (HocSinh_BUS.ThemHocSinh(hs) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSHocSinhLenDatagrid();
            MessageBox.Show("Đã thêm học sinh.");
        }

        private void btnTimTenHS_Click(object sender, EventArgs e)
        {
            string ten = txtTimTenHS.Text;
            List<HocSinh_DTO> lstnv = HocSinh_BUS.TimHocSinhTheoTen(ten);
            if (lstnv == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dtDSHS.DataSource = lstnv;
        }

        private void btnSuaHS_Click(object sender, EventArgs e)
        {
            //Kt ma co ton tai
            if (txtMHS.Text == "" || HocSinh_BUS.TimHocSinhTheoMa(txtMHS.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã học sinh!");
                return;
            }
            HocSinh_DTO hs = new HocSinh_DTO();
            hs.SMaHS = txtMHS.Text;
            hs.SHoLotHS = txtHoHS.Text;
            hs.STenHS = txtTenHS.Text;
            if (radNam.Checked == true)
            {
                hs.SPhaiHS = "Nam";
            }
            else
            {
                hs.SPhaiHS = "Nữ";
            }
            hs.DTNgaySinh = DateTime.Parse(dtpNSHS.Text);
            hs.SSDTHS = txtSDT.Text;
            hs.SHP = txtHP.Text;
            hs.SMaLop = cbLop.SelectedValue.ToString();
            if (HocSinh_BUS.SuaHocSinh(hs) == true)
            {
                HienThiDSHocSinhLenDatagrid();
                MessageBox.Show("Đã cập nhật thông tin học sinh");
            }
            else
            {
                MessageBox.Show("Không cập nhật được.");
            }
        }

        private void btnXoaHS_Click(object sender, EventArgs e)
        {
            //Kt ma co ton tai
            if (txtMHS.Text == "" || HocSinh_BUS.TimHocSinhTheoMa(txtMHS.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã học sinh!");
                return;
            }
            HocSinh_DTO hs = new HocSinh_DTO();
            hs.SMaHS = txtMHS.Text;
            hs.SHoLotHS = txtHoHS.Text;
            hs.STenHS = txtTenHS.Text;
            if (radNam.Checked == true)
            {
                hs.SPhaiHS = "Nam";
            }
            else
            {
                hs.SPhaiHS = "Nữ";
            }
            hs.DTNgaySinh = DateTime.Parse(dtpNSHS.Text);
            hs.SSDTHS = txtSDT.Text;
            hs.SHP = txtHP.Text;
            hs.SMaLop = cbLop.SelectedValue.ToString();
            if (HocSinh_BUS.XoaHocSinh(hs) == true)
            {
                HienThiDSHocSinhLenDatagrid();
                MessageBox.Show("Đã xóa học sinh");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }
    }
}
