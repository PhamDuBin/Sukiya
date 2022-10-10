using DevExpress.XtraBars;
using Sukiya.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sukiya
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {

            InitializeComponent();
        }
        uc_NhanVien ucNhanVien;
        uc_Mon ucMon;
        private void ceDangXuat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ceQuanLiNhanVien_Click(object sender, EventArgs e)
        {
            if(ucNhanVien == null)
            {
                ucNhanVien = new uc_NhanVien();
                ucNhanVien.Dock = DockStyle.Fill;
                TrangHienThiConterner.Controls.Add(ucNhanVien);
                ucNhanVien.BringToFront();
            }
            else
            {
                ucNhanVien.BringToFront();
            }
        }

        private void ceDanhMucMon_Click(object sender, EventArgs e)
        {
            if(ucMon == null)
            {
                ucMon = new uc_Mon();
                ucMon.Dock = DockStyle.Fill;
                TrangHienThiConterner.Controls.Add(ucMon);
                ucMon.BringToFront();
            }
            else
            {
                ucMon.BringToFront();
            }
        }
    }
}
