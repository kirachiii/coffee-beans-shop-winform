namespace WindowsFormsApp1
{
    partial class Form商品資料
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
            this.components = new System.ComponentModel.Container();
            this.txt商品描述 = new System.Windows.Forms.TextBox();
            this.txt商品價格 = new System.Windows.Forms.TextBox();
            this.txt商品名稱 = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt份量 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn加入購物車 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn儲存修改 = new System.Windows.Forms.Button();
            this.btn選取商品圖片 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn新增儲存修改 = new System.Windows.Forms.Button();
            this.btn新增選取商品圖片 = new System.Windows.Forms.Button();
            this.txt庫存 = new System.Windows.Forms.TextBox();
            this.lbl庫存 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt商品描述
            // 
            this.txt商品描述.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品描述.Location = new System.Drawing.Point(123, 179);
            this.txt商品描述.Margin = new System.Windows.Forms.Padding(2);
            this.txt商品描述.Multiline = true;
            this.txt商品描述.Name = "txt商品描述";
            this.txt商品描述.ReadOnly = true;
            this.txt商品描述.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt商品描述.Size = new System.Drawing.Size(435, 257);
            this.txt商品描述.TabIndex = 18;
            // 
            // txt商品價格
            // 
            this.txt商品價格.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品價格.Location = new System.Drawing.Point(123, 135);
            this.txt商品價格.Margin = new System.Windows.Forms.Padding(2);
            this.txt商品價格.Name = "txt商品價格";
            this.txt商品價格.ReadOnly = true;
            this.txt商品價格.Size = new System.Drawing.Size(164, 39);
            this.txt商品價格.TabIndex = 17;
            // 
            // txt商品名稱
            // 
            this.txt商品名稱.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品名稱.Location = new System.Drawing.Point(123, 92);
            this.txt商品名稱.Margin = new System.Windows.Forms.Padding(2);
            this.txt商品名稱.Name = "txt商品名稱";
            this.txt商品名稱.ReadOnly = true;
            this.txt商品名稱.Size = new System.Drawing.Size(337, 39);
            this.txt商品名稱.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(138)))));
            this.lblID.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.Location = new System.Drawing.Point(125, 53);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(111, 30);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "0000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(4, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "商品描述";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(4, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "商品價格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(4, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "商品名稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(38, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(286, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "商品詳細資訊";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(593, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 372);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txt份量
            // 
            this.txt份量.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(138)))));
            this.txt份量.Font = new System.Drawing.Font("微軟正黑體", 17.5F);
            this.txt份量.Location = new System.Drawing.Point(123, 516);
            this.txt份量.Margin = new System.Windows.Forms.Padding(2);
            this.txt份量.Name = "txt份量";
            this.txt份量.Size = new System.Drawing.Size(40, 39);
            this.txt份量.TabIndex = 20;
            this.txt份量.Text = "1";
            this.txt份量.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(160, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(95, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn加入購物車
            // 
            this.btn加入購物車.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn加入購物車.Location = new System.Drawing.Point(232, 511);
            this.btn加入購物車.Name = "btn加入購物車";
            this.btn加入購物車.Size = new System.Drawing.Size(150, 49);
            this.btn加入購物車.TabIndex = 23;
            this.btn加入購物車.Text = "加入購物車";
            this.btn加入購物車.UseVisualStyleBackColor = true;
            this.btn加入購物車.Click += new System.EventHandler(this.btn加入購物車_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn儲存修改);
            this.groupBox1.Controls.Add(this.btn選取商品圖片);
            this.groupBox1.Location = new System.Drawing.Point(593, 492);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 120);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品修改";
            this.groupBox1.Visible = false;
            // 
            // btn儲存修改
            // 
            this.btn儲存修改.Location = new System.Drawing.Point(230, 44);
            this.btn儲存修改.Margin = new System.Windows.Forms.Padding(2);
            this.btn儲存修改.Name = "btn儲存修改";
            this.btn儲存修改.Size = new System.Drawing.Size(168, 50);
            this.btn儲存修改.TabIndex = 3;
            this.btn儲存修改.Text = "儲存修改";
            this.btn儲存修改.UseVisualStyleBackColor = true;
            this.btn儲存修改.Click += new System.EventHandler(this.btn儲存修改_Click);
            // 
            // btn選取商品圖片
            // 
            this.btn選取商品圖片.Location = new System.Drawing.Point(33, 44);
            this.btn選取商品圖片.Margin = new System.Windows.Forms.Padding(2);
            this.btn選取商品圖片.Name = "btn選取商品圖片";
            this.btn選取商品圖片.Size = new System.Drawing.Size(168, 50);
            this.btn選取商品圖片.TabIndex = 2;
            this.btn選取商品圖片.Text = "選取商品圖片";
            this.btn選取商品圖片.UseVisualStyleBackColor = true;
            this.btn選取商品圖片.Click += new System.EventHandler(this.btn選取商品圖片_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn清空欄位);
            this.groupBox2.Controls.Add(this.btn新增儲存修改);
            this.groupBox2.Controls.Add(this.btn新增選取商品圖片);
            this.groupBox2.Location = new System.Drawing.Point(149, 501);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 111);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "商品新增";
            this.groupBox2.Visible = false;
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.Location = new System.Drawing.Point(313, 44);
            this.btn清空欄位.Margin = new System.Windows.Forms.Padding(2);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(120, 50);
            this.btn清空欄位.TabIndex = 4;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = true;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // btn新增儲存修改
            // 
            this.btn新增儲存修改.Location = new System.Drawing.Point(184, 44);
            this.btn新增儲存修改.Margin = new System.Windows.Forms.Padding(2);
            this.btn新增儲存修改.Name = "btn新增儲存修改";
            this.btn新增儲存修改.Size = new System.Drawing.Size(120, 50);
            this.btn新增儲存修改.TabIndex = 3;
            this.btn新增儲存修改.Text = "儲存修改";
            this.btn新增儲存修改.UseVisualStyleBackColor = true;
            this.btn新增儲存修改.Click += new System.EventHandler(this.btn新增儲存修改_Click);
            // 
            // btn新增選取商品圖片
            // 
            this.btn新增選取商品圖片.Location = new System.Drawing.Point(5, 44);
            this.btn新增選取商品圖片.Margin = new System.Windows.Forms.Padding(2);
            this.btn新增選取商品圖片.Name = "btn新增選取商品圖片";
            this.btn新增選取商品圖片.Size = new System.Drawing.Size(168, 50);
            this.btn新增選取商品圖片.TabIndex = 2;
            this.btn新增選取商品圖片.Text = "選取商品圖片";
            this.btn新增選取商品圖片.UseVisualStyleBackColor = true;
            this.btn新增選取商品圖片.Click += new System.EventHandler(this.btn新增選取商品圖片_Click);
            // 
            // txt庫存
            // 
            this.txt庫存.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt庫存.Location = new System.Drawing.Point(123, 445);
            this.txt庫存.Margin = new System.Windows.Forms.Padding(2);
            this.txt庫存.Name = "txt庫存";
            this.txt庫存.Size = new System.Drawing.Size(164, 39);
            this.txt庫存.TabIndex = 27;
            this.txt庫存.Visible = false;
            // 
            // lbl庫存
            // 
            this.lbl庫存.AutoSize = true;
            this.lbl庫存.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl庫存.Location = new System.Drawing.Point(4, 447);
            this.lbl庫存.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl庫存.Name = "lbl庫存";
            this.lbl庫存.Size = new System.Drawing.Size(109, 30);
            this.lbl庫存.TabIndex = 26;
            this.lbl庫存.Text = "商品庫存";
            this.lbl庫存.Visible = false;
            // 
            // Form商品資料
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1056, 634);
            this.Controls.Add(this.txt庫存);
            this.Controls.Add(this.lbl庫存);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn加入購物車);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt份量);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt商品描述);
            this.Controls.Add(this.txt商品價格);
            this.Controls.Add(this.txt商品名稱);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Form商品資料";
            this.Text = "商品資料";
            this.Load += new System.EventHandler(this.Form商品資料_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt商品描述;
        private System.Windows.Forms.TextBox txt商品價格;
        private System.Windows.Forms.TextBox txt商品名稱;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txt份量;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn加入購物車;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn儲存修改;
        private System.Windows.Forms.Button btn選取商品圖片;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn新增儲存修改;
        private System.Windows.Forms.Button btn新增選取商品圖片;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.TextBox txt庫存;
        private System.Windows.Forms.Label lbl庫存;
    }
}