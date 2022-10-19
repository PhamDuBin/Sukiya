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

namespace Sukiya.UI
{
    public partial class uc_BangKiemHang : UserControl
    {
        SukiyaContextDB dbContext = new SukiyaContextDB();
        public uc_BangKiemHang()
        {
            InitializeComponent();
        }

        private void uc_BangKiemHang_Load(object sender, EventArgs e)
        {
            try
            {
                BindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid()
        {
            txtDVT.Text = txtGia.Text = txtMaNVL.Text = txtSoLuong.Text = txtTenNVL.Text = "";
            dgvBangKiemHang.Rows.Clear();
            foreach (var item in dbContext.NguyenVatLieu.ToList())
            {
                int index = dgvBangKiemHang.Rows.Add();

                dgvBangKiemHang.Rows[index].Cells[0].Value = item.MaNVL;
                dgvBangKiemHang.Rows[index].Cells[1].Value = item.TenNVL;
                dgvBangKiemHang.Rows[index].Cells[2].Value = item.DVT;
                dgvBangKiemHang.Rows[index].Cells[3].Value = item.Gia;
                dgvBangKiemHang.Rows[index].Cells[4].Value = item.SoLuong;
            }
        }

        private void btnThemSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtDVT.Text != "" && txtGia.Text != "" && txtMaNVL.Text != "" && txtSoLuong.Text != "" && txtTenNVL.Text != "")
                try
                {
                    string MaNVL = txtMaNVL.Text.Trim();

                NguyenVatLieu NVL = dbContext.NguyenVatLieu.Where
                    (x => x.MaNVL.ToString() == txtMaNVL.Text).FirstOrDefault();
                if (NVL == null)
                {
                    NVL = new NguyenVatLieu();
                    NVL.MaNVL = int.Parse(txtMaNVL.Text);
                    dbContext.NguyenVatLieu.Add(NVL);
                }
                NVL.TenNVL = txtTenNVL.Text;
                NVL.DVT = int.Parse(txtDVT.Text);
                NVL.Gia = decimal.Parse(txtGia.Text);
                NVL.SoLuong = int.Parse(txtSoLuong.Text);


                    dbContext.SaveChanges();
                    MessageBox.Show("Thêm/ Sửa OK!!");
                    BindGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message);
                }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ");
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtDVT.Text != "" && txtGia.Text != "" && txtMaNVL.Text != "" && txtSoLuong.Text != "" && txtTenNVL.Text != "")
                try
                {
                string MaNVL = txtMaNVL.Text.Trim();
                NguyenVatLieu NVL = dbContext.NguyenVatLieu.Where
                    (x => x.MaNVL.ToString() == txtMaNVL.Text).FirstOrDefault();
                if (NVL != null)
                {
                    dbContext.NguyenVatLieu.Remove(NVL);
                }
                dbContext.SaveChanges();
                MessageBox.Show("Xóa OK!!");
                BindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ");
        }

        private void dgvBangKiemHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvBangKiemHang.Rows[e.RowIndex];
            txtMaNVL.Text = row.Cells[0].Value.ToString();
            txtTenNVL.Text = row.Cells[1].Value.ToString();
            txtDVT.Text = row.Cells[2].Value.ToString();
            txtGia.Text = row.Cells[3].Value.ToString();
            txtSoLuong.Text = row.Cells[4].Value.ToString();
        }

        
    }
}
