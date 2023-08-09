namespace WindowsFormsApp1
{
    partial class Form訂購單2
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
            System.Windows.Forms.Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form訂購單2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.登入註冊 = new System.Windows.Forms.Button();
            this.btn進入系統管理 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt搜尋 = new System.Windows.Forms.TextBox();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.btn修改個人資料 = new System.Windows.Forms.Button();
            this.btn查看我的訂單 = new System.Windows.Forms.Button();
            this.btn登出 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            button1.Location = new System.Drawing.Point(1048, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(91, 49);
            button1.TabIndex = 5;
            button1.Text = "購物車";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.listViewProducts);
            this.panel1.Location = new System.Drawing.Point(232, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 610);
            this.panel1.TabIndex = 3;
            // 
            // listViewProducts
            // 
            this.listViewProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(138)))));
            this.listViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewProducts.Font = new System.Drawing.Font("微軟正黑體", 16.25F);
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(71, 15);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(859, 496);
            this.listViewProducts.TabIndex = 0;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.ItemActivate += new System.EventHandler(this.listViewProducts_ItemActivate);
            this.listViewProducts.SelectedIndexChanged += new System.EventHandler(this.listViewProducts_SelectedIndexChanged);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(63, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "訪客";
            // 
            // 登入註冊
            // 
            this.登入註冊.Cursor = System.Windows.Forms.Cursors.Default;
            this.登入註冊.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.登入註冊.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.登入註冊.ForeColor = System.Drawing.SystemColors.ControlText;
            this.登入註冊.Location = new System.Drawing.Point(873, 12);
            this.登入註冊.Name = "登入註冊";
            this.登入註冊.Size = new System.Drawing.Size(146, 49);
            this.登入註冊.TabIndex = 7;
            this.登入註冊.Text = "登入/註冊";
            this.登入註冊.UseVisualStyleBackColor = true;
            this.登入註冊.Click += new System.EventHandler(this.登入註冊_Click);
            // 
            // btn進入系統管理
            // 
            this.btn進入系統管理.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn進入系統管理.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn進入系統管理.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.btn進入系統管理.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn進入系統管理.Location = new System.Drawing.Point(12, 522);
            this.btn進入系統管理.Name = "btn進入系統管理";
            this.btn進入系統管理.Size = new System.Drawing.Size(184, 67);
            this.btn進入系統管理.TabIndex = 8;
            this.btn進入系統管理.Text = "進入系統管理";
            this.btn進入系統管理.UseVisualStyleBackColor = true;
            this.btn進入系統管理.Visible = false;
            this.btn進入系統管理.Click += new System.EventHandler(this.btn進入系統管理_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(236, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "搜尋";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt搜尋
            // 
            this.txt搜尋.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt搜尋.Location = new System.Drawing.Point(303, 25);
            this.txt搜尋.Name = "txt搜尋";
            this.txt搜尋.Size = new System.Drawing.Size(208, 39);
            this.txt搜尋.TabIndex = 10;
            this.txt搜尋.TextChanged += new System.EventHandler(this.txt搜尋_TextChanged);
            // 
            // btn搜尋
            // 
            this.btn搜尋.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn搜尋.BackgroundImage")));
            this.btn搜尋.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn搜尋.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.btn搜尋.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.btn搜尋.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.btn搜尋.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn搜尋.Location = new System.Drawing.Point(517, 25);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(40, 40);
            this.btn搜尋.TabIndex = 11;
            this.btn搜尋.UseVisualStyleBackColor = true;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // btn修改個人資料
            // 
            this.btn修改個人資料.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn修改個人資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn修改個人資料.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.btn修改個人資料.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn修改個人資料.Location = new System.Drawing.Point(12, 423);
            this.btn修改個人資料.Name = "btn修改個人資料";
            this.btn修改個人資料.Size = new System.Drawing.Size(184, 49);
            this.btn修改個人資料.TabIndex = 12;
            this.btn修改個人資料.Text = "修改個人資料";
            this.btn修改個人資料.UseVisualStyleBackColor = true;
            this.btn修改個人資料.Visible = false;
            this.btn修改個人資料.Click += new System.EventHandler(this.btn修改個人資料_Click);
            // 
            // btn查看我的訂單
            // 
            this.btn查看我的訂單.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn查看我的訂單.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn查看我的訂單.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.btn查看我的訂單.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn查看我的訂單.Location = new System.Drawing.Point(12, 320);
            this.btn查看我的訂單.Name = "btn查看我的訂單";
            this.btn查看我的訂單.Size = new System.Drawing.Size(184, 49);
            this.btn查看我的訂單.TabIndex = 13;
            this.btn查看我的訂單.Text = "查看我的訂單";
            this.btn查看我的訂單.UseVisualStyleBackColor = true;
            this.btn查看我的訂單.Visible = false;
            this.btn查看我的訂單.Click += new System.EventHandler(this.btn查看我的訂單_Click);
            // 
            // btn登出
            // 
            this.btn登出.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn登出.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn登出.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.btn登出.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn登出.Location = new System.Drawing.Point(915, 12);
            this.btn登出.Name = "btn登出";
            this.btn登出.Size = new System.Drawing.Size(104, 49);
            this.btn登出.TabIndex = 14;
            this.btn登出.Text = "登出";
            this.btn登出.UseVisualStyleBackColor = true;
            this.btn登出.Visible = false;
            this.btn登出.Click += new System.EventHandler(this.btn登出_Click);
            // 
            // Form訂購單2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1151, 688);
            this.Controls.Add(this.btn登出);
            this.Controls.Add(this.btn查看我的訂單);
            this.Controls.Add(this.btn修改個人資料);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.txt搜尋);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn進入系統管理);
            this.Controls.Add(this.登入註冊);
            this.Controls.Add(this.label1);
            this.Controls.Add(button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form訂購單2";
            this.Text = "咖啡豆販賣平台";
            this.Activated += new System.EventHandler(this.Form訂購單2_Activated);
            this.Load += new System.EventHandler(this.Form訂購單2_Load);
            this.Enter += new System.EventHandler(this.Form訂購單2_Enter);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 登入註冊;
        private System.Windows.Forms.Button btn進入系統管理;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt搜尋;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.Button btn修改個人資料;
        private System.Windows.Forms.Button btn查看我的訂單;
        private System.Windows.Forms.Button btn登出;
    }
}