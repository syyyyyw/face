﻿namespace peoplePicture
{
    partial class voicedeal
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
            this.语音合成 = new System.Windows.Forms.GroupBox();
            this.synthesisButton = new System.Windows.Forms.Button();
            this.Speech_Synthesis = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.voiceResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.videoType = new System.Windows.Forms.ComboBox();
            this.filePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.语音合成.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 语音合成
            // 
            this.语音合成.Controls.Add(this.synthesisButton);
            this.语音合成.Controls.Add(this.Speech_Synthesis);
            this.语音合成.Location = new System.Drawing.Point(567, 118);
            this.语音合成.Margin = new System.Windows.Forms.Padding(4);
            this.语音合成.Name = "语音合成";
            this.语音合成.Padding = new System.Windows.Forms.Padding(4);
            this.语音合成.Size = new System.Drawing.Size(401, 348);
            this.语音合成.TabIndex = 6;
            this.语音合成.TabStop = false;
            this.语音合成.Text = "语音合成";
            // 
            // synthesisButton
            // 
            this.synthesisButton.Location = new System.Drawing.Point(257, 308);
            this.synthesisButton.Margin = new System.Windows.Forms.Padding(4);
            this.synthesisButton.Name = "synthesisButton";
            this.synthesisButton.Size = new System.Drawing.Size(100, 29);
            this.synthesisButton.TabIndex = 3;
            this.synthesisButton.Text = "开始合成";
            this.synthesisButton.UseVisualStyleBackColor = true;
            this.synthesisButton.Click += new System.EventHandler(this.synthesisButton_Click);
            // 
            // Speech_Synthesis
            // 
            this.Speech_Synthesis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Speech_Synthesis.Location = new System.Drawing.Point(20, 25);
            this.Speech_Synthesis.Margin = new System.Windows.Forms.Padding(4);
            this.Speech_Synthesis.Multiline = true;
            this.Speech_Synthesis.Name = "Speech_Synthesis";
            this.Speech_Synthesis.Size = new System.Drawing.Size(357, 273);
            this.Speech_Synthesis.TabIndex = 2;
            this.Speech_Synthesis.Text = "愿中国青年都摆脱冷气，只是向上走，不必听自暴自弃者流的话。能做事的做事，能发声的发声。有一分热，发一分光，就令萤火一般，也可以在黑暗里发一点\r\n光，不必等候炬火。" +
    "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.voiceResult);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.videoType);
            this.groupBox1.Controls.Add(this.filePath);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(79, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(461, 348);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "语音识别";
            // 
            // voiceResult
            // 
            this.voiceResult.Location = new System.Drawing.Point(31, 192);
            this.voiceResult.Margin = new System.Windows.Forms.Padding(4);
            this.voiceResult.Multiline = true;
            this.voiceResult.Name = "voiceResult";
            this.voiceResult.Size = new System.Drawing.Size(368, 122);
            this.voiceResult.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "识别结果";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 104);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "开始识别";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "音频格式";
            // 
            // videoType
            // 
            this.videoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoType.FormattingEnabled = true;
            this.videoType.ImeMode = System.Windows.Forms.ImeMode.On;
            this.videoType.Items.AddRange(new object[] {
            "PCM",
            "WAV",
            "AMR"});
            this.videoType.Location = new System.Drawing.Point(127, 104);
            this.videoType.Margin = new System.Windows.Forms.Padding(4);
            this.videoType.Name = "videoType";
            this.videoType.Size = new System.Drawing.Size(163, 23);
            this.videoType.TabIndex = 1;
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(31, 40);
            this.filePath.Margin = new System.Windows.Forms.Padding(4);
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            this.filePath.Size = new System.Drawing.Size(259, 25);
            this.filePath.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // voicedeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 585);
            this.Controls.Add(this.语音合成);
            this.Controls.Add(this.groupBox1);
            this.Name = "voicedeal";
            this.Text = "voicedeal";
            this.语音合成.ResumeLayout(false);
            this.语音合成.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 语音合成;
        private System.Windows.Forms.Button synthesisButton;
        private System.Windows.Forms.TextBox Speech_Synthesis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox voiceResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox videoType;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button button1;
    }
}