using DevExpress.XtraEditors;
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
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FrmDangNhap()
        {
            InitializeComponent();
            
            txtMatKhau.PasswordChar = '*';

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            btnDangNhap.Enabled = !string.IsNullOrEmpty(txtTenDangNhap.Text)&&
                !string.IsNullOrEmpty(txtMatKhau.Text);
        }
        private void cbxHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = (cbxHienMatKhau.Checked) ? '\0' : '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string matkhau = "12345";
            string tendangnhap = "PhamDuBin";
            try
            {
                if(txtMatKhau.Text == matkhau && txtTenDangNhap.Text == tendangnhap)
                {
                    
                    FormMain frm = new FormMain();
                    frm.Show();
                    this.Close();
                    this.Hide();

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}