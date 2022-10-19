namespace Sukiya.UI
{
    partial class uc_BaoCaoDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoadBaoCao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.chartDoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.LegendText = "VNĐ";
            series1.Name = "ChartDT";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(1216, 490);
            this.chartDoanhThu.TabIndex = 0;
            this.chartDoanhThu.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title1.Name = "Title1";
            title1.Text = "Biểu đồ doanh thu theo ngày ";
            this.chartDoanhThu.Titles.Add(title1);
            // 
            // btnLoadBaoCao
            // 
            this.btnLoadBaoCao.Font = new System.Drawing.Font("Lexend Deca", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadBaoCao.Location = new System.Drawing.Point(87, 508);
            this.btnLoadBaoCao.Name = "btnLoadBaoCao";
            this.btnLoadBaoCao.Size = new System.Drawing.Size(154, 56);
            this.btnLoadBaoCao.TabIndex = 1;
            this.btnLoadBaoCao.Text = "Load";
            this.btnLoadBaoCao.UseVisualStyleBackColor = true;
            this.btnLoadBaoCao.Click += new System.EventHandler(this.btnLoadBaoCao_Click);
            // 
            // uc_BaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoadBaoCao);
            this.Controls.Add(this.chartDoanhThu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uc_BaoCaoDoanhThu";
            this.Size = new System.Drawing.Size(1216, 628);
            this.Load += new System.EventHandler(this.uc_BaoCaoDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.Button btnLoadBaoCao;
    }
}
