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
    public partial class uc_SanPhamLoss : UserControl
    {
        SukiyaContextDB dbContext = new SukiyaContextDB();
        public uc_SanPhamLoss()
        {
            
        }

        private void uc_SanPhamLoss_Load(object sender, EventArgs e)
        {
            try
            {
                SukiyaContextDB context = new SukiyaContextDB();
                List<NguyenVatLieu> listNVL = context.NguyenVatLieu.ToList();
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

            } 
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
    }
}
