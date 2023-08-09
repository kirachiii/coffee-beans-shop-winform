namespace WindowsFormsApp1
{
    partial class form訂購單
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
            System.Windows.Forms.Button btn登入;
            System.Windows.Forms.Button button1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxQuantity = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            btn登入 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn登入
            // 
            btn登入.BackColor = System.Drawing.Color.Transparent;
            btn登入.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn登入.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            btn登入.Location = new System.Drawing.Point(683, 24);
            btn登入.Name = "btn登入";
            btn登入.Size = new System.Drawing.Size(156, 49);
            btn登入.TabIndex = 1;
            btn登入.Text = "登入/註冊";
            btn登入.UseVisualStyleBackColor = false;
            btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            button1.Location = new System.Drawing.Point(845, 24);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(91, 49);
            button1.TabIndex = 2;
            button1.Text = "購物車";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.comboBoxQuantity);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.listViewProducts);
            this.panel1.Location = new System.Drawing.Point(-5, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 610);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxQuantity
            // 
            this.comboBoxQuantity.FormattingEnabled = true;
            this.comboBoxQuantity.Location = new System.Drawing.Point(79, 512);
            this.comboBoxQuantity.Name = "comboBoxQuantity";
            this.comboBoxQuantity.Size = new System.Drawing.Size(121, 20);
            this.comboBoxQuantity.TabIndex = 3;
            this.comboBoxQuantity.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuantity_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(801, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listViewProducts
            // 
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(17, 3);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(921, 448);
            this.listViewProducts.TabIndex = 0;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // form訂購單
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(945, 704);
            this.Controls.Add(button1);
            this.Controls.Add(btn登入);
            this.Controls.Add(this.panel1);
            this.Name = "form訂購單";
            this.Text = "from訂購單";
            this.Load += new System.EventHandler(this.from訂購單_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ComboBox comboBoxQuantity;
    }
}