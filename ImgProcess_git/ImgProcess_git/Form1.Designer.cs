namespace ImgProcess_git
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTransToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.originToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morphologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wTHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bTHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastEnhancementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageTransToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipVerticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.imgProcessToolStripMenuItem,
            this.imageTransToolStripMenuItem,
            this.showChartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // imgProcessToolStripMenuItem
            // 
            this.imgProcessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hEToolStripMenuItem,
            this.labelingToolStripMenuItem,
            this.imageSubToolStripMenuItem,
            this.colorTransToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.morphologyToolStripMenuItem});
            this.imgProcessToolStripMenuItem.Name = "imgProcessToolStripMenuItem";
            this.imgProcessToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.imgProcessToolStripMenuItem.Text = "影像處理";
            // 
            // hEToolStripMenuItem
            // 
            this.hEToolStripMenuItem.Name = "hEToolStripMenuItem";
            this.hEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hEToolStripMenuItem.Text = "HE";
            this.hEToolStripMenuItem.Click += new System.EventHandler(this.hEToolStripMenuItem_Click);
            // 
            // labelingToolStripMenuItem
            // 
            this.labelingToolStripMenuItem.Name = "labelingToolStripMenuItem";
            this.labelingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.labelingToolStripMenuItem.Text = "Labeling";
            this.labelingToolStripMenuItem.Click += new System.EventHandler(this.labelingToolStripMenuItem_Click);
            // 
            // imageSubToolStripMenuItem
            // 
            this.imageSubToolStripMenuItem.Name = "imageSubToolStripMenuItem";
            this.imageSubToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.imageSubToolStripMenuItem.Text = "ImageSub";
            this.imageSubToolStripMenuItem.Click += new System.EventHandler(this.imageSubToolStripMenuItem_Click);
            // 
            // colorTransToolStripMenuItem
            // 
            this.colorTransToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayToolStripMenuItem1,
            this.binaryToolStripMenuItem1,
            this.originToolStripMenuItem});
            this.colorTransToolStripMenuItem.Name = "colorTransToolStripMenuItem";
            this.colorTransToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorTransToolStripMenuItem.Text = "色彩轉換";
            // 
            // grayToolStripMenuItem1
            // 
            this.grayToolStripMenuItem1.Name = "grayToolStripMenuItem1";
            this.grayToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.grayToolStripMenuItem1.Text = "Gray";
            this.grayToolStripMenuItem1.Click += new System.EventHandler(this.grayToolStripMenuItem1_Click);
            // 
            // binaryToolStripMenuItem1
            // 
            this.binaryToolStripMenuItem1.Name = "binaryToolStripMenuItem1";
            this.binaryToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.binaryToolStripMenuItem1.Text = "Binary";
            this.binaryToolStripMenuItem1.Click += new System.EventHandler(this.binaryToolStripMenuItem1_Click);
            // 
            // originToolStripMenuItem
            // 
            this.originToolStripMenuItem.Name = "originToolStripMenuItem";
            this.originToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.originToolStripMenuItem.Text = "Origin";
            this.originToolStripMenuItem.Click += new System.EventHandler(this.originToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brightnessToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.smoothToolStripMenuItem,
            this.medianToolStripMenuItem,
            this.sobelToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.brightnessToolStripMenuItem_Click);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            this.sharpenToolStripMenuItem.Click += new System.EventHandler(this.sharpenToolStripMenuItem_Click);
            // 
            // smoothToolStripMenuItem
            // 
            this.smoothToolStripMenuItem.Name = "smoothToolStripMenuItem";
            this.smoothToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.smoothToolStripMenuItem.Text = "Smooth";
            this.smoothToolStripMenuItem.Click += new System.EventHandler(this.smoothToolStripMenuItem_Click);
            // 
            // medianToolStripMenuItem
            // 
            this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
            this.medianToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.medianToolStripMenuItem.Text = "Median";
            this.medianToolStripMenuItem.Click += new System.EventHandler(this.medianToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // morphologyToolStripMenuItem
            // 
            this.morphologyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erosionToolStripMenuItem,
            this.dilationToolStripMenuItem,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.wTHToolStripMenuItem,
            this.bTHToolStripMenuItem,
            this.contrastEnhancementToolStripMenuItem});
            this.morphologyToolStripMenuItem.Name = "morphologyToolStripMenuItem";
            this.morphologyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.morphologyToolStripMenuItem.Text = "Morphology";
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.erosionToolStripMenuItem.Text = "Erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.dilationToolStripMenuItem.Text = "Dilation";
            this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.openingToolStripMenuItem.Text = "Opening";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.closingToolStripMenuItem.Text = "Closing";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
            // 
            // wTHToolStripMenuItem
            // 
            this.wTHToolStripMenuItem.Name = "wTHToolStripMenuItem";
            this.wTHToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.wTHToolStripMenuItem.Text = "WTH";
            this.wTHToolStripMenuItem.Click += new System.EventHandler(this.wTHToolStripMenuItem_Click);
            // 
            // bTHToolStripMenuItem
            // 
            this.bTHToolStripMenuItem.Name = "bTHToolStripMenuItem";
            this.bTHToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.bTHToolStripMenuItem.Text = "BTH";
            this.bTHToolStripMenuItem.Click += new System.EventHandler(this.bTHToolStripMenuItem_Click);
            // 
            // contrastEnhancementToolStripMenuItem
            // 
            this.contrastEnhancementToolStripMenuItem.Name = "contrastEnhancementToolStripMenuItem";
            this.contrastEnhancementToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.contrastEnhancementToolStripMenuItem.Text = "Contrast Enhancement";
            this.contrastEnhancementToolStripMenuItem.Click += new System.EventHandler(this.contrastEnhancementToolStripMenuItem_Click);
            // 
            // imageTransToolStripMenuItem
            // 
            this.imageTransToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.flipHorizontallyToolStripMenuItem,
            this.flipVerticallyToolStripMenuItem,
            this.twistToolStripMenuItem});
            this.imageTransToolStripMenuItem.Name = "imageTransToolStripMenuItem";
            this.imageTransToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.imageTransToolStripMenuItem.Text = "ImageTrans";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.zoomInToolStripMenuItem.Text = "ZoomIn";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.zoomOutToolStripMenuItem.Text = "ZoomOut";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // flipHorizontallyToolStripMenuItem
            // 
            this.flipHorizontallyToolStripMenuItem.Name = "flipHorizontallyToolStripMenuItem";
            this.flipHorizontallyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.flipHorizontallyToolStripMenuItem.Text = "Flip Horizontally";
            this.flipHorizontallyToolStripMenuItem.Click += new System.EventHandler(this.flipHorizontallyToolStripMenuItem_Click);
            // 
            // flipVerticallyToolStripMenuItem
            // 
            this.flipVerticallyToolStripMenuItem.Name = "flipVerticallyToolStripMenuItem";
            this.flipVerticallyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.flipVerticallyToolStripMenuItem.Text = "Flip Vertically";
            this.flipVerticallyToolStripMenuItem.Click += new System.EventHandler(this.flipVerticallyToolStripMenuItem_Click);
            // 
            // twistToolStripMenuItem
            // 
            this.twistToolStripMenuItem.Name = "twistToolStripMenuItem";
            this.twistToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.twistToolStripMenuItem.Text = "Twist";
            this.twistToolStripMenuItem.Click += new System.EventHandler(this.twistToolStripMenuItem_Click);
            // 
            // showChartToolStripMenuItem
            // 
            this.showChartToolStripMenuItem.Name = "showChartToolStripMenuItem";
            this.showChartToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.showChartToolStripMenuItem.Text = "ShowChart";
            this.showChartToolStripMenuItem.Click += new System.EventHandler(this.showChartToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(388, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 270);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 316);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imgProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageSubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageTransToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipHorizontallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipVerticallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showChartToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem colorTransToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem originToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smoothToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morphologyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wTHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bTHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastEnhancementToolStripMenuItem;
    }
}

