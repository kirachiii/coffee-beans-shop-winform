namespace WindowsFormsApp1
{
    partial class Form購物車
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
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btn移除所選項目 = new System.Windows.Forms.Button();
            this.btn清空購物車 = new System.Windows.Forms.Button();
            this.btn確認購買下單 = new System.Windows.Forms.Button();
            this.btn關閉表單 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl總價格 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCart
            // 
            this.dgvCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(138)))));
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(12, 12);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(1007, 444);
            this.dgvCart.TabIndex = 0;
            // 
            // btn移除所選項目
            // 
            this.btn移除所選項目.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn移除所選項目.Location = new System.Drawing.Point(416, 475);
            this.btn移除所選項目.Name = "btn移除所選項目";
            this.btn移除所選項目.Size = new System.Drawing.Size(180, 51);
            this.btn移除所選項目.TabIndex = 1;
            this.btn移除所選項目.Text = "移除所選項目";
            this.btn移除所選項目.UseVisualStyleBackColor = true;
            this.btn移除所選項目.Click += new System.EventHandler(this.btn移除所選項目_Click);
            // 
            // btn清空購物車
            // 
            this.btn清空購物車.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn清空購物車.Location = new System.Drawing.Point(416, 532);
            this.btn清空購物車.Name = "btn清空購物車";
            this.btn清空購物車.Size = new System.Drawing.Size(180, 51);
            this.btn清空購物車.TabIndex = 2;
            this.btn清空購物車.Text = "清空購物車";
            this.btn清空購物車.UseVisualStyleBackColor = true;
            this.btn清空購物車.Click += new System.EventHandler(this.btn清空購物車_Click);
            // 
            // btn確認購買下單
            // 
            this.btn確認購買下單.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn確認購買下單.Location = new System.Drawing.Point(602, 499);
            this.btn確認購買下單.Name = "btn確認購買下單";
            this.btn確認購買下單.Size = new System.Drawing.Size(188, 51);
            this.btn確認購買下單.TabIndex = 3;
            this.btn確認購買下單.Text = "確認購買下單";
            this.btn確認購買下單.UseVisualStyleBackColor = true;
            this.btn確認購買下單.Click += new System.EventHandler(this.btn確認購買下單_Click);
            // 
            // btn關閉表單
            // 
            this.btn關閉表單.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn關閉表單.Location = new System.Drawing.Point(859, 462);
            this.btn關閉表單.Name = "btn關閉表單";
            this.btn關閉表單.Size = new System.Drawing.Size(160, 94);
            this.btn關閉表單.TabIndex = 4;
            this.btn關閉表單.Text = "回到訂購單";
            this.btn關閉表單.UseVisualStyleBackColor = true;
            this.btn關閉表單.Click += new System.EventHandler(this.btn關閉表單_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "總價格";
            // 
            // lbl總價格
            // 
            this.lbl總價格.AutoSize = true;
            this.lbl總價格.Location = new System.Drawing.Point(134, 520);
            this.lbl總價格.Name = "lbl總價格";
            this.lbl總價格.Size = new System.Drawing.Size(97, 30);
            this.lbl總價格.TabIndex = 6;
            this.lbl總價格.Text = "000000";
            // 
            // Form購物車
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1031, 597);
            this.Controls.Add(this.lbl總價格);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn關閉表單);
            this.Controls.Add(this.btn確認購買下單);
            this.Controls.Add(this.btn清空購物車);
            this.Controls.Add(this.btn移除所選項目);
            this.Controls.Add(this.dgvCart);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Form購物車";
            this.Text = "購物車";
            this.Load += new System.EventHandler(this.Form購物車_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btn移除所選項目;
        private System.Windows.Forms.Button btn清空購物車;
        private System.Windows.Forms.Button btn確認購買下單;
        private System.Windows.Forms.Button btn關閉表單;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl總價格;
    }
}