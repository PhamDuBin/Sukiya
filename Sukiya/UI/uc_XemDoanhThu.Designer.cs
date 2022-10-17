namespace Sukiya.UI
{
    partial class uc_XemDoanhThu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colMaHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaPGM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.hoaDonBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(877, 465);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHD,
            this.colMaNV,
            this.colMaPGM,
            this.colNgayLap,
            this.colTongTien});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataSource = typeof(Sukiya.Models.HoaDon);
            // 
            // colMaHD
            // 
            this.colMaHD.FieldName = "MaHD";
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.Visible = true;
            this.colMaHD.VisibleIndex = 0;
            // 
            // colMaNV
            // 
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 1;
            // 
            // colMaPGM
            // 
            this.colMaPGM.FieldName = "MaPGM";
            this.colMaPGM.Name = "colMaPGM";
            this.colMaPGM.Visible = true;
            this.colMaPGM.VisibleIndex = 2;
            // 
            // colNgayLap
            // 
            this.colNgayLap.FieldName = "NgayLap";
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.Visible = true;
            this.colNgayLap.VisibleIndex = 3;
            // 
            // colTongTien
            // 
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 4;
            // 
            // uc_XemDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "uc_XemDoanhThu";
            this.Size = new System.Drawing.Size(877, 465);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHD;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPGM;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
    }
}
