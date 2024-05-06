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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            List<MonHoc_DTO> lstMonHoc = MonHoc_BUS.LayMonHoc();
            dtMH.DataSource = lstMonHoc;
            HienThiDSMonHocLenDatagrid();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HienThiDSMonHocLenDatagrid()
        {
            List<MonHoc_DTO> lstMonHoc = MonHoc_BUS.LayMonHoc();
            dtMH.DataSource = lstMonHoc;
            dtMH.Columns["SMaMH"].HeaderText = "Mã môn học";
            dtMH.Columns["STenMH"].HeaderText = "Tên môn học";
            dtMH.Columns["SMaMH"].Width = 120;
            dtMH.Columns["STenMH"].Width = 120;

        }
    }
}
