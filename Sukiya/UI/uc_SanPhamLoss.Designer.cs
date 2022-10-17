namespace Sukiya.UI
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
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNVL = new System.Windows.Forms.TextBox();
            this.txtLuongLoss = new System.Windows.Forms.Label();
            this.txtLiDo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNVL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamLOSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
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
            this.dgvSanPhamLOSS.Location = new System.Drawing.Point(0, 246);
            this.dgvSanPhamLOSS.Name = "dgvSanPhamLOSS";
            this.dgvSanPhamLOSS.ReadOnly = true;
            this.dgvSanPhamLOSS.Size = new System.Drawing.Size(851, 199);
            this.dgvSanPhamLOSS.TabIndex = 0;
            // 
            // MaNVL
            // 
            this.MaNVL.HeaderText = "Mã Nguyên Vật Liệu";
            this.MaNVL.Name = "MaNVL";
            this.MaNVL.ReadOnly = true;
            // 
            // TenNVL
            // 
            this.TenNVL.HeaderText = "Tên Nguyên Vật Liệu";
            this.TenNVL.Name = "TenNVL";
            this.TenNVL.ReadOnly = true;
            // 
            // SoLuongLoss
            // 
            this.SoLuongLoss.HeaderText = "Số Lượng Loss";
            this.SoLuongLoss.Name = "SoLuongLoss";
            this.SoLuongLoss.ReadOnly = true;
            // 
            // LiDo
            // 
            this.LiDo.HeaderText = "Lí Do";
            this.LiDo.Name = "LiDo";
            this.LiDo.ReadOnly = true;
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
            this.btnSua,
            this.btnXoa});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 0;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
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
            this.barDockControlTop.Size = new System.Drawing.Size(851, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 425);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(851, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 401);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(851, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 401);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Mã NVL";
            // 
            // txtMaNVL
            // 
            this.txtMaNVL.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtMaNVL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNVL.Location = new System.Drawing.Point(167, 51);
            this.txtMaNVL.Name = "txtMaNVL";
            this.txtMaNVL.Size = new System.Drawing.Size(220, 26);
            this.txtMaNVL.TabIndex = 29;
            // 
            // txtLuongLoss
            // 
            this.txtLuongLoss.AutoSize = true;
            this.txtLuongLoss.BackColor = System.Drawing.SystemColors.Control;
            this.txtLuongLoss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtLuongLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongLoss.Location = new System.Drawing.Point(462, 53);
            this.txtLuongLoss.Name = "txtLuongLoss";
            this.txtLuongLoss.Size = new System.Drawing.Size(113, 22);
            this.txtLuongLoss.TabIndex = 28;
            this.txtLuongLoss.Text = "Lượng LOSS";
            // 
            // txtLiDo
            // 
            this.txtLiDo.AutoSize = true;
            this.txtLiDo.BackColor = System.Drawing.SystemColors.Control;
            this.txtLiDo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtLiDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiDo.Location = new System.Drawing.Point(462, 92);
            this.txtLiDo.Name = "txtLiDo";
            this.txtLiDo.Size = new System.Drawing.Size(53, 22);
            this.txtLiDo.TabIndex = 27;
            this.txtLiDo.Text = "Lí Do";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tên NVL";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(611, 50);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(220, 26);
            this.txtSDT.TabIndex = 25;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(611, 89);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(220, 26);
            this.txtDiaChi.TabIndex = 24;
            // 
            // txtTenNVL
            // 
            this.txtTenNVL.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTenNVL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNVL.Location = new System.Drawing.Point(167, 90);
            this.txtTenNVL.Name = "txtTenNVL";
            this.txtTenNVL.Size = new System.Drawing.Size(220, 26);
            this.txtTenNVL.TabIndex = 23;
            // 
            // uc_SanPhamLoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaNVL);
            this.Controls.Add(this.txtLuongLoss);
            this.Controls.Add(this.txtLiDo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNVL);
            this.Controls.Add(this.dgvSanPhamLOSS);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "uc_SanPhamLoss";
            this.Size = new System.Drawing.Size(851, 445);
            this.Load += new System.EventHandler(this.uc_SanPhamLoss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamLOSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPhamLOSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiDo;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNVL;
        private System.Windows.Forms.Label txtLuongLoss;
        private System.Windows.Forms.Label txtLiDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNVL;
    }
}
