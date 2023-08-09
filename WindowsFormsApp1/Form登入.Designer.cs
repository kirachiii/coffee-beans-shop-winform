namespace WindowsFormsApp1
{
    partial class Form登入
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
            this.btn登入 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt帳號 = new System.Windows.Forms.TextBox();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.btn建立新帳號 = new System.Windows.Forms.Button();
            this.chk顯示密碼 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn登入
            // 
            this.btn登入.Location = new System.Drawing.Point(210, 290);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(284, 51);
            this.btn登入.TabIndex = 0;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = true;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "帳號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼";
            // 
            // txt帳號
            // 
            this.txt帳號.Location = new System.Drawing.Point(210, 124);
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Size = new System.Drawing.Size(243, 39);
            this.txt帳號.TabIndex = 3;
            // 
            // txt密碼
            // 
            this.txt密碼.Location = new System.Drawing.Point(210, 207);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.Size = new System.Drawing.Size(243, 39);
            this.txt密碼.TabIndex = 4;
            // 
            // btn建立新帳號
            // 
            this.btn建立新帳號.Location = new System.Drawing.Point(357, 428);
            this.btn建立新帳號.Name = "btn建立新帳號";
            this.btn建立新帳號.Size = new System.Drawing.Size(170, 51);
            this.btn建立新帳號.TabIndex = 5;
            this.btn建立新帳號.Text = "建立新帳號";
            this.btn建立新帳號.UseVisualStyleBackColor = true;
            this.btn建立新帳號.Click += new System.EventHandler(this.btn建立新帳號_Click);
            // 
            // chk顯示密碼
            // 
            this.chk顯示密碼.AutoSize = true;
            this.chk顯示密碼.Location = new System.Drawing.Point(468, 215);
            this.chk顯示密碼.Name = "chk顯示密碼";
            this.chk顯示密碼.Size = new System.Drawing.Size(128, 34);
            this.chk顯示密碼.TabIndex = 6;
            this.chk顯示密碼.Text = "顯示密碼";
            this.chk顯示密碼.UseVisualStyleBackColor = true;
            this.chk顯示密碼.CheckedChanged += new System.EventHandler(this.chk顯示密碼_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "還沒有帳號嗎？";
            // 
            // Form登入
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(764, 654);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chk顯示密碼);
            this.Controls.Add(this.btn建立新帳號);
            this.Controls.Add(this.txt密碼);
            this.Controls.Add(this.txt帳號);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn登入);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Form登入";
            this.Text = "登入";
            this.Load += new System.EventHandler(this.Form登入_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt帳號;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Button btn建立新帳號;
        private System.Windows.Forms.CheckBox chk顯示密碼;
        private System.Windows.Forms.Label label3;
    }
}