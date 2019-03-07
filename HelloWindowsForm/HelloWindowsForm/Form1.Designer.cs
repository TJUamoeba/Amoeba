namespace HelloWindowsForm
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
            this.HelloWindowsForm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HelloWindowsForm
            // 
            this.HelloWindowsForm.AccessibleDescription = "Hello";
            this.HelloWindowsForm.AccessibleName = "Hello";
            this.HelloWindowsForm.AutoSize = true;
            this.HelloWindowsForm.BackColor = System.Drawing.Color.Firebrick;
            this.HelloWindowsForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HelloWindowsForm.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HelloWindowsForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HelloWindowsForm.Location = new System.Drawing.Point(345, 293);
            this.HelloWindowsForm.Name = "HelloWindowsForm";
            this.HelloWindowsForm.Size = new System.Drawing.Size(85, 58);
            this.HelloWindowsForm.TabIndex = 0;
            this.HelloWindowsForm.Text = "Hello";
            this.HelloWindowsForm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.HelloWindowsForm.UseVisualStyleBackColor = false;
            this.HelloWindowsForm.UseWaitCursor = true;
            this.HelloWindowsForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 25);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.HelloWindowsForm);
            this.Name = "Form1";
            this.Text = "Hello!";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HelloWindowsForm;
        private System.Windows.Forms.TextBox textBox1;
    }
}

