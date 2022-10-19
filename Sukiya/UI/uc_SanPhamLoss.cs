using DevExpress.Pdf.Drawing;
using Sukiya.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.Office.Utils;
using System.Data.Entity.Infrastructure.Interception;

namespace Sukiya.UI
{
    public partial class uc_SanPhamLoss : UserControl
    {
        SukiyaContextDB dbContext = new SukiyaContextDB();
        public uc_SanPhamLoss()
        {
            InitializeComponent();
        }

        private void uc_SanPhamLoss_Load(object sender, EventArgs e)
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
            dgvSanPhamLOSS.Rows.Clear();
            foreach (var item in dbContext.NguyenVatLieu.ToList())
            {
                int index = dgvSanPhamLOSS.Rows.Add();
                dgvSanPhamLOSS.Rows[index].Cells[0].Value = item.MaNVL;
                dgvSanPhamLOSS.Rows[index].Cells[1].Value = item.TenNVL;
                dgvSanPhamLOSS.Rows[index].Cells[2].Value = item.LuongLoss;
                dgvSanPhamLOSS.Rows[index].Cells[3].Value = item.LiDo;

            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string MaNVL = txtMaNVL.Text.Trim();

                NguyenVatLieu NVL = dbContext.NguyenVatLieu.Where
                    (x => x.MaNVL.ToString() == txtMaNVL.Text).FirstOrDefault();

                NVL.LuongLoss = float.Parse(txtLuongLoss.Text);
                NVL.LiDo = int.Parse(txtLiDo.Text);


                dbContext.SaveChanges();
                MessageBox.Show("Sửa OK!!");
                BindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }

        private void dgvSanPhamLOSS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvSanPhamLOSS.Rows[e.RowIndex];
            txtMaNVL.Text = row.Cells[0].Value.ToString();
            txtTenNVL.Text = row.Cells[1].Value.ToString();
            txtLuongLoss.Text = row.Cells[2].Value.ToString();
            txtLiDo.Text = row.Cells[3].Value.ToString();
        }
    }
}
