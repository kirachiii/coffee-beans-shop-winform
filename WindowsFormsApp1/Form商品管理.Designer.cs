namespace WindowsFormsApp1
{
    partial class Form商品管理
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form商品管理));
            this.mydb = new WindowsFormsApp1.mydb();
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.txt搜尋 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mydb)).BeginInit();
            this.SuspendLayout();
            // 
            // mydb
            // 
            this.mydb.DataSetName = "mydb";
            this.mydb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listViewProduct
            // 
            this.listViewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(138)))));
            this.listViewProduct.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(12, 73);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(840, 490);
            this.listViewProduct.TabIndex = 0;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.ItemActivate += new System.EventHandler(this.listViewProduct_ItemActivate);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(904, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "新增商品";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(904, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "刪除商品";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(904, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "重新整理";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn搜尋
            // 
            this.btn搜尋.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn搜尋.BackgroundImage")));
            this.btn搜尋.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn搜尋.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.btn搜尋.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.btn搜尋.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.btn搜尋.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn搜尋.Location = new System.Drawing.Point(299, 12);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(40, 40);
            this.btn搜尋.TabIndex = 14;
            this.btn搜尋.UseVisualStyleBackColor = true;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // txt搜尋
            // 
            this.txt搜尋.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt搜尋.Location = new System.Drawing.Point(85, 12);
            this.txt搜尋.Name = "txt搜尋";
            this.txt搜尋.Size = new System.Drawing.Size(208, 39);
            this.txt搜尋.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "搜尋";
            // 
            // Form商品管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1108, 606);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.txt搜尋);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewProduct);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Form商品管理";
            this.Text = "商品管理";
            this.Activated += new System.EventHandler(this.Form商品管理_Activated);
            this.Load += new System.EventHandler(this.Form商品管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mydb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mydb mydb;
        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.TextBox txt搜尋;
        private System.Windows.Forms.Label label2;
    }
}