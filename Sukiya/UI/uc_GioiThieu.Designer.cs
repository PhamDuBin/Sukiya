namespace Sukiya.UI
{
    partial class uc_GioiThieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_GioiThieu));
            this.imgSlider = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSlider
            // 
            this.imgSlider.AnimationTime = 10;
            this.imgSlider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgSlider.CurrentImageIndex = 0;
            this.imgSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgSlider.Images.Add(((System.Drawing.Image)(resources.GetObject("imgSlider.Images"))));
            this.imgSlider.Images.Add(((System.Drawing.Image)(resources.GetObject("imgSlider.Images1"))));
            this.imgSlider.Images.Add(((System.Drawing.Image)(resources.GetObject("imgSlider.Images2"))));
            this.imgSlider.Images.Add(((System.Drawing.Image)(resources.GetObject("imgSlider.Images3"))));
            this.imgSlider.Location = new System.Drawing.Point(0, 0);
            this.imgSlider.Name = "imgSlider";
            this.imgSlider.Size = new System.Drawing.Size(1073, 679);
            this.imgSlider.TabIndex = 0;
            this.imgSlider.Text = "imageSlider1";
            // 
            // uc_GioiThieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imgSlider);
            this.Name = "uc_GioiThieu";
            this.Size = new System.Drawing.Size(1073, 679);
            ((System.ComponentModel.ISupportInitialize)(this.imgSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider imgSlider;
    }
}
