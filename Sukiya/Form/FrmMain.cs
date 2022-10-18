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
        uc_LienHe ucLienHe;
        uc_GioiThieu ucGioiThieu;
        uc_BangKiemHang ucBangKiemHang;
        uc_SanPhamLoss ucSanPhamLoss;
        uc_XemDoanhThu ucXemDoanhThu;
       
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

        private void ceLienHe_Click(object sender, EventArgs e)
        {
            if (ucLienHe == null)
            {
                ucLienHe = new uc_LienHe();
                ucLienHe.Dock = DockStyle.Fill;
                TrangHienThiConterner.Controls.Add(ucLienHe);
                ucLienHe.BringToFront();
            }
            else
            {
                ucLienHe.BringToFront();
            }
            lblTieuDe.Caption = "Liên Hệ";
        }

        private void ceGioiThieu_Click(object sender, EventArgs e)
        {
            if (ucGioiThieu == null)
            {
                ucGioiThieu = new uc_GioiThieu();
                ucGioiThieu.Dock = DockStyle.Fill;
                TrangHienThiConterner.Controls.Add(ucGioiThieu);
                ucGioiThieu.BringToFront();
            }
            else
            {
                ucGioiThieu.BringToFront();
            }
            lblTieuDe.Caption = "Giới Thiệu";
        }

        private void ceBangKiemHang_Click(object sender, EventArgs e)
        {
            if (ucBangKiemHang == null)
            {
                ucBangKiemHang = new uc_BangKiemHang();
                ucBangKiemHang.Dock = DockStyle.Fill;
                TrangHienThiConterner.Controls.Add(ucBangKiemHang);
                ucBangKiemHang.BringToFront();
            }
            else
            {
                ucBangKiemHang.BringToFront();
            }
            lblTieuDe.Caption ="Bảng Kiểm Hàng";
        }

        private void ceSPLoss_Click(object sender, EventArgs e)
        {
            if (ucSanPhamLoss == null)
            {
                ucSanPhamLoss = new uc_SanPhamLoss();
                ucSanPhamLoss.Dock = DockStyle.Fill;
                TrangHienThiConterner.Controls.Add(ucSanPhamLoss);
                ucSanPhamLoss.BringToFront();
            }
            else
            {
                ucSanPhamLoss.BringToFront();
            }
            lblTieuDe.Caption = "Nhập Hàng Loss";
        }

       

        private void ceXemDT_Click(object sender, EventArgs e)
        {
            if (ucXemDoanhThu == null)
            {
                ucXemDoanhThu = new uc_XemDoanhThu();
                ucXemDoanhThu.Dock = DockStyle.Fill;
                TrangHienThiConterner.Controls.Add(ucXemDoanhThu);
                ucXemDoanhThu.BringToFront();
            }
            else
            {
                ucXemDoanhThu.BringToFront();
            }
            lblTieuDe.Caption = "Xem Doanh Thu";
        }

        private void ceBaoCaoDT_Click(object sender, EventArgs e)
        {
            
        }
    }
}
