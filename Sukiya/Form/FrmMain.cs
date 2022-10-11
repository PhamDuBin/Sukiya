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
    public partial class FormMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FormMain()
        {

            InitializeComponent();
        }
        uc_NhanVien ucNhanVien;
        uc_Mon ucMon;
        uc_TrangChu ucTrangChu;
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
            lblTieuDe.Caption = ceQuanLiNhanVien.Text;
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
            lblTieuDe.Caption = ceDanhMucMon.Text;
        }

        private void ceBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void ceQuanLiKhoHang_Click(object sender, EventArgs e)
        {

        }

        private void ceTrangChu_Click(object sender, EventArgs e)
        {
            if (ucTrangChu == null)
            {
                ucTrangChu = new uc_TrangChu();
                ucTrangChu.Dock = DockStyle.Fill;
                TrangHienThiConterner.Controls.Add(ucTrangChu);
                ucTrangChu.BringToFront();
            }
            else
            {
                ucTrangChu.BringToFront();
            }
            lblTieuDe.Caption = ceTrangChu.Text;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (ucTrangChu == null)
            {
                ucTrangChu = new uc_TrangChu();
                ucTrangChu.Dock = DockStyle.Fill;
                TrangHienThiConterner.Controls.Add(ucTrangChu);
                ucTrangChu.BringToFront();
            }
            else
            {
                ucTrangChu.BringToFront();
            }
            lblTieuDe.Caption = ceTrangChu.Text;
        }
    }
}
