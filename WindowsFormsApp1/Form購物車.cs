using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Form商品資料;

namespace WindowsFormsApp1
{
    
    public partial class Form購物車 : Form
    {

        private decimal _totalPrice = 0;
        public Form購物車()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form購物車_Load(object sender, EventArgs e)
        {

            // 設定DataGridView的列標題
            dgvCart.Columns.Add("ID", "商品編號");
            dgvCart.Columns.Add("Name", "商品名稱");
            dgvCart.Columns.Add("Price", "商品價格");
            dgvCart.Columns.Add("Quantity", "數量");
            dgvCart.Columns.Add("TotalPrice", "總價格");
            // 設定第一個欄位的寬度為100

            dgvCart.Columns[1].Width = 400;
            dgvCart.Columns[2].Width = 100;
            dgvCart.Columns[3].Width = 100;
            dgvCart.Columns[4].Width = 100;
            // 將儲存在Tag中的資料轉換為CartItem物件
            if (this.Tag != null && this.Tag is CartItem)
            {
                CartItem cartItem = this.Tag as CartItem;

                // 將資料添加到_cartItems集合中
                GlobarVar._cartItems.Add(cartItem);

                // 將資料添加到DataGridView
                dgvCart.Rows.Add(cartItem.Id, cartItem.Name, cartItem.Price, cartItem.Quantity, cartItem.TotalPrice);
            }
            // 將_cartItems列表中的資料加入至DataGridView中
            foreach (CartItem cartItem in GlobarVar._cartItems)
            {
                dgvCart.Rows.Add(cartItem.Id, cartItem.Name, cartItem.Price, cartItem.Quantity, cartItem.TotalPrice);
            }
            // 計算總價格
            foreach (DataGridViewRow row in dgvCart.Rows)
            {

                decimal totalPrice = (row.Cells["TotalPrice"].Value as decimal?) ?? 0m;
                _totalPrice += totalPrice;
            }

            // 顯示總價格
            lbl總價格.Text = _totalPrice.ToString();
        }

        private void btn關閉表單_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void btn移除所選項目_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCart.SelectedRows)
            {
                dgvCart.Rows.Remove(row);
            }
        }

        private void btn清空購物車_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要全部移除嗎？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                dgvCart.Rows.Clear();
                lbl總價格.Text = "0";
            }
        }

        private void btn確認購買下單_Click(object sender, EventArgs e)
        {

            // 假設已經獲取了當前客戶的ID
            int customerId = GlobarVar.登入者ID;

            using (SqlConnection con = new SqlConnection(GlobarVar.strDBConnectionString))
            {
                con.Open();

                // 在訂單資料表中插入一條訂單記錄並獲取order_id
                string insertOrderSQL = "INSERT INTO orders (userid, orderdate, orderprice) OUTPUT INSERTED.orderid VALUES (@CustomerId, @OrderDate, @TotalPrice);";
                SqlCommand cmdOrder = new SqlCommand(insertOrderSQL, con);
                cmdOrder.Parameters.AddWithValue("@CustomerId", customerId);
                cmdOrder.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                cmdOrder.Parameters.AddWithValue("@TotalPrice", _totalPrice);

                int orderId = (int)cmdOrder.ExecuteScalar();
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (row.Cells["ID"].Value == null || row.Cells["ID"].Value == DBNull.Value)
                    {
                        continue;
                    }

                    int productId = Convert.ToInt32(row.Cells["ID"].Value);

                    if (!ProductIdExists(productId))
                    {
                        MessageBox.Show($"商品編號 {productId} 不存在。請檢查購物車中的商品。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 其他插入訂單明細的程式碼
                }
                // 在訂單明細資料表中插入購物車中的商品
                string insertOrderDetailSQL = "INSERT INTO order_detail (orderid, productid, product_name, product_price, quantity, total_price) VALUES (@OrderId, @ProductId, @ProductName, @ProductPrice, @Quantity, @TotalPrice);";
                SqlCommand cmdOrderDetail = new SqlCommand(insertOrderDetailSQL, con);

                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    int productId = Convert.ToInt32(row.Cells["ID"].Value);
                    string productName = row.Cells["Name"].Value?.ToString() ?? "";
                    decimal productPrice = Convert.ToDecimal(row.Cells["Price"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal totalPrice = Convert.ToDecimal(row.Cells["TotalPrice"].Value);

                    cmdOrderDetail.Parameters.Clear();
                    cmdOrderDetail.Parameters.AddWithValue("@OrderId", orderId);
                    cmdOrderDetail.Parameters.AddWithValue("@ProductId", productId);
                    cmdOrderDetail.Parameters.AddWithValue("@ProductName", productName);
                    cmdOrderDetail.Parameters.AddWithValue("@ProductPrice", productPrice);
                    cmdOrderDetail.Parameters.AddWithValue("@Quantity", quantity);
                    cmdOrderDetail.Parameters.AddWithValue("@TotalPrice", totalPrice);

                    cmdOrderDetail.ExecuteNonQuery();
                }
            }

            // 清空購物車並更新顯示總價格
            dgvCart.Rows.Clear();
            lbl總價格.Text = "0";

            MessageBox.Show("訂單已成功提交！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        private bool ProductIdExists(int productId)
        {
            using (SqlConnection con = new SqlConnection(GlobarVar.strDBConnectionString))
            {
                con.Open();

                string checkProductExistsSql = "SELECT COUNT(*) FROM productinfo WHERE productID = @ProductId";
                SqlCommand cmdCheckProduct = new SqlCommand(checkProductExistsSql, con);
                cmdCheckProduct.Parameters.AddWithValue("@ProductId", productId);

                int count = (int)cmdCheckProduct.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
