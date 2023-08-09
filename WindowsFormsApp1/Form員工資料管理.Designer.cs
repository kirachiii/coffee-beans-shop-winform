namespace WindowsFormsApp1
{
    partial class Form員工資料管理
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
            this.btn清空資料 = new System.Windows.Forms.Button();
            this.btn刪除資料 = new System.Windows.Forms.Button();
            this.btn修改資料 = new System.Windows.Forms.Button();
            this.btn刷新 = new System.Windows.Forms.Button();
            this.dtp生日 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo主管 = new System.Windows.Forms.RadioButton();
            this.rdo員工 = new System.Windows.Forms.RadioButton();
            this.rdo客人 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdof = new System.Windows.Forms.RadioButton();
            this.rdom = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt電子郵件 = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.txt搜尋 = new System.Windows.Forms.TextBox();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn清空資料
            // 
            this.btn清空資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn清空資料.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空資料.Location = new System.Drawing.Point(304, 586);
            this.btn清空資料.Name = "btn清空資料";
            this.btn清空資料.Size = new System.Drawing.Size(129, 48);
            this.btn清空資料.TabIndex = 37;
            this.btn清空資料.Text = "清空資料";
            this.btn清空資料.UseVisualStyleBackColor = true;
            this.btn清空資料.Click += new System.EventHandler(this.btn清空資料_Click);
            // 
            // btn刪除資料
            // 
            this.btn刪除資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn刪除資料.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除資料.Location = new System.Drawing.Point(161, 586);
            this.btn刪除資料.Name = "btn刪除資料";
            this.btn刪除資料.Size = new System.Drawing.Size(126, 48);
            this.btn刪除資料.TabIndex = 36;
            this.btn刪除資料.Text = "刪除資料";
            this.btn刪除資料.UseVisualStyleBackColor = true;
            this.btn刪除資料.Click += new System.EventHandler(this.btn刪除資料_Click);
            // 
            // btn修改資料
            // 
            this.btn修改資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn修改資料.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改資料.Location = new System.Drawing.Point(24, 586);
            this.btn修改資料.Name = "btn修改資料";
            this.btn修改資料.Size = new System.Drawing.Size(124, 48);
            this.btn修改資料.TabIndex = 35;
            this.btn修改資料.Text = "修改資料";
            this.btn修改資料.UseVisualStyleBackColor = true;
            this.btn修改資料.Click += new System.EventHandler(this.btn修改資料_Click);
            // 
            // btn刷新
            // 
            this.btn刷新.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn刷新.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刷新.Location = new System.Drawing.Point(24, 12);
            this.btn刷新.Name = "btn刷新";
            this.btn刷新.Size = new System.Drawing.Size(119, 48);
            this.btn刷新.TabIndex = 34;
            this.btn刷新.Text = "重新整理";
            this.btn刷新.UseVisualStyleBackColor = true;
            // 
            // dtp生日
            // 
            this.dtp生日.CalendarFont = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp生日.Location = new System.Drawing.Point(184, 376);
            this.dtp生日.Name = "dtp生日";
            this.dtp生日.Size = new System.Drawing.Size(211, 22);
            this.dtp生日.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo主管);
            this.groupBox2.Controls.Add(this.rdo員工);
            this.groupBox2.Controls.Add(this.rdo客人);
            this.groupBox2.Location = new System.Drawing.Point(119, 500);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 53);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // rdo主管
            // 
            this.rdo主管.AutoSize = true;
            this.rdo主管.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdo主管.Location = new System.Drawing.Point(199, 16);
            this.rdo主管.Name = "rdo主管";
            this.rdo主管.Size = new System.Drawing.Size(66, 28);
            this.rdo主管.TabIndex = 2;
            this.rdo主管.TabStop = true;
            this.rdo主管.Text = "主管";
            this.rdo主管.UseVisualStyleBackColor = true;
            // 
            // rdo員工
            // 
            this.rdo員工.AutoSize = true;
            this.rdo員工.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdo員工.Location = new System.Drawing.Point(108, 16);
            this.rdo員工.Name = "rdo員工";
            this.rdo員工.Size = new System.Drawing.Size(66, 28);
            this.rdo員工.TabIndex = 1;
            this.rdo員工.TabStop = true;
            this.rdo員工.Text = "員工";
            this.rdo員工.UseVisualStyleBackColor = true;
            // 
            // rdo客人
            // 
            this.rdo客人.AutoSize = true;
            this.rdo客人.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdo客人.Location = new System.Drawing.Point(24, 16);
            this.rdo客人.Name = "rdo客人";
            this.rdo客人.Size = new System.Drawing.Size(66, 28);
            this.rdo客人.TabIndex = 0;
            this.rdo客人.TabStop = true;
            this.rdo客人.Text = "客人";
            this.rdo客人.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdof);
            this.groupBox1.Controls.Add(this.rdom);
            this.groupBox1.Location = new System.Drawing.Point(187, 430);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 64);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // rdof
            // 
            this.rdof.AutoSize = true;
            this.rdof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(138)))));
            this.rdof.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdof.Location = new System.Drawing.Point(117, 18);
            this.rdof.Name = "rdof";
            this.rdof.Size = new System.Drawing.Size(66, 28);
            this.rdof.TabIndex = 1;
            this.rdof.TabStop = true;
            this.rdof.Text = "女性";
            this.rdof.UseVisualStyleBackColor = false;
            // 
            // rdom
            // 
            this.rdom.AutoSize = true;
            this.rdom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(138)))));
            this.rdom.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdom.Location = new System.Drawing.Point(30, 18);
            this.rdom.Name = "rdom";
            this.rdom.Size = new System.Drawing.Size(66, 28);
            this.rdom.TabIndex = 0;
            this.rdom.TabStop = true;
            this.rdom.Text = "男性";
            this.rdom.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(24, 514);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 30);
            this.label7.TabIndex = 30;
            this.label7.Text = "身分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(24, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 30);
            this.label6.TabIndex = 29;
            this.label6.Text = "會員性別";
            // 
            // txt電子郵件
            // 
            this.txt電子郵件.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電子郵件.Location = new System.Drawing.Point(187, 297);
            this.txt電子郵件.Name = "txt電子郵件";
            this.txt電子郵件.Size = new System.Drawing.Size(208, 39);
            this.txt電子郵件.TabIndex = 28;
            // 
            // txt電話
            // 
            this.txt電話.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電話.Location = new System.Drawing.Point(187, 224);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(208, 39);
            this.txt電話.TabIndex = 27;
            // 
            // txt姓名
            // 
            this.txt姓名.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt姓名.Location = new System.Drawing.Point(187, 150);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(208, 39);
            this.txt姓名.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(24, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 30);
            this.label5.TabIndex = 25;
            this.label5.Text = "會員生日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(24, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 30);
            this.label4.TabIndex = 24;
            this.label4.Text = "會員電子郵件";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(24, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 23;
            this.label3.Text = "會員電話";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(24, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "會員姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(24, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "會員id";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtid.Location = new System.Drawing.Point(187, 81);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(208, 39);
            this.txtid.TabIndex = 20;
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(138)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(451, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(701, 622);
            this.dgv.TabIndex = 38;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(493, 658);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 30);
            this.label8.TabIndex = 42;
            this.label8.Text = "搜尋條件";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(608, 655);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(191, 38);
            this.comboBox.TabIndex = 41;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // txt搜尋
            // 
            this.txt搜尋.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt搜尋.Location = new System.Drawing.Point(868, 654);
            this.txt搜尋.Name = "txt搜尋";
            this.txt搜尋.Size = new System.Drawing.Size(169, 39);
            this.txt搜尋.TabIndex = 40;
            this.txt搜尋.TextChanged += new System.EventHandler(this.txt搜尋_TextChanged);
            // 
            // btn搜尋
            // 
            this.btn搜尋.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.Location = new System.Drawing.Point(1064, 648);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(87, 48);
            this.btn搜尋.TabIndex = 39;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = true;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // Form員工資料管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1179, 714);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.txt搜尋);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn清空資料);
            this.Controls.Add(this.btn刪除資料);
            this.Controls.Add(this.btn修改資料);
            this.Controls.Add(this.btn刷新);
            this.Controls.Add(this.dtp生日);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt電子郵件);
            this.Controls.Add(this.txt電話);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Name = "Form員工資料管理";
            this.Text = "員工資料管理";
            this.Load += new System.EventHandler(this.Form員工資料管理_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn清空資料;
        private System.Windows.Forms.Button btn刪除資料;
        private System.Windows.Forms.Button btn修改資料;
        private System.Windows.Forms.Button btn刷新;
        private System.Windows.Forms.DateTimePicker dtp生日;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo主管;
        private System.Windows.Forms.RadioButton rdo員工;
        private System.Windows.Forms.RadioButton rdo客人;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdof;
        private System.Windows.Forms.RadioButton rdom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt電子郵件;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox txt搜尋;
        private System.Windows.Forms.Button btn搜尋;
    }
}