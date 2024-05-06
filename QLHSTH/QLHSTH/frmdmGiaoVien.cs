using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLHSTH
{
    public partial class frmdmGiaoVien : Form
    {
        public frmdmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            txtMS.Enabled = false;
            List<GiaoVien_DTO> lstGiaoVien = GiaoVien_BUS.LayGiaoVien();
            dataGridView2.DataSource = lstGiaoVien;
            HienThiChucVuLenCombobox();
            HienThiMonHocLenCombobox();
            HienThiDSGiaoVienLenDatagrid();
        }

        

        private void dataGridView2_Click(object sender, EventArgs e)
        {

            DataGridViewRow r = new DataGridViewRow();
            r = dataGridView2.SelectedRows[0];
            txtMS.Text = r.Cells["SMaGV"].Value.ToString();
            txtHo.Text = r.Cells["SHoLot"].Value.ToString();
            txtTen.Text = r.Cells["STenGV"].Value.ToString();
            if (r.Cells["SPhai"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            txtSDT.Text = r.Cells["SSDT"].Value.ToString();
            dtpNS.Text = r.Cells["DTNamSinh"].Value.ToString();
            cbCV.SelectedValue = r.Cells["SMaCV"].Value;
            cbMH.SelectedValue = r.Cells["SMaMH"].Value;
        }

        private void HienThiChucVuLenCombobox()
        {
            List<ChucVu_DTO> lstChucVu = ChucVu_BUS.LayChucVu();
            cbCV.DataSource = lstChucVu;
            cbCV.DisplayMember = "STenCV";
            cbCV.ValueMember = "SMaCV";
        }

        private void HienThiMonHocLenCombobox()
        {
            List<MonHoc_DTO> lstMonHoc = MonHoc_BUS.LayMonHoc();
            cbMH.DataSource = lstMonHoc;
            cbMH.DisplayMember = "STenMH";
            cbMH.ValueMember = "SMaMH";
        }

        private void HienThiDSGiaoVienLenDatagrid()
        {
            List<GiaoVien_DTO> lstGiaoVien = GiaoVien_BUS.LayGiaoVien();
            dataGridView2.DataSource = lstGiaoVien;
            dataGridView2.Columns["SMaGV"].HeaderText = "Mã số";
            dataGridView2.Columns["SHoLot"].HeaderText = "Họ lót";
            dataGridView2.Columns["STenGV"].HeaderText = "Tên";
            dataGridView2.Columns["SPhai"].HeaderText = "Phái";
            dataGridView2.Columns["SSDT"].HeaderText = "Số điện thoại";
            dataGridView2.Columns["DTNamSinh"].HeaderText = "Năm sinh";
            dataGridView2.Columns["SMaCV"].HeaderText = "Mã chức vụ";
            dataGridView2.Columns["SMaMH"].HeaderText = "Mã môn học";
            dataGridView2.Columns["SMaGV"].Width = 60;
            dataGridView2.Columns["SHoLot"].Width = 120;
            dataGridView2.Columns["STenGV"].Width = 120;
            dataGridView2.Columns["SPhai"].Width = 120;
            dataGridView2.Columns["SSDT"].Width = 120;
            dataGridView2.Columns["DTNamSinh"].Width = 120;
            dataGridView2.Columns["SMaCV"].Width = 60;
            dataGridView2.Columns["SMaMH"].Width = 60;
        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {           
              this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if ( txtHo.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            
            if (txtSDT.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại phải là 10 số!");
                return;
            }
            
            GiaoVien_DTO gv = new GiaoVien_DTO();

            gv.SHoLot = txtHo.Text;
            gv.STenGV = txtTen.Text;
            if (radNam.Checked == true)
            {
                gv.SPhai = "Nam";
            }
            else
            {
                gv.SPhai = "Nữ";
            }
            gv.SSDT = txtSDT.Text;
            gv.DTNamSinh = DateTime.Parse(dtpNS.Text);
            gv.SMaMH = cbMH.SelectedValue.ToString();
            gv.SMaCV = cbCV.SelectedValue.ToString();
            if (GiaoVien_BUS.ThemGiaoVien(gv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSGiaoVienLenDatagrid();
            MessageBox.Show("Đã thêm giáo viên.");
        }

        private void btnTimTen_Click(object sender, EventArgs e)
        {
            string ten = txtTimTen.Text;
            List<GiaoVien_DTO> lstnv = GiaoVien_BUS.TimGiaoVienTheoTen(ten);
            if (lstnv == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dataGridView2.DataSource = lstnv;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Kt ma co ton tai
            if (txtMS.Text == "" || GiaoVien_BUS.TimGiaoVienTheoMa(txtMS.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã giáo viên!");
                return;
            }
            GiaoVien_DTO gv = new GiaoVien_DTO();
            gv.SMaGV = txtMS.Text;
            gv.SHoLot = txtHo.Text;
            gv.STenGV = txtTen.Text;
            if (radNam.Checked == true)
            {
                gv.SPhai = "Nam";
            }
            else
            {
                gv.SPhai = "Nữ";
            }
            gv.SSDT = txtSDT.Text;
            gv.DTNamSinh = DateTime.Parse(dtpNS.Text);
            gv.SMaMH = cbMH.SelectedValue.ToString();
            gv.SMaCV = cbCV.SelectedValue.ToString();
            if(GiaoVien_BUS.SuaGiaoVien(gv) == true)
            {
                HienThiDSGiaoVienLenDatagrid();
                MessageBox.Show("Đã cập nhật thông tin giáo viên");
            }
            else
            {
                MessageBox.Show("Không cập nhật được.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Kt ma co ton tai
            if (txtMS.Text == "" || GiaoVien_BUS.TimGiaoVienTheoMa(txtMS.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã giáo viên!");
                return;
            }
            GiaoVien_DTO gv = new GiaoVien_DTO();
            gv.SMaGV = txtMS.Text;
            gv.SHoLot = txtHo.Text;
            gv.STenGV = txtTen.Text;
            if (radNam.Checked == true)
            {
                gv.SPhai = "Nam";
            }
            else
            {
                gv.SPhai = "Nữ";
            }
            gv.SSDT = txtSDT.Text;
            gv.DTNamSinh = DateTime.Parse(dtpNS.Text);
            gv.SMaMH = cbMH.SelectedValue.ToString();
            gv.SMaCV = cbCV.SelectedValue.ToString();
            if (GiaoVien_BUS.XoaGiaoVien(gv) == true)
            {
                HienThiDSGiaoVienLenDatagrid();
                MessageBox.Show("Đã xóa giáo viên");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
