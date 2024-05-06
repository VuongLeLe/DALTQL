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
    public partial class frmLopHoc : Form
    {
        public frmLopHoc()
        {
            InitializeComponent();
        }

        

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            txtML.Enabled = false;
            List<LopHoc_DTO> lstLopHoc = LopHoc_BUS.LayLopHoc();
            dtLopHoc.DataSource = lstLopHoc;
            HienThiMaGiaoVienLenCombobox();
            HienThiDSLopHocLenDatagrid();
            
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtLopHoc_Click(object sender, EventArgs e)
        {
                DataGridViewRow r = new DataGridViewRow();
                r = dtLopHoc.SelectedRows[0];
                txtML.Text = r.Cells["SMaLop"].Value.ToString();
                txtTL.Text = r.Cells["STenLop"].Value.ToString();
                cbMGV.SelectedValue = r.Cells["SMaGV"].Value;           
        }

        private void HienThiMaGiaoVienLenCombobox()
        {
            List<GiaoVien_DTO> lstGiaoVien = GiaoVien_BUS.LayGiaoVien();
            cbMGV.DataSource = lstGiaoVien;
            cbMGV.DisplayMember = "STenGV";
            cbMGV.ValueMember = "SMaGV";
        }

        private void HienThiDSLopHocLenDatagrid()
        {
            List<LopHoc_DTO> lstLopHoc = LopHoc_BUS.LayLopHoc();
            dtLopHoc.DataSource = lstLopHoc;
            dtLopHoc.Columns["SMaLop"].HeaderText = "Mã Lớp";
            
            dtLopHoc.Columns["STenLop"].HeaderText = "Tên lớp";           
            dtLopHoc.Columns["SMaGV"].HeaderText = "Mã giáo viên";
            dtLopHoc.Columns["SMaLop"].Width = 60;
            dtLopHoc.Columns["STenLop"].Width = 120;

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if ( txtTL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            
            
            
            LopHoc_DTO lh = new LopHoc_DTO();
            lh.SMaLop = txtML.Text;
            lh.STenLop = txtTL.Text;
            lh.SMaGV = cbMGV.SelectedValue.ToString();
            
            if (LopHoc_BUS.ThemLopHoc(lh) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSLopHocLenDatagrid();
            MessageBox.Show("Đã thêm lớp.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Kt ma co ton tai
            if (txtML.Text == "" || LopHoc_BUS.TimLopHocTheoMa(txtML.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã lớp!");
                return;
            }
            LopHoc_DTO lh = new LopHoc_DTO();
            lh.SMaLop = txtML.Text;
            lh.STenLop = txtTL.Text;
            lh.SMaGV = cbMGV.SelectedValue.ToString();
            if (LopHoc_BUS.SuaLopHoc(lh) == true)
            {
                HienThiDSLopHocLenDatagrid();
                MessageBox.Show("Đã cập nhật thông tin lớp");
            }
            else
            {
                MessageBox.Show("Không cập nhật được.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Kt ma co ton tai
            if (txtML.Text == "" || LopHoc_BUS.TimLopHocTheoMa(txtML.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã lớp!");
                return;
            }
            LopHoc_DTO lh = new LopHoc_DTO();
            lh.SMaLop = txtML.Text;
            lh.STenLop = txtTL.Text;
            lh.SMaGV = cbMGV.SelectedValue.ToString();
            if (LopHoc_BUS.XoaLopHoc(lh) == true)
            {
                HienThiDSLopHocLenDatagrid();
                MessageBox.Show("Đã xóa lớp");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }


    }
}
