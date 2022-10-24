using DevExpress.Office.Utils;
using DevExpress.XtraReports.UI;
using Sukiya.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace Sukiya.Reports
{
    public partial class DoanhThu : DevExpress.XtraReports.UI.XtraReport
    {
        public DoanhThu()
        {
            InitializeComponent();
        }

        public void InitData(List<HoaDon> data)
        {
            objectDataSource1.DataSource = data;
        }
    }
}
