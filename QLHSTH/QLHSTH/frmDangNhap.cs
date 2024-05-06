using BUS;
using DTO;
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
    public partial class frmDangNhap : Form
    {
        
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTen.Clear();
            txtMatKhau.Clear();
            this.ActiveControl = txtTen;
            
        }

        

        private void ckbHien_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                ckbHien.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                ckbHien.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn muốn thoát chứ?", "Thông báo", MessageBoxButtons.OKCancel);
            this.Close();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnDN;

        }

        private void btnDN_Click(object sender, EventArgs e)
        {

        }
    }
}
