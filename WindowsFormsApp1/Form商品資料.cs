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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace WindowsFormsApp1
{

    public partial class Form商品資料 : Form

    {
        bool is修改圖檔 = false;
        public List<CartItem> _cartItems = new List<CartItem>();

        string image_modify_name = "";
        private int selectID;
        public Form商品資料(int selectedID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            selectID = selectedID;
        }



        private void Form商品資料_Load(object sender, EventArgs e)
        {
            txt份量.Text = "1";
            lblID.Text = selectID.ToString();
            顯示商品詳細資訊();
            if (GlobarVar.設計模式 == true)
            {
                button1.Visible = false;
                button2.Visible = false;
                txt份量.Visible = false;
                btn加入購物車.Visible = false;
                groupBox1.Visible = true;
                txt商品名稱.ReadOnly = false;
                txt商品描述.ReadOnly=false;
                txt商品價格.ReadOnly=false;
                txt庫存.Visible=true;
                lbl庫存.Visible=true;
            }
            else if (GlobarVar.新增模式==true)
            {
                button1.Visible = false;
                button2.Visible = false;
                txt份量.Visible = false;
                btn加入購物車.Visible = false;
                groupBox2.Visible = true;
                txt商品名稱.ReadOnly = false;
                txt商品描述.ReadOnly = false;
                txt商品價格.ReadOnly = false;
                txt庫存.Visible = true;
                lbl庫存.Visible = true;
            }
            else
            {
                button1.Visible = true;
                button2.Visible = true;
                txt份量.Visible = true;
                btn加入購物車.Visible = true;
            }
        }
        private void 顯示商品詳細資訊()
        {
            if (selectID > 0)
            {
                SqlConnection con = new SqlConnection(GlobarVar.strDBConnectionString);
                con.Open();
                string strSQL = "SELECT * FROM productinfo INNER JOIN productimage ON productinfo.productID = productimage.productID WHERE productinfo.productID = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["productid"].ToString();
                    txt商品名稱.Text = reader["productname"].ToString();
                    txt商品價格.Text = reader["productprice"].ToString();
                    txt商品描述.Text = reader["productdescribe"].ToString();
                    txt庫存.Text = reader["productstock"].ToString();
                    image_modify_name = reader["image"].ToString();
                    string 圖檔完整路徑 = GlobarVar.image_dir + @"\" + image_modify_name;
                    pictureBox1.Image = Image.FromFile(圖檔完整路徑);
                }
                reader.Close();
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txt份量.Text);
            number--;
            if (number <= 1)
            {
                number = 1;
            }
            txt份量.Text = number.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int number = int.Parse(txt份量.Text);
            number++;
            txt份量.Text = number.ToString();
        }

        private void btn加入購物車_Click(object sender, EventArgs e)
        {
            // 取得數量
            int quantity = int.Parse(txt份量.Text);

            // 確認數量是否為正數
            if (quantity <= 0)
            {
                MessageBox.Show("數量必須為正整數。");
                return;
            }

            // 取得商品資訊
            int id = int.Parse(lblID.Text);
            string name = txt商品名稱.Text;
            decimal price = decimal.Parse(txt商品價格.Text);

            // 計算總價格
            decimal totalPrice = price * quantity;

            // 建立一個包含這些資訊的物件
            CartItem cartItem = new CartItem(id, name, price, quantity, totalPrice);

            // 將此物件加入至_cartItems列表中
             GlobarVar._cartItems.Add(cartItem);

            // 將此物件傳回主要表單
            this.DialogResult = DialogResult.OK;
            this.Tag = cartItem;
            MessageBox.Show("商品加入成功!");
        }
        public class CartItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public decimal TotalPrice { get; set; }

            public CartItem(int id, string name, decimal price, int quantity, decimal totalPrice)
            {
                Id = id;
                Name = name;
                Price = price;
                Quantity = quantity;
                TotalPrice = totalPrice;
            }
        }

        private void btn選取商品圖片_Click(object sender, EventArgs e)
        {
            修改圖片();
        }
        void 修改圖片()
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "檔案類型 (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png";

            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(f.FileName);//f.FileName完整檔案路徑
                string 檔案副檔名 = System.IO.Path.GetExtension(f.SafeFileName); //f.SafeFileName檔名
                Random myRnd = new Random();
                image_modify_name = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + 檔案副檔名;
                is修改圖檔 = true;
                Console.WriteLine(image_modify_name);
            }
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            儲存修改();
        }
        void 儲存修改()
        {
            //修改商品
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (txt商品描述.Text != "") && (pictureBox1.Image != null))
            {
                if (is修改圖檔 == true)
                {
                    pictureBox1.Image.Save(GlobarVar.image_dir + @"\" + image_modify_name);
                    is修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(GlobarVar.strDBConnectionString);
                con.Open();
                string strSQL = "UPDATE productinfo SET productname = @NewName,     productprice = @NewPrice,     productdescribe = @NewDesc , productstock=@stock WHERE productid = @SearchId UPDATE productimage \r\nSET image = @NewImage \r\nWHERE productid = @SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", selectID);
                cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewDesc", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewImage", image_modify_name);
                cmd.Parameters.AddWithValue("@stock", txt庫存.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("修改成功!");
            }
            else
            {
                MessageBox.Show("所有欄位必填!");
            }
        }

        private void btn新增選取商品圖片_Click(object sender, EventArgs e)
        {
            修改圖片();
        }

        private void btn新增儲存修改_Click(object sender, EventArgs e)
        {
            //新增商品
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (txt商品描述.Text != "") && (pictureBox1.Image != null))
            {
                if (is修改圖檔 == true)
                {
                    pictureBox1.Image.Save(GlobarVar.image_dir + @"\" + image_modify_name);
                    is修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(GlobarVar.strDBConnectionString);
                con.Open();
                // 先在 productinfo 資料表中插入一筆資料，然後取得插入的資料的自動產生的商品編號 (productID)
                string insertProductInfoSQL = "INSERT INTO productinfo (productname, productprice, productdescribe,productstock) VALUES (@NewName, @NewPrice, @NewDesc,@stock); SELECT SCOPE_IDENTITY();";
                SqlCommand cmdProductInfo = new SqlCommand(insertProductInfoSQL, con);
                cmdProductInfo.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmdProductInfo.Parameters.AddWithValue("@NewPrice", intPrice);
                cmdProductInfo.Parameters.AddWithValue("@NewDesc", txt商品描述.Text);
                cmdProductInfo.Parameters.AddWithValue("@stock", txt庫存.Text);
                int productID = Convert.ToInt32(cmdProductInfo.ExecuteScalar());

                // 接著在 productimage 資料表中插入一筆資料，並將商品編號 (productID) 帶入
                string insertProductImageSQL = "INSERT INTO productimage (productID, image) VALUES (@NewProductID, @NewImage);";
                SqlCommand cmdProductImage = new SqlCommand(insertProductImageSQL, con);
                cmdProductImage.Parameters.AddWithValue("@NewProductID", productID);
                cmdProductImage.Parameters.AddWithValue("@NewImage", image_modify_name);
                int rows = cmdProductImage.ExecuteNonQuery();

                con.Close();
                MessageBox.Show($"資料異動成功, 影響{rows}筆資料!");
            }
            else
            {
                MessageBox.Show("所有欄位必填!");
            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            txt商品名稱.Text = "";
            txt商品價格.Text = "";
            txt商品描述.Text = "";
        }
    }
}
