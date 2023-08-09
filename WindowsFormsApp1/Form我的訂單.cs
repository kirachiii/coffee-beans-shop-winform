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
    public partial class Form我的訂單 : Form
    {
        public Form我的訂單()
        {
            InitializeComponent();
        }

        private void Form我的訂單_Load(object sender, EventArgs e)
        {

            LoadMyOrders();
            // 更改欄位名稱
            dataGridView.Columns["orderid"].HeaderText = "訂單編號";
            dataGridView.Columns["user姓名"].HeaderText = "下定用戶";
            dataGridView.Columns["orderdate"].HeaderText = "下單日期";
            dataGridView.Columns["orderprice"].HeaderText = "總金額";
            // 更改欄位寬度
            dataGridView.Columns["orderdate"].Width = 250; // 指定寬度值
        }
        private void LoadMyOrders()
        {
            using (SqlConnection con = new SqlConnection(GlobarVar.strDBConnectionString))
            {
                con.Open();

                // 假設已經獲取了當前客戶的ID
                int customerId = GlobarVar.登入者ID;

                // 從訂單資料表中獲取與當前用戶相關的訂單資訊
                string selectOrdersSQL = @"
            SELECT orders.orderid, userinfo.user姓名, orders.orderdate, orders.orderprice
            FROM orders
            INNER JOIN userinfo ON orders.userid = userinfo.userid
            WHERE orders.userid = @CustomerId;";
                SqlCommand cmdSelectOrders = new SqlCommand(selectOrdersSQL, con);
                cmdSelectOrders.Parameters.AddWithValue("@CustomerId", customerId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmdSelectOrders);
                DataTable dtOrders = new DataTable();
                adapter.Fill(dtOrders);

                // 將資料綁定到dgvMyOrders
                dataGridView.DataSource = dtOrders;
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int orderId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["orderid"].Value);
                Form訂單詳細資訊 orderDetailsForm = new Form訂單詳細資訊(orderId);
                orderDetailsForm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
