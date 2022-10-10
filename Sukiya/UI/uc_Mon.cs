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
    public partial class uc_Mon : UserControl
    {
        public uc_Mon()
        {
            InitializeComponent();
        }
        private void uc_Mon_Load(object sender, EventArgs e)
        {
            try
            {
                SukiyaContextDB context = new SukiyaContextDB();
                List<Mon> listMon = context.Mon.ToList();
                BindGrid(listMon);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
        private void BindGrid(List<Mon> listMon)
        {
            dgvMon.Rows.Clear();
            foreach(var item in listMon)
            {
                int index = dgvMon.Rows.Add();
                dgvMon.Rows[index].Cells[0].Value = item.MaMon;
                dgvMon.Rows[index].Cells[1].Value = item.MaLM;
                dgvMon.Rows[index].Cells[2].Value = item.TenMon;
                dgvMon.Rows[index].Cells[3].Value = item.Gia;
                dgvMon.Rows[index].Cells[4].Value = item.Size;
            }
        }

    }
}
