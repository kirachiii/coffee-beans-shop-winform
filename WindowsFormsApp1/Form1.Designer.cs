namespace WindowsFormsApp1
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn商品管理 = new System.Windows.Forms.Button();
            this.btn會員資料管理 = new System.Windows.Forms.Button();
            this.btn訂單管理 = new System.Windows.Forms.Button();
            this.btn訂購單Menu = new System.Windows.Forms.Button();
            this.btn員工資料管理 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn商品管理
            // 
            this.btn商品管理.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn商品管理.Location = new System.Drawing.Point(454, 185);
            this.btn商品管理.Margin = new System.Windows.Forms.Padding(2);
            this.btn商品管理.Name = "btn商品管理";
            this.btn商品管理.Size = new System.Drawing.Size(182, 103);
            this.btn商品管理.TabIndex = 12;
            this.btn商品管理.Text = "商品管理";
            this.btn商品管理.UseVisualStyleBackColor = true;
            this.btn商品管理.Click += new System.EventHandler(this.btn商品管理_Click);
            // 
            // btn會員資料管理
            // 
            this.btn會員資料管理.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員資料管理.Location = new System.Drawing.Point(94, 328);
            this.btn會員資料管理.Margin = new System.Windows.Forms.Padding(2);
            this.btn會員資料管理.Name = "btn會員資料管理";
            this.btn會員資料管理.Size = new System.Drawing.Size(194, 103);
            this.btn會員資料管理.TabIndex = 11;
            this.btn會員資料管理.Text = "會員資料管理";
            this.btn會員資料管理.UseVisualStyleBackColor = true;
            this.btn會員資料管理.Click += new System.EventHandler(this.btn會員資料管理_Click);
            // 
            // btn訂單管理
            // 
            this.btn訂單管理.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單管理.Location = new System.Drawing.Point(241, 185);
            this.btn訂單管理.Margin = new System.Windows.Forms.Padding(2);
            this.btn訂單管理.Name = "btn訂單管理";
            this.btn訂單管理.Size = new System.Drawing.Size(171, 103);
            this.btn訂單管理.TabIndex = 10;
            this.btn訂單管理.Text = "訂單管理";
            this.btn訂單管理.UseVisualStyleBackColor = true;
            this.btn訂單管理.Click += new System.EventHandler(this.btn訂單管理_Click);
            // 
            // btn訂購單Menu
            // 
            this.btn訂購單Menu.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂購單Menu.Location = new System.Drawing.Point(34, 185);
            this.btn訂購單Menu.Margin = new System.Windows.Forms.Padding(2);
            this.btn訂購單Menu.Name = "btn訂購單Menu";
            this.btn訂購單Menu.Size = new System.Drawing.Size(171, 103);
            this.btn訂購單Menu.TabIndex = 9;
            this.btn訂購單Menu.Text = "訂購單Menu";
            this.btn訂購單Menu.UseVisualStyleBackColor = true;
            this.btn訂購單Menu.Click += new System.EventHandler(this.btn訂購單Menu_Click);
            // 
            // btn員工資料管理
            // 
            this.btn員工資料管理.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn員工資料管理.Location = new System.Drawing.Point(357, 328);
            this.btn員工資料管理.Margin = new System.Windows.Forms.Padding(2);
            this.btn員工資料管理.Name = "btn員工資料管理";
            this.btn員工資料管理.Size = new System.Drawing.Size(194, 103);
            this.btn員工資料管理.TabIndex = 14;
            this.btn員工資料管理.Text = "員工資料管理";
            this.btn員工資料管理.UseVisualStyleBackColor = true;
            this.btn員工資料管理.Click += new System.EventHandler(this.btn員工資料管理_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 549);
            this.Controls.Add(this.btn員工資料管理);
            this.Controls.Add(this.btn商品管理);
            this.Controls.Add(this.btn會員資料管理);
            this.Controls.Add(this.btn訂單管理);
            this.Controls.Add(this.btn訂購單Menu);
            this.Name = "Form1";
            this.Text = "管理系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn商品管理;
        private System.Windows.Forms.Button btn會員資料管理;
        private System.Windows.Forms.Button btn訂單管理;
        private System.Windows.Forms.Button btn訂購單Menu;
        private System.Windows.Forms.Button btn員工資料管理;
    }
}

