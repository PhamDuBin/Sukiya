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
                BindGrid(listNhanVien);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<NhanVien> listNhanVien)
        {
            dgvNhanVien.Rows.Clear();
            foreach(var item in listNhanVien)
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
    }
}
