using DevExpress.Utils.Extensions;
using DevExpress.XtraCharts;
using Sukiya.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sukiya.UI
{
    public partial class uc_BaoCaoDoanhThu : UserControl
    {
        public uc_BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void uc_BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            SukiyaContextDB dbContext = new SukiyaContextDB();
            List<HoaDon> listHoaDon = new List<HoaDon>();
            chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "VNĐ (ngàn đồng)";
            foreach (var item in dbContext.HoaDon)
            {
                HoaDon hoaDon = dbContext.HoaDon.Where(x => x.NgayLap == item.NgayLap).FirstOrDefault();
                listHoaDon.Add(hoaDon);
            }
            foreach (var item in listHoaDon)
            {
                int dem = 0;
                foreach (var item2 in dbContext.HoaDon)
                {
                    if (item.NgayLap == item2.NgayLap)
                    {
                        dem++;
                        if (dem > 1)
                            item.TongTien += item2.TongTien;
                    }
                }
                chartDoanhThu.Series["ChartDT"].Points.AddXY(item.NgayLap, item.TongTien);
            }
        }
    }
}
