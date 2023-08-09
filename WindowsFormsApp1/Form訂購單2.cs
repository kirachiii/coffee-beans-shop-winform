using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form訂購單2 : Form
    {
        public int selectID = 0;
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<string> listProductName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listPid = new List<int>();
        List<int> liststock = new List<int>();
        List<int> listpprice = new List<int>();
        public Form訂購單2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form訂購單2_Load(object sender, EventArgs e)
        {

            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "mydb"; //資料庫名稱;
            scsb.IntegratedSecurity = true; //Windows 驗證
            GlobarVar.strDBConnectionString = scsb.ConnectionString;
            讀取商品();
            顯示商品();


        }
        void SetUsername()
        {
            if (!string.IsNullOrEmpty(GlobarVar.username))
            {
                label1.Text = "";
                label1.Text = $"{GlobarVar.username} - {label1.Text}";
            }
        }
        void 讀取商品()
        {
            
            SqlConnection con = new SqlConnection(GlobarVar.strDBConnectionString);
            con.Open();
            string strSQL = "SELECT * \r\nFROM productinfo pi \r\nLEFT　JOIN productimage pim ON pi.productid = pim.productid;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;

            while (reader.Read() == true)
            {
                listPid.Add((int)reader["productid"]);
                listProductName.Add((string)reader["productname"]);
                listPrice.Add((int)reader["productprice"]);
                liststock.Add((int)reader["productstock"]);
                
                
                string image_name = (string)reader["image"];
                string 完整圖檔路徑 = $"{GlobarVar.image_dir}\\{image_name}";
                Image img產品圖檔 = Image.FromFile(完整圖檔路徑);
                imageList.Images.Add(img產品圖檔);
                count += 1;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆資料");
        }
        void 顯示商品()
        {
            listViewProducts.Clear();

            listViewProducts.View = View.LargeIcon; // 設置視圖模式
            
            imageList.ImageSize = new Size(200, 200);
            listViewProducts.LargeImageList = imageList;
            listViewProducts.SmallImageList = imageList;

            for (int i = 0; i < listPid.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{listProductName[i]} \n{listPrice[i]}元";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Tag = listPid[i];

                // 添加子項
                item.SubItems.Add(listProductName[i]);
                item.SubItems.Add($"{listPrice[i]}元");

                listViewProducts.Items.Add(item);
            }
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            Form from登入 = new Form登入();
            from登入.ShowDialog();

            
        }

        private void listViewProducts_ItemActivate(object sender, EventArgs e)
        {
            int selectedID = (int)listViewProducts.SelectedItems[0].Tag;
            Form商品資料 myDetailFomr = new Form商品資料(selectedID);
            myDetailFomr.ShowDialog();
        }
    

        private void Form訂購單2_Enter(object sender, EventArgs e)
        {

        }

        private void Form訂購單2_Activated(object sender, EventArgs e)
        {
            SetUsername();
            if (GlobarVar.身分確認 == 1)
            {
                label1.Text += "客人";
                登入註冊.Visible = false;
                btn修改個人資料.Visible = true;
                btn查看我的訂單.Visible = true;
                btn登出.Visible=true;
            }
            else if (GlobarVar.身分確認 == 2)
            {
               label1.Text += "員工";
                登入註冊.Visible = false;
                btn進入系統管理.Visible = true;
                btn登出.Visible = true;
            }
            else if (GlobarVar.身分確認 == 3)
            {
                label1.Text += "主管";
                登入註冊.Visible = false;
                btn進入系統管理.Visible = true;
                btn登出.Visible = true;
            }
            else
            {
                btn登出.Visible = false;
            }


        }


        private void 登入註冊_Click(object sender, EventArgs e)
        {
            Form from登入 = new Form登入();
            from登入.ShowDialog();
        }

        private void btn進入系統管理_Click(object sender, EventArgs e)
        {
            Form from系統 = new Form1();
            from系統.Show();
            this.Hide();
        }

        private void txt搜尋_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            string keyword = txt搜尋.Text;
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                listViewProducts.Clear();
                listViewProducts.View = View.LargeIcon;

                
                imageList.ImageSize = new Size(200, 200);
                listViewProducts.LargeImageList = imageList;
                listViewProducts.SmallImageList = imageList;

                for (int i = 0; i < listPid.Count; i++)
                {
                    if (listProductName[i].Contains(keyword)) // 如果商品名稱包含關鍵字
                    {
                        ListViewItem item = new ListViewItem();
                        item.ImageIndex = i;
                        item.Text = $"{listProductName[i]} \n{listPrice[i]}元";
                        item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                        item.Tag = listPid[i];

                        // 添加子項
                        item.SubItems.Add(listProductName[i]);
                        item.SubItems.Add($"{listPrice[i]}元");

                        listViewProducts.Items.Add(item);
                    }
                }
            }
            else // 關鍵字為空白，顯示全部商品
            {
                顯示商品();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form from購物車 = new Form購物車();
            from購物車.ShowDialog();
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn修改個人資料_Click(object sender, EventArgs e)
        {
            Form from修改資料 = new Form修改個人資料();
            from修改資料.ShowDialog();
        }

        private void btn查看我的訂單_Click(object sender, EventArgs e)
        {
            Form Form我的訂單 = new Form我的訂單();
            Form我的訂單.ShowDialog();
        }

        private void btn登出_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show  ("已成功登出!");
            登入註冊.Visible = true;
            label1.Text = "訪客";
            GlobarVar.身分確認 = 0;
            GlobarVar.username = "訪客";
            btn登出.Visible = false;
            btn登出.Visible = false;
        }
    }
}
