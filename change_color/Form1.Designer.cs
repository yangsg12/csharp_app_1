namespace change_color
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbcolor = new System.Windows.Forms.TextBox();
            this.hsbr = new System.Windows.Forms.HScrollBar();
            this.hsbb = new System.Windows.Forms.HScrollBar();
            this.hsbg = new System.Windows.Forms.HScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "scroll bar ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "blue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "green";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "预览";
            // 
            // lbcolor
            // 
            this.lbcolor.Location = new System.Drawing.Point(383, 155);
            this.lbcolor.Name = "lbcolor";
            this.lbcolor.Size = new System.Drawing.Size(100, 21);
            this.lbcolor.TabIndex = 5;
            // 
            // hsbr
            // 
            this.hsbr.Location = new System.Drawing.Point(105, 116);
            this.hsbr.Maximum = 255;
            this.hsbr.Name = "hsbr";
            this.hsbr.Size = new System.Drawing.Size(229, 17);
            this.hsbr.TabIndex = 6;
            this.hsbr.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbr_Scroll);
            // 
            // hsbb
            // 
            this.hsbb.Location = new System.Drawing.Point(105, 155);
            this.hsbb.Maximum = 255;
            this.hsbb.Name = "hsbb";
            this.hsbb.Size = new System.Drawing.Size(220, 17);
            this.hsbb.TabIndex = 7;
            this.hsbb.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbb_Scroll);
            // 
            // hsbg
            // 
            this.hsbg.Location = new System.Drawing.Point(105, 202);
            this.hsbg.Maximum = 255;
            this.hsbg.Name = "hsbg";
            this.hsbg.Size = new System.Drawing.Size(220, 17);
            this.hsbg.TabIndex = 8;
            this.hsbg.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbg_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "set backgroud color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "set font color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hsbg);
            this.Controls.Add(this.hsbb);
            this.Controls.Add(this.hsbr);
            this.Controls.Add(this.lbcolor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lbcolor;
        private System.Windows.Forms.HScrollBar hsbr;
        private System.Windows.Forms.HScrollBar hsbb;
        private System.Windows.Forms.HScrollBar hsbg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

