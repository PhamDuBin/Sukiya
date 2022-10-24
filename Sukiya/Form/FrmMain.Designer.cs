namespace Sukiya
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.lblTieuDe = new DevExpress.XtraBars.BarStaticItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.TrangHienThiConterner = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.ceTrangChu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ceDanhMucMon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ceQuanLiNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ceBaoCaoDoanhThu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ceBaoCaoDT = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ceXemDT = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ceQuanLiKhoHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ceBangKiemHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ceSPLoss = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ceLienHe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ceGioiThieu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ceDangXuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblTieuDe});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(4);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1359, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lblTieuDe);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Caption = "Nhóm_One";
            this.lblTieuDe.Id = 0;
            this.lblTieuDe.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lblTieuDe.Name = "lblTieuDe";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblTieuDe});
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // TrangHienThiConterner
            // 
            this.TrangHienThiConterner.Appearance.BackColor = System.Drawing.Color.White;
            this.TrangHienThiConterner.Appearance.Options.UseBackColor = true;
            this.TrangHienThiConterner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrangHienThiConterner.Font = new System.Drawing.Font("Lexend Deca", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TrangHienThiConterner.Location = new System.Drawing.Point(303, 39);
            this.TrangHienThiConterner.Margin = new System.Windows.Forms.Padding(4);
            this.TrangHienThiConterner.Name = "TrangHienThiConterner";
            this.TrangHienThiConterner.Size = new System.Drawing.Size(1056, 734);
            this.TrangHienThiConterner.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ceTrangChu,
            this.ceDanhMucMon,
            this.ceQuanLiNhanVien,
            this.ceBaoCaoDoanhThu,
            this.ceQuanLiKhoHang,
            this.ceLienHe,
            this.ceGioiThieu,
            this.ceDangXuat});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(303, 734);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // ceTrangChu
            // 
            this.ceTrangChu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ceTrangChu.ImageOptions.SvgImage")));
            this.ceTrangChu.Name = "ceTrangChu";
            this.ceTrangChu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ceTrangChu.Text = "Trang Chủ";
            this.ceTrangChu.Click += new System.EventHandler(this.ceTrangChu_Click);
            // 
            // ceDanhMucMon
            // 
            this.ceDanhMucMon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ceDanhMucMon.ImageOptions.SvgImage")));
            this.ceDanhMucMon.Name = "ceDanhMucMon";
            this.ceDanhMucMon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ceDanhMucMon.Text = "Quản Lý Thực Đơn";
            this.ceDanhMucMon.Click += new System.EventHandler(this.ceDanhMucMon_Click);
            // 
            // ceQuanLiNhanVien
            // 
            this.ceQuanLiNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ceQuanLiNhanVien.ImageOptions.SvgImage")));
            this.ceQuanLiNhanVien.Name = "ceQuanLiNhanVien";
            this.ceQuanLiNhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ceQuanLiNhanVien.Text = "Quản Lý Nhân Viên";
            this.ceQuanLiNhanVien.Click += new System.EventHandler(this.ceQuanLiNhanVien_Click);
            // 
            // ceBaoCaoDoanhThu
            // 
            this.ceBaoCaoDoanhThu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ceBaoCaoDT,
            this.ceXemDT});
            this.ceBaoCaoDoanhThu.Expanded = true;
            this.ceBaoCaoDoanhThu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ceBaoCaoDoanhThu.ImageOptions.SvgImage")));
            this.ceBaoCaoDoanhThu.Name = "ceBaoCaoDoanhThu";
            this.ceBaoCaoDoanhThu.Text = "Báo Cáo Doanh Thu";
            // 
            // ceBaoCaoDT
            // 
            this.ceBaoCaoDT.Name = "ceBaoCaoDT";
            this.ceBaoCaoDT.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ceBaoCaoDT.Text = "Báo Cáo Doanh Thu Ngày";
            this.ceBaoCaoDT.Click += new System.EventHandler(this.ceBaoCaoDT_Click);
            // 
            // ceXemDT
            // 
            this.ceXemDT.Name = "ceXemDT";
            this.ceXemDT.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ceXemDT.Text = "Quản Lý Hóa Đơn";
            this.ceXemDT.Click += new System.EventHandler(this.ceXemDT_Click);
            // 
            // ceQuanLiKhoHang
            // 
            this.ceQuanLiKhoHang.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ceBangKiemHang,
            this.ceSPLoss});
            this.ceQuanLiKhoHang.Expanded = true;
            this.ceQuanLiKhoHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ceQuanLiKhoHang.ImageOptions.SvgImage")));
            this.ceQuanLiKhoHang.Name = "ceQuanLiKhoHang";
            this.ceQuanLiKhoHang.Text = "Quản Lí Kho Hàng";
            // 
            // ceBangKiemHang
            // 
            this.ceBangKiemHang.Name = "ceBangKiemHang";
            this.ceBangKiemHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ceBangKiemHang.Text = "Bảng Kiểm Hàng";
            this.ceBangKiemHang.Click += new System.EventHandler(this.ceBangKiemHang_Click);
            // 
            // ceSPLoss
            // 
            this.ceSPLoss.Name = "ceSPLoss";
            this.ceSPLoss.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ceSPLoss.Text = "Sản Phẩm Loss";
            this.ceSPLoss.Click += new System.EventHandler(this.ceSPLoss_Click);
            // 
            // ceLienHe
            // 
            this.ceLienHe.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ceLienHe.ImageOptions.SvgImage")));
            this.ceLienHe.Name = "ceLienHe";
            this.ceLienHe.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ceLienHe.Text = "Liên Hệ";
            this.ceLienHe.Click += new System.EventHandler(this.ceLienHe_Click);
            // 
            // ceGioiThieu
            // 
            this.ceGioiThieu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ceGioiThieu.ImageOptions.SvgImage")));
            this.ceGioiThieu.Name = "ceGioiThieu";
            this.ceGioiThieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ceGioiThieu.Text = "Giới Thiệu";
            this.ceGioiThieu.Click += new System.EventHandler(this.ceGioiThieu_Click);
            // 
            // ceDangXuat
            // 
            this.ceDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ceDangXuat.ImageOptions.SvgImage")));
            this.ceDangXuat.Name = "ceDangXuat";
            this.ceDangXuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ceDangXuat.Text = "Thoát";
            this.ceDangXuat.Click += new System.EventHandler(this.ceDangXuat_Click);
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "Element4";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Element3";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Element2";
            // 
            // FormMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 773);
            this.ControlContainer = this.TrangHienThiConterner;
            this.Controls.Add(this.TrangHienThiConterner);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Font = new System.Drawing.Font("Lexend Deca", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FormMain.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Quản Lý Nhà Hàng Sukiya";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer TrangHienThiConterner;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ceQuanLiKhoHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ceBangKiemHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ceSPLoss;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ceLienHe;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ceGioiThieu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ceDangXuat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ceBaoCaoDoanhThu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ceBaoCaoDT;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ceXemDT;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ceTrangChu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ceDanhMucMon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ceQuanLiNhanVien;
        private DevExpress.XtraBars.BarStaticItem lblTieuDe;
    }
}

