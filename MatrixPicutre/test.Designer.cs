namespace MatrixPicutre
{
    partial class test
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPicture1 = new TableLayoutPicture.PictureTable();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPicture1
            // 
            this.tableLayoutPicture1.ColumnCount = 8;
            this.tableLayoutPicture1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPicture1.ImageNG = ((System.Drawing.Image)(resources.GetObject("tableLayoutPicture1.ImageNG")));
            this.tableLayoutPicture1.ImageOK = ((System.Drawing.Image)(resources.GetObject("tableLayoutPicture1.ImageOK")));
            this.tableLayoutPicture1.Location = new System.Drawing.Point(0, 72);
            this.tableLayoutPicture1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPicture1.Name = "tableLayoutPicture1";
            this.tableLayoutPicture1.Order = TableLayoutPicture.PictureTable.IndexOrder.DownToUpThenRightToLeft;
            this.tableLayoutPicture1.PictureSizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tableLayoutPicture1.RowCount = 8;
            this.tableLayoutPicture1.Size = new System.Drawing.Size(578, 503);
            this.tableLayoutPicture1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(420, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 575);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPicture1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "test";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPicture.PictureTable tableLayoutPicture1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

