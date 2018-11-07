namespace emailform
{
    partial class emailform
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
            this.label1 = new System.Windows.Forms.Label();
            this.SendTo = new System.Windows.Forms.TextBox();
            this.SendSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SendBox = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "收件人";
            // 
            // SendTo
            // 
            this.SendTo.Location = new System.Drawing.Point(107, 40);
            this.SendTo.Name = "SendTo";
            this.SendTo.Size = new System.Drawing.Size(863, 25);
            this.SendTo.TabIndex = 1;
            // 
            // SendSubject
            // 
            this.SendSubject.Location = new System.Drawing.Point(107, 98);
            this.SendSubject.Name = "SendSubject";
            this.SendSubject.Size = new System.Drawing.Size(863, 25);
            this.SendSubject.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "主题";
            // 
            // SendBox
            // 
            this.SendBox.Location = new System.Drawing.Point(41, 145);
            this.SendBox.Name = "SendBox";
            this.SendBox.Size = new System.Drawing.Size(929, 342);
            this.SendBox.TabIndex = 4;
            this.SendBox.Text = "";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(827, 507);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(143, 35);
            this.send.TabIndex = 6;
            this.send.Text = "发送";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.button2_Click);
            // 
            // emailform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.send);
            this.Controls.Add(this.SendBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SendSubject);
            this.Controls.Add(this.SendTo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "emailform";
            this.Text = "邮件发送";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SendTo;
        private System.Windows.Forms.TextBox SendSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox SendBox;
        private System.Windows.Forms.Button send;
    }
}

