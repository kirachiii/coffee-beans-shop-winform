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
    public partial class Form訂單管理 : Form
    {
        public Form訂單管理()
        {
            InitializeComponent();
        }

        private void Form訂單管理_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
        private void LoadOrders()
        {
            using (SqlConnection con = new SqlConnection(GlobarVar.strDBConnectionString))
            {
                con.Open();

                // 使用 INNER JOIN 連接 orders 和 userinfo，選擇所需的欄位
                string query = @"SELECT orders.orderid, userinfo.user姓名, orders.orderdate, orders.orderprice
                         FROM orders
                         INNER JOIN userinfo ON orders.userid = userinfo.userid;";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // 綁定資料到 dataGridViewOrders
                dataGridView1.DataSource = dataTable;

                // 更改欄位名稱和寬度
                dataGridView1.Columns["orderid"].HeaderText = "訂單編號";
                dataGridView1.Columns["user姓名"].HeaderText = "下定用戶";
                dataGridView1.Columns["orderdate"].HeaderText = "下單日期";
                dataGridView1.Columns["orderprice"].HeaderText = "總金額";
                // 更改欄位寬度
                dataGridView1.Columns["orderdate"].Width = 250; // 指定寬度值

                // 其他欄位的名稱和寬度也可以在這裡設定
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int orderId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["orderid"].Value);
                Form訂單詳細資訊 orderDetailsForm = new Form訂單詳細資訊(orderId);
                orderDetailsForm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
