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
    public partial class frmDiem : Form
    {
        public frmDiem()
        {
            InitializeComponent();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            List<Diem_DTO> lstDiem = Diem_BUS.LayDiem();
            dtDiem.DataSource = lstDiem;
            HienThiMaHSLenCombobox();
            HienThiMonHocLenCombobox();
            HienThiDSDiemLenDatagrid();
        }



        private void dtDiem_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtDiem.SelectedRows[0];
            cbMHS.SelectedValue = r.Cells["SMaHS"].Value;
            cbMM.SelectedValue = r.Cells["SMaMH"].Value;
            txtDGK1.Text = r.Cells["SDiemGKI"].Value.ToString();
            txtDHK1.Text = r.Cells["SDiemHKI"].Value.ToString();
            txtDGK2.Text = r.Cells["SDiemGKII"].Value.ToString();
            txtDHK2.Text = r.Cells["SDiemHKII"].Value.ToString();
            txtDTB.Text = r.Cells["STBCN"].Value.ToString();

        }

        private void HienThiMaHSLenCombobox()
        {
            List<HocSinh_DTO> lstHocSinh = HocSinh_BUS.LayHocSinh();
            cbMHS.DataSource = lstHocSinh;
            cbMHS.DisplayMember = "StenHS";
            cbMHS.ValueMember = "SMaHS";
        }

        private void HienThiMonHocLenCombobox()
        {
            List<MonHoc_DTO> lstMonHoc = MonHoc_BUS.LayMonHoc();
            cbMM.DataSource = lstMonHoc;
            cbMM.DisplayMember = "STenMH";
            cbMM.ValueMember = "SMaMH";

        }

        private void HienThiDSDiemLenDatagrid()
        {
            List<Diem_DTO> lstDiem = Diem_BUS.LayDiem();
            dtDiem.DataSource = lstDiem;
            dtDiem.Columns["SMaHS"].HeaderText = "Mã học sinh";
            dtDiem.Columns["SMaMH"].HeaderText = "Mã môn học";
            dtDiem.Columns["SDiemGKI"].HeaderText = "Điểm giữa kỳ 1";
            dtDiem.Columns["SDiemHKI"].HeaderText = "Điểm học kỳ 1";
            dtDiem.Columns["SDiemGKII"].HeaderText = "Điểm giữa kỳ 2";
            dtDiem.Columns["SDiemHKII"].HeaderText = "Điểm giữa kỳ 2";
            dtDiem.Columns["STBCN"].HeaderText = "Điểm trung bình cả năm";
            dtDiem.Columns["SMaHS"].Width = 56;
            dtDiem.Columns["SMaMH"].Width = 56;
            dtDiem.Columns["SDiemGKI"].Width = 127;
            dtDiem.Columns["SDiemHKI"].Width = 127;
            dtDiem.Columns["SDiemGKII"].Width = 127;
            dtDiem.Columns["SDiemHKII"].Width = 127;
            dtDiem.Columns["STBCN"].Width = 127;

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtDGK1.Text == "" || txtDHK1.Text == "" || txtDGK2.Text == "" || txtDHK2.Text == "" || txtDTB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
           
            Diem_DTO d = new Diem_DTO();
            d.SMaHS = cbMHS.SelectedValue.ToString();
            d.SMaMH = cbMM.SelectedValue.ToString();
            d.SDiemGKI = float.Parse(txtDGK1.Text);
            d.SDiemHKI = float.Parse(txtDHK1.Text);
            d.SDiemGKII = float.Parse(txtDGK2.Text);
            d.SDiemHKII = float.Parse(txtDHK2.Text);
            d.STBCN = float.Parse(txtDTB.Text);
            if (Diem_BUS.ThemDiem(d) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSDiemLenDatagrid();
            MessageBox.Show("Đã thêm điểm cho học sinh.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            Diem_DTO d = new Diem_DTO();
            d.SMaHS = cbMHS.SelectedValue.ToString();
            d.SMaMH = cbMM.SelectedValue.ToString();
            d.SDiemGKI = float.Parse(txtDGK1.Text);
            d.SDiemHKI = float.Parse(txtDHK1.Text);
            d.SDiemGKII = float.Parse(txtDGK2.Text);
            d.SDiemHKII = float.Parse(txtDHK2.Text);
            d.STBCN = float.Parse(txtDTB.Text);

            if (Diem_BUS.SuaDiem(d) == true)
            {
                HienThiDSDiemLenDatagrid();
                MessageBox.Show("Đã cập nhật thông tin điểm");
            }
            else
            {
                MessageBox.Show("Không cập nhật được.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            Diem_DTO d = new Diem_DTO();
            d.SMaHS = cbMHS.SelectedValue.ToString();
            d.SMaMH = cbMM.SelectedValue.ToString();
            d.SDiemGKI = float.Parse(txtDGK1.Text);
            d.SDiemHKI = float.Parse(txtDHK1.Text);
            d.SDiemGKII = float.Parse(txtDGK2.Text);
            d.SDiemHKII = float.Parse(txtDHK2.Text);
            d.STBCN = float.Parse(txtDTB.Text);
            if (Diem_BUS.XoaDiem(d) == true)
            {
                HienThiDSDiemLenDatagrid();
                MessageBox.Show("Đã xóa điểm");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void txtDTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
