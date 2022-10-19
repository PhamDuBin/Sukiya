using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Sukiya.Models;

namespace Sukiya.UI
{
    public partial class uc_XemDoanhThu : UserControl
    {
        SukiyaContextDB dbContext = new SukiyaContextDB();
        public uc_XemDoanhThu()
        {
            InitializeComponent();
        }

        private void uc_XemDoanhThu_Load(object sender, EventArgs e)
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
            txtTongTien.Text = txtMaHD.Text = txtMaNV1.Text = txtMaPGM.Text = txtNgayLap.Text = "";
            dgvHoaDon.Rows.Clear();
            foreach (var item in dbContext.HoaDon.ToList())
            {
                int index = dgvHoaDon.Rows.Add();
                dgvHoaDon.Rows[index].Cells[0].Value = item.MaHD;
                dgvHoaDon.Rows[index].Cells[1].Value = item.MaNV;
                dgvHoaDon.Rows[index].Cells[2].Value = item.MaPGM;
                dgvHoaDon.Rows[index].Cells[3].Value = item.NgayLap;
                dgvHoaDon.Rows[index].Cells[4].Value = item.TongTien;
            }
        }

        private void btnThemSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaHD.Text != "" && txtTongTien.Text != "" && txtMaNV1.Text != "" && txtMaPGM.Text != "" && txtNgayLap.Text != "")
                try
                {
                    string MaHD = txtMaHD.Text.Trim();
                    HoaDon HD = dbContext.HoaDon.Where
                        (x => x.MaHD.ToString() == txtMaHD.Text).FirstOrDefault();
                    if (HD == null)
                    {
                        HD = new HoaDon();
                        HD.MaHD = int.Parse(txtMaHD.Text);
                        dbContext.HoaDon.Add(HD);
                    }
                    HD.MaNV = int.Parse(txtMaNV1.Text);
                    HD.MaPGM = int.Parse(txtMaPGM.Text);
                    HD.NgayLap = DateTime.Parse(txtNgayLap.Text);
                    HD.TongTien = decimal.Parse(txtTongTien.Text);
                    dbContext.SaveChanges();
                    MessageBox.Show("Thêm/ Sửa OK!!");
                    BindGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message);
                }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvHoaDon.Rows[e.RowIndex];
            txtMaHD.Text = row.Cells[0].Value.ToString();
            txtMaNV1.Text = row.Cells[1].Value.ToString();
            txtMaPGM.Text = row.Cells[2].Value.ToString();
            txtNgayLap.Text = row.Cells[3].Value.ToString();
            txtTongTien.Text = row.Cells[4].Value.ToString();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaHD.Text != "" && txtTongTien.Text != "" && txtMaNV1.Text != "" && txtMaPGM.Text != "" && txtNgayLap.Text != "")
                try
                {
                    string MaHD = txtMaHD.Text.Trim();
                    HoaDon HD = dbContext.HoaDon.Where
                        (x => x.MaHD.ToString() == txtMaHD.Text).FirstOrDefault();
                    if (HD != null)
                    {
                        dbContext.HoaDon.Remove(HD);
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
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }
        private void BindGrid(List<HoaDon> listHoaDon)
        {
            dgvHoaDon.Rows.Clear();
            foreach (var item in listHoaDon)
            {
                int index = dgvHoaDon.Rows.Add();
                dgvHoaDon.Rows[index].Cells[0].Value = item.MaHD;
                dgvHoaDon.Rows[index].Cells[1].Value = item.MaNV;
                dgvHoaDon.Rows[index].Cells[2].Value = item.MaPGM;
                dgvHoaDon.Rows[index].Cells[3].Value = item.NgayLap;
                dgvHoaDon.Rows[index].Cells[4].Value = item.TongTien;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string search = txtTimKiem.Text.Trim();
            List<HoaDon> listSeach = new List<HoaDon>();
            foreach (var item in dbContext.HoaDon)
            {
                if (item.MaHD.ToString().Contains(search.ToLower()) || item.MaNV.ToString().Contains(search.ToLower()) || item.MaPGM.ToString().Contains(search)
                    || item.NgayLap.ToString().Contains(search.ToLower()) || item.TongTien.ToString().Contains(search.ToLower()))
                {
                    listSeach.Add(item);
                }
            }
            BindGrid(listSeach);
        }
    }
}
