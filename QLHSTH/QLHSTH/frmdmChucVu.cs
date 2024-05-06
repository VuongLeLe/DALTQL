﻿using BUS;
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
    public partial class frmdmChucVu : Form
    {
        public frmdmChucVu()
        {
            InitializeComponent();
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            List<ChucVu_DTO> lstChucVu = ChucVu_BUS.LayChucVu();
            dataGridView1.DataSource = lstChucVu;
        }


        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}