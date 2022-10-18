﻿namespace Sukiya.UI
{
    partial class uc_SanPhamLoss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_SanPhamLoss));
            this.dgvSanPhamLOSS = new System.Windows.Forms.DataGridView();
            this.MaNVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtLuongLoss = new System.Windows.Forms.TextBox();
            this.txtLiDo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nguyenVatLieuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nguyenVatLieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNVL = new System.Windows.Forms.TextBox();
            this.txtTenNVL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamLOSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenVatLieuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenVatLieuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanPhamLOSS
            // 
            this.dgvSanPhamLOSS.AllowUserToAddRows = false;
            this.dgvSanPhamLOSS.AllowUserToDeleteRows = false;
            this.dgvSanPhamLOSS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPhamLOSS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNVL,
            this.TenNVL,
            this.SoLuongLoss,
            this.LiDo});
            this.dgvSanPhamLOSS.Location = new System.Drawing.Point(-2, 245);
            this.dgvSanPhamLOSS.Name = "dgvSanPhamLOSS";
            this.dgvSanPhamLOSS.ReadOnly = true;
            this.dgvSanPhamLOSS.Size = new System.Drawing.Size(851, 199);
            this.dgvSanPhamLOSS.TabIndex = 0;
            this.dgvSanPhamLOSS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPhamLOSS_CellClick);
            // 
            // MaNVL
            // 
            this.MaNVL.HeaderText = "Mã Nguyên Vật Liệu";
            this.MaNVL.Name = "MaNVL";
            this.MaNVL.ReadOnly = true;
            this.MaNVL.Width = 200;
            // 
            // TenNVL
            // 
            this.TenNVL.HeaderText = "Tên Nguyên Vật Liệu";
            this.TenNVL.Name = "TenNVL";
            this.TenNVL.ReadOnly = true;
            this.TenNVL.Width = 200;
            // 
            // SoLuongLoss
            // 
            this.SoLuongLoss.HeaderText = "Số Lượng Loss";
            this.SoLuongLoss.Name = "SoLuongLoss";
            this.SoLuongLoss.ReadOnly = true;
            this.SoLuongLoss.Width = 200;
            // 
            // LiDo
            // 
            this.LiDo.HeaderText = "Lí Do";
            this.LiDo.Name = "LiDo";
            this.LiDo.ReadOnly = true;
            this.LiDo.Width = 200;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSua});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 0;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(853, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 424);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(853, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 400);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(853, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 400);
            // 
            // txtLuongLoss
            // 
            this.txtLuongLoss.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtLuongLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongLoss.Location = new System.Drawing.Point(161, 115);
            this.txtLuongLoss.Name = "txtLuongLoss";
            this.txtLuongLoss.Size = new System.Drawing.Size(220, 26);
            this.txtLuongLoss.TabIndex = 25;
            // 
            // txtLiDo
            // 
            this.txtLiDo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtLiDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiDo.Location = new System.Drawing.Point(161, 154);
            this.txtLiDo.Name = "txtLiDo";
            this.txtLiDo.Size = new System.Drawing.Size(220, 26);
            this.txtLiDo.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "1: Do quá trình shikomi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "3: Làm dư";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "2: Do quá trình vận hành";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "4: Khách hàng đổi trả";
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataSource = typeof(Sukiya.Models.HoaDon);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Lí Do";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Lượng LOSS";
            // 
            // nguyenVatLieuBindingSource1
            // 
            this.nguyenVatLieuBindingSource1.DataSource = typeof(Sukiya.Models.NguyenVatLieu);
            // 
            // nguyenVatLieuBindingSource
            // 
            this.nguyenVatLieuBindingSource.DataSource = typeof(Sukiya.Models.NguyenVatLieu);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Tên NVL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Mã NVL";
            // 
            // txtMaNVL
            // 
            this.txtMaNVL.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtMaNVL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNVL.Location = new System.Drawing.Point(161, 41);
            this.txtMaNVL.Name = "txtMaNVL";
            this.txtMaNVL.Size = new System.Drawing.Size(220, 26);
            this.txtMaNVL.TabIndex = 52;
            // 
            // txtTenNVL
            // 
            this.txtTenNVL.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTenNVL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNVL.Location = new System.Drawing.Point(161, 80);
            this.txtTenNVL.Name = "txtTenNVL";
            this.txtTenNVL.Size = new System.Drawing.Size(220, 26);
            this.txtTenNVL.TabIndex = 51;
            // 
            // uc_SanPhamLoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaNVL);
            this.Controls.Add(this.txtTenNVL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLuongLoss);
            this.Controls.Add(this.txtLiDo);
            this.Controls.Add(this.dgvSanPhamLOSS);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "uc_SanPhamLoss";
            this.Size = new System.Drawing.Size(853, 444);
            this.Load += new System.EventHandler(this.uc_SanPhamLoss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamLOSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenVatLieuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenVatLieuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPhamLOSS;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.TextBox txtLuongLoss;
        private System.Windows.Forms.TextBox txtLiDo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource nguyenVatLieuBindingSource;
        private System.Windows.Forms.BindingSource nguyenVatLieuBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNVL;
        private System.Windows.Forms.TextBox txtTenNVL;
    }
}
