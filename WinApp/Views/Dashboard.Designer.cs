﻿namespace WinApp.Views
{
    partial class Dashboard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtImagesAdded = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBooksAdded = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtVideosAdded = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMusicAdded = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chartMedia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.panel5.Controls.Add(this.txtImagesAdded);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(575, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(163, 81);
            this.panel5.TabIndex = 10;
            // 
            // txtImagesAdded
            // 
            this.txtImagesAdded.AutoSize = true;
            this.txtImagesAdded.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagesAdded.ForeColor = System.Drawing.Color.White;
            this.txtImagesAdded.Location = new System.Drawing.Point(3, 32);
            this.txtImagesAdded.Name = "txtImagesAdded";
            this.txtImagesAdded.Size = new System.Drawing.Size(44, 46);
            this.txtImagesAdded.TabIndex = 10;
            this.txtImagesAdded.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Imágenes";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(190)))), ((int)(((byte)(41)))));
            this.panel4.Controls.Add(this.txtBooksAdded);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(390, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 81);
            this.panel4.TabIndex = 11;
            // 
            // txtBooksAdded
            // 
            this.txtBooksAdded.AutoSize = true;
            this.txtBooksAdded.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBooksAdded.ForeColor = System.Drawing.Color.White;
            this.txtBooksAdded.Location = new System.Drawing.Point(3, 31);
            this.txtBooksAdded.Name = "txtBooksAdded";
            this.txtBooksAdded.Size = new System.Drawing.Size(44, 46);
            this.txtBooksAdded.TabIndex = 9;
            this.txtBooksAdded.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Libros";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(69)))));
            this.panel3.Controls.Add(this.txtVideosAdded);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(206, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 81);
            this.panel3.TabIndex = 12;
            // 
            // txtVideosAdded
            // 
            this.txtVideosAdded.AutoSize = true;
            this.txtVideosAdded.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVideosAdded.ForeColor = System.Drawing.Color.White;
            this.txtVideosAdded.Location = new System.Drawing.Point(2, 32);
            this.txtVideosAdded.Name = "txtVideosAdded";
            this.txtVideosAdded.Size = new System.Drawing.Size(44, 46);
            this.txtVideosAdded.TabIndex = 8;
            this.txtVideosAdded.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Videos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(89)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.txtMusicAdded);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(23, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 81);
            this.panel2.TabIndex = 9;
            // 
            // txtMusicAdded
            // 
            this.txtMusicAdded.AutoSize = true;
            this.txtMusicAdded.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMusicAdded.ForeColor = System.Drawing.Color.White;
            this.txtMusicAdded.Location = new System.Drawing.Point(3, 31);
            this.txtMusicAdded.Name = "txtMusicAdded";
            this.txtMusicAdded.Size = new System.Drawing.Size(44, 46);
            this.txtMusicAdded.TabIndex = 7;
            this.txtMusicAdded.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Musica";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 43);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // chartMedia
            // 
            this.chartMedia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(27)))));
            this.chartMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartMedia.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartMedia.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chartMedia.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chartMedia.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(27)))));
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.chartMedia.ChartAreas.Add(chartArea1);
            this.chartMedia.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(27)))));
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.chartMedia.Legends.Add(legend1);
            this.chartMedia.Location = new System.Drawing.Point(23, 171);
            this.chartMedia.Name = "chartMedia";
            this.chartMedia.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartMedia.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(69))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(89)))), ((int)(((byte)(239))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(190)))), ((int)(((byte)(41))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Count";
            series1.YValuesPerPoint = 2;
            this.chartMedia.Series.Add(series1);
            this.chartMedia.Size = new System.Drawing.Size(715, 244);
            this.chartMedia.TabIndex = 13;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(19)))));
            this.Controls.Add(this.chartMedia);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(758, 439);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMedia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label txtImagesAdded;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label txtBooksAdded;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label txtVideosAdded;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label txtMusicAdded;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMedia;
    }
}
