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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void test1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btn訂購單Menu_Click(object sender, EventArgs e)
        {
            Form from訂購單 = new Form訂購單2();
            from訂購單.Show();
            this.Hide();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            Form form登入 = new Form登入();
            form登入.ShowDialog();
        }

        private void user登入BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void btn會員資料管理_Click(object sender, EventArgs e)
        {
            Form form會員資料 = new Form會員資料();
            form會員資料.ShowDialog();
        }

        private void btn商品管理_Click(object sender, EventArgs e)
        {
            Form form商品管理 = new Form商品管理();
            form商品管理.ShowDialog();

        }

        private void btn員工資料管理_Click(object sender, EventArgs e)
        {
            Form form員工管理 = new Form員工資料管理();
            form員工管理.ShowDialog();
        }

        private void btn訂單管理_Click(object sender, EventArgs e)
        {
            Form Form訂單管理 = new Form訂單管理();
            Form訂單管理.ShowDialog();
        }
    }
}
