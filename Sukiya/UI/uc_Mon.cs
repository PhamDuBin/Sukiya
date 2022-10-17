using Sukiya.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sukiya.UI
{
    public partial class uc_Mon : UserControl
    {
        SukiyaContextDB dbContext = new SukiyaContextDB();
        public uc_Mon()
        {
            InitializeComponent();
        }
        private void uc_Mon_Load(object sender, EventArgs e)
        {
            try
            {
                SukiyaContextDB context = new SukiyaContextDB();
              //  List<Mon> listMon = context.Mon.ToList();
              //  List<CT_Mon> listCTMon = context.CT_Mon.ToList();
                
                
                BindGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
        private void BindGrid()
        {
            dgvMon.Rows.Clear();
            
            foreach (var item in dbContext.Mon.ToList())
            {
                int index = dgvMon.Rows.Add();

                dgvMon.Rows[index].Cells[0].Value = item.MaMon;
                dgvMon.Rows[index].Cells[1].Value = item.MaLM;
                dgvMon.Rows[index].Cells[2].Value = item.TenMon;
                dgvMon.Rows[index].Cells[3].Value = item.Gia;
                dgvMon.Rows[index].Cells[4].Value = item.Size;
                
            }
           
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string MaMon = txtMaMon.Text.Trim();
                
                Mon mon = dbContext.Mon.Where
                    (x => x.MaMon.ToString() == txtMaMon.Text).FirstOrDefault();
                if (mon == null)
                {
                    mon = new Mon();
                    mon.MaMon = int.Parse(txtMaMon.Text);
                    dbContext.Mon.Add(mon);
                }
                mon.MaLM = int.Parse(txtMaLoaiMon.Text);
                mon.TenMon = txtTenMon.Text;
                mon.Gia = decimal.Parse( txtGia.Text);
                mon.Size = txtKichThuoc.Text;
                

                dbContext.SaveChanges();
                MessageBox.Show("Thêm/ Sửa OK!!");
                BindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string Mon = txtMaMon.Text.Trim();
                Mon mon = dbContext.Mon.Where
                    (x => x.MaMon.ToString() == txtMaMon.Text).FirstOrDefault();
                if (mon != null)
                {
                    dbContext.Mon.Remove(mon);
                }
                dbContext.SaveChanges();
                MessageBox.Show("Xóa OK!!");
                BindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private int GetSelectedRow(string MaMon)
        {
            for (int i = 0; i <dgvMon.Rows.Count; i++)
            {
                if (dgvMon.Rows[i].Cells[0].Value.ToString() == MaMon)
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgvMon.Rows[selectedRow].Cells[0].Value = txtMaMon.Text;
            dgvMon.Rows[selectedRow].Cells[1].Value = txtMaLoaiMon.Text;
            dgvMon.Rows[selectedRow].Cells[2].Value = txtTenMon.Text;
            dgvMon.Rows[selectedRow].Cells[3].Value = txtGia.Text;
            dgvMon.Rows[selectedRow].Cells[4].Value = txtKichThuoc.Text;
        }
        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvMon.Rows[e.RowIndex];
            txtMaMon.Text = row.Cells[0].Value.ToString();
            txtMaLoaiMon.Text = row.Cells[1].Value.ToString();
            txtTenMon.Text = row.Cells[2].Value.ToString();
            txtGia.Text = row.Cells[3].Value.ToString();
            txtKichThuoc.Text = row.Cells[4].Value.ToString();
        }
    }
}
