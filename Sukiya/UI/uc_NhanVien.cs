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
    public partial class uc_NhanVien : UserControl
    {
        SukiyaContextDB dbContext = new SukiyaContextDB();
        public uc_NhanVien()
        {
            InitializeComponent();
        }
        private void uc_NhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                SukiyaContextDB context = new SukiyaContextDB();
                List<NhanVien> listNhanVien = context.NhanVien.ToList();
                BindGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid()
        {
            dgvNhanVien.Rows.Clear();
            foreach(var item in dbContext.NhanVien.ToList())
            {
                int index = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[index].Cells[0].Value = item.MaNV;
                dgvNhanVien.Rows[index].Cells[1].Value = item.MaCV;
                dgvNhanVien.Rows[index].Cells[2].Value = item.HoTen;
                dgvNhanVien.Rows[index].Cells[3].Value = item.GioiTinh;
                dgvNhanVien.Rows[index].Cells[4].Value = item.SDT;
                dgvNhanVien.Rows[index].Cells[5].Value = item.DiaChi;
                dgvNhanVien.Rows[index].Cells[6].Value = item.SoCCCD;
            }
        }

        private void btnThemSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string MaNV = txtMaNV.Text.Trim();
                NhanVien nhanvien = dbContext.NhanVien.Where
                    (x => x.MaNV.ToString() == txtMaNV.Text).FirstOrDefault();
                if (nhanvien == null)
                {
                    nhanvien = new NhanVien();
                    nhanvien.MaNV = int.Parse(txtMaNV.Text);
                    dbContext.NhanVien.Add(nhanvien);
                }
                nhanvien.MaCV = int.Parse(txtMaChucVu.Text);
                nhanvien.HoTen = txtHoTen.Text;
                nhanvien.GioiTinh = txtGioiTinh.Text;
                nhanvien.DiaChi = txtDiaChi.Text;
                nhanvien.SoCCCD = txtSoCCCD.Text;

                dbContext.SaveChanges();
                MessageBox.Show("Thêm/ Sửa OK!!");
                BindGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string MaNV = txtMaNV.Text.Trim();
                NhanVien nhanvien = dbContext.NhanVien.Where
                    (x => x.MaNV.ToString() == txtMaNV.Text).FirstOrDefault();
                if(nhanvien != null)
                {
                    dbContext.NhanVien.Remove(nhanvien);
                }
                dbContext.SaveChanges();
                MessageBox.Show("Xóa OK!!");
                BindGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private int GetSelectedRow(string MaNV)
        {
            for (int i = 0; i < dgvNhanVien.Rows.Count; i++)
            {
                if (dgvNhanVien.Rows[i].Cells[0].Value.ToString() == MaNV)
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgvNhanVien.Rows[selectedRow].Cells[0].Value = txtMaNV.Text;
            dgvNhanVien.Rows[selectedRow].Cells[1].Value = txtMaChucVu.Text;
            dgvNhanVien.Rows[selectedRow].Cells[2].Value = txtHoTen.Text;
            dgvNhanVien.Rows[selectedRow].Cells[3].Value = txtGioiTinh.Text;
            dgvNhanVien.Rows[selectedRow].Cells[4].Value = txtSDT.Text;
            dgvNhanVien.Rows[selectedRow].Cells[5].Value = txtDiaChi.Text;
            dgvNhanVien.Rows[selectedRow].Cells[6].Value = txtSoCCCD.Text;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvNhanVien.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtMaChucVu.Text = row.Cells[1].Value.ToString();
            txtHoTen.Text = row.Cells[2].Value.ToString();
            txtGioiTinh.Text = row.Cells[3].Value.ToString();
            txtSDT.Text = row.Cells[4].Value.ToString();
            txtDiaChi.Text = row.Cells[5].Value.ToString();
            txtSoCCCD.Text = row.Cells[6].Value.ToString();
        }
    }
}
