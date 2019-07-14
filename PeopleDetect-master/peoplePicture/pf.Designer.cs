namespace peoplePicture
{
    partial class pf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pf));
            this.textBox_token = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_open = new System.Windows.Forms.Button();
            this.button_detect = new System.Windows.Forms.Button();
            this.label_path = new System.Windows.Forms.Label();
            this.button_change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_token
            // 
            this.textBox_token.AcceptsReturn = true;
            this.textBox_token.Location = new System.Drawing.Point(436, 56);
            this.textBox_token.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_token.Multiline = true;
            this.textBox_token.Name = "textBox_token";
            this.textBox_token.ReadOnly = true;
            this.textBox_token.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_token.Size = new System.Drawing.Size(499, 518);
            this.textBox_token.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 499);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(16, 14);
            this.button_open.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(100, 29);
            this.button_open.TabIndex = 2;
            this.button_open.Text = "打开图片";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_detect
            // 
            this.button_detect.Location = new System.Drawing.Point(436, 20);
            this.button_detect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_detect.Name = "button_detect";
            this.button_detect.Size = new System.Drawing.Size(92, 29);
            this.button_detect.TabIndex = 3;
            this.button_detect.Text = "检测数据";
            this.button_detect.UseVisualStyleBackColor = true;
            this.button_detect.Click += new System.EventHandler(this.button_detect_Click);
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Location = new System.Drawing.Point(13, 52);
            this.label_path.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(67, 15);
            this.label_path.TabIndex = 6;
            this.label_path.Text = "图片路径";
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(773, 20);
            this.button_change.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(163, 29);
            this.button_change.TabIndex = 7;
            this.button_change.Text = "转换成给人看的数据";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "第一步打开图片";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "第二步检测数据";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "第三步转换成人看的数据";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 601);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.button_detect);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_token);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "人脸识别";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_token;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_detect;
        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

