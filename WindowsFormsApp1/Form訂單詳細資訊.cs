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
    public partial class Form訂單詳細資訊 : Form
    {
        private int _orderId;
        public Form訂單詳細資訊(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;

        }

        private void Form訂單詳細資訊_Load(object sender, EventArgs e)
        {
            LoadOrderDetails();
            // 更改欄位名稱
            dataGridView1.Columns["orderdetailid"].HeaderText = "訂單詳細編號";
            dataGridView1.Columns["orderid"].HeaderText = "訂單編號";
            dataGridView1.Columns["productid"].HeaderText = "產品編號";
            dataGridView1.Columns["product_name"].HeaderText = "產品名稱";
            dataGridView1.Columns["product_price"].HeaderText = "單品金額";
            dataGridView1.Columns["quantity"].HeaderText = "數量";
            dataGridView1.Columns["total_price"].HeaderText = "總金額";
            // 更改欄位寬度
            dataGridView1.Columns["product_name"].Width = 500; // 指定寬度值
        }
        private void LoadOrderDetails()
        {
            using (SqlConnection con = new SqlConnection(GlobarVar.strDBConnectionString))
            {
                con.Open();

                // 從訂單明細資料表中獲取與訂單ID相關的訂單詳細資訊
                string selectOrderDetailsSQL = "SELECT * FROM order_detail WHERE orderid = @OrderId";
                SqlCommand cmdSelectOrderDetails = new SqlCommand(selectOrderDetailsSQL, con);
                cmdSelectOrderDetails.Parameters.AddWithValue("@OrderId", _orderId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmdSelectOrderDetails);
                DataTable dtOrderDetails = new DataTable();
                adapter.Fill(dtOrderDetails);

                // 將資料綁定到dgvOrderDetails
                dataGridView1.DataSource = dtOrderDetails;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
