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

namespace WindowsFormsApp1
{
    public partial class Form商品管理 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<string> listProductName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listPid = new List<int>();
        List<int> liststock = new List<int>();
        List<int> listpprice = new List<int>();
        public Form商品管理()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form商品管理_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "mydb"; //資料庫名稱;
            scsb.IntegratedSecurity = true; //Windows 驗證
            GlobarVar.strDBConnectionString = scsb.ConnectionString;
            讀取商品();
            顯示商品();
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
            listViewProduct.Clear();

            listViewProduct.View = View.SmallIcon; // 設置視圖模式

            imageList.ImageSize = new Size(140, 140);
            listViewProduct.LargeImageList = imageList;
            listViewProduct.SmallImageList = imageList;

            for (int i = 0; i < listPid.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{listProductName[i]} \n{listPrice[i]}元 庫存{liststock[i]}份";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Tag = listPid[i];

                // 添加子項
                item.SubItems.Add(listProductName[i]);
                item.SubItems.Add($"{listPrice[i]}元");
                
                listViewProduct.Items.Add(item);
            }
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            string keyword = txt搜尋.Text;
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                listViewProduct.Clear();
                listViewProduct.View = View.SmallIcon;

                imageList.ImageSize = new Size(140, 140);
                listViewProduct.LargeImageList = imageList;
                listViewProduct.SmallImageList = imageList;

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

                        listViewProduct.Items.Add(item);
                    }
                }
            }
            else // 關鍵字為空白，顯示全部商品
            {
                顯示商品();
            }
        }

        private void listViewProduct_ItemActivate(object sender, EventArgs e)
        {
            GlobarVar.設計模式 = true;
            int selectedID = (int)listViewProduct.SelectedItems[0].Tag;
            Form商品資料 myDetailFomr = new Form商品資料(selectedID);
            myDetailFomr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobarVar.新增模式=true;
            int selectedID = 0;
            Form from商品資料 = new Form商品資料(selectedID);
            from商品資料.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //重新整理按鈕
            listViewProduct.Items.Clear();
            imageList.Images.Clear();

            // 清空列表
            listPid.Clear();
            listProductName.Clear();
            listPrice.Clear();
            liststock.Clear();

            讀取商品();
            顯示商品();
        }

        private void Form商品管理_Activated(object sender, EventArgs e)
        {
            GlobarVar.新增模式=false;
            GlobarVar.設計模式 = false;
        }
    }
}
