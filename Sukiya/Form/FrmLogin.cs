using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.Data.WcfLinq.Helpers;
using DevExpress.XtraEditors;
using Sukiya.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sukiya.Form
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        SukiyaContextDB context = new SukiyaContextDB();
        public FrmLogin()
        {
            InitializeComponent();
            btnDangNhap.Enabled = false;
            txtMatKhau.PasswordChar = '*';
        }
        private bool kiemTraDangNhap(string tenDangNhap, string matKhau)
        {

            try
            {
                NhanVien nhanvien = context.NhanVien.Where(x => x.SDT.ToString() == tenDangNhap).FirstOrDefault();
                if (nhanvien != null)
                {
                    return BCrypt.Net.BCrypt.Verify(matKhau, nhanvien.MatKhau);
                }
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return false;
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            btnDangNhap.Enabled = !string.IsNullOrEmpty(txtMatKhau.Text);
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            btnDangNhap.Enabled = !string.IsNullOrEmpty(txtTenDangNhap.Text);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //string matKhauMaHoa = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);
            if (string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ trước khi đăng nhập");
            }
            else
            {
                try
                {
                    if (kiemTraDangNhap(txtTenDangNhap.Text, txtMatKhau.Text) == true)
                    {
                        FormMain frm = new FormMain();
                        frm.Show();
                        frm.FormClosed += Frm_FormClosed;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu, vui lòng nhập lại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = (chkHienMatKhau.Checked) ? '\0' : '*';
        }
    }
}