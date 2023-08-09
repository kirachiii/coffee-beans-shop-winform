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
    public partial class Form員工資料管理 : Form
    {
        public Form員工資料管理()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form員工資料管理_Load(object sender, EventArgs e)
        {
            // 設定 ComboBox 預設選擇項目
            comboBox.Items.Add("會員姓名");
            comboBox.Items.Add("會員電話");
            comboBox.Items.Add("會員電子郵件");
            comboBox.SelectedIndex = 0;
            讀取資料();
        }
        void 讀取資料()
        {
            string connectionString = "Data Source=.;Initial Catalog=mydb;Integrated Security=True";
            string query = "SELECT * FROM userinfo where user身分=1 or user身分=2";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgv.DataSource = table;
            }
        }
        void 清空()
        {
            txtid.Clear();
            txt姓名.Clear();
            txt電子郵件.Clear();
            txt電話.Clear();
            dtp生日.Value = DateTime.Now;
            rdof.Checked = false;
            rdom.Checked = false;
            rdo主管.Checked = false;
            rdo員工.Checked = false;
            rdo客人.Checked = false;
        }

        private void btn修改資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txtid.Text, out intID);
            if ((intID > 0) && (txt姓名.Text != "") && (txt電子郵件.Text != "") && (txt電話.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobarVar.strDBConnectionString);
                con.Open();
                string strSQL = "update userinfo set user姓名=@NewName, user電話=@NewPhone, user電子郵件=@email, user出生日期=@brithday, user性別=@mf, user身分=@identity where userid = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@email", txt電子郵件.Text);
                cmd.Parameters.AddWithValue("@brithday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@mf", rdom.Checked ? "M" : "F");
                cmd.Parameters.AddWithValue("@identity", rdo客人.Checked ? 0 : (rdo員工.Checked ? 1 : (rdo主管.Checked ? 2 : -1)));

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"會員資料修改成功,{rows}筆資料受影響");
            }
            else
            {
                MessageBox.Show("請將資料填寫完整再更改");
            }
            讀取資料();
        }

        private void btn刪除資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txtid.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(GlobarVar.strDBConnectionString);
                con.Open();
                string strSQL = "DELETE FROM User登入 WHERE userid = @DeleteID; DELETE FROM userinfo WHERE userid = @DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                清空();
                讀取資料();
                MessageBox.Show($"資料已刪除, {rows}筆資料受影響.");

            }
        }

        private void btn清空資料_Click(object sender, EventArgs e)
        {
            清空();
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            string columnName = "";
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    columnName = "userid";
                    break;
                case 1:
                    columnName = "user姓名";
                    break;
                case 2:
                    columnName = "user電話";
                    break;
                case 3:
                    columnName = "user電子郵件";
                    break;
            }

            string keyword = txt搜尋.Text;


            string searchColumn = comboBox.SelectedItem.ToString();
            string query = "";

            switch (searchColumn)
            {
                case "會員ID":
                    query = "SELECT * FROM userinfo WHERE userid LIKE @keyword AND (user身分 = 1 OR user身分 = 2)";
                    break;
                case "會員姓名":
                    query = "SELECT * FROM userinfo WHERE user姓名 LIKE @keyword AND (user身分 = 1 OR user身分 = 2)";
                    break;
                case "會員電話":
                    query = "SELECT * FROM userinfo WHERE user電話 LIKE @keyword AND (user身分 = 1 OR user身分 = 2)";
                    break;
                case "會員電子郵件":
                    query = "SELECT * FROM userinfo WHERE user電子郵件 LIKE @keyword AND (user身分 = 1 OR user身分 = 2)";
                    break;
                default:
                    MessageBox.Show("請選擇搜尋欄位");
                    return;
            }

            using (SqlConnection conn = new SqlConnection(GlobarVar.strDBConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgv.DataSource = dataTable;
            }

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt搜尋_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                清空();
                if (e.RowIndex >= 0) // 確認是否點擊到列資料
                {
                    DataGridViewRow row = dgv.Rows[e.RowIndex];
                    // 取得資料行的值
                    int id = Convert.ToInt32(row.Cells["userid"].Value);
                    string name = row.Cells["user姓名"].Value.ToString();
                    string phone = row.Cells["user電話"].Value.ToString();
                    string email = row.Cells["user電子郵件"].Value.ToString();
                    DateTime birthday = Convert.ToDateTime(row.Cells["user出生日期"].Value);
                    string gender = row.Cells["user性別"].Value.ToString();

                    // 轉換身分的值
                    int identity;
                    if (!int.TryParse(row.Cells["user身分"].Value.ToString(), out identity))
                    {
                        identity = -1; // 轉換失敗時設定為無效值
                    }

                    // 將值填入到其他控制項中
                    txtid.Text = id.ToString();
                    txt姓名.Text = name;
                    txt電話.Text = phone;
                    txt電子郵件.Text = email;
                    dtp生日.Value = birthday;
                    if (gender == "M")
                    {
                        rdom.Checked = true;
                    }
                    else
                    {
                        rdof.Checked = true;
                    }
                    switch (identity)
                    {
                        case 0:
                            rdo客人.Checked = true;
                            break;
                        case 1:
                            rdo員工.Checked = true;
                            break;
                        case 2:
                            rdo主管.Checked = true;
                            break;

                    }
                }
            }
            catch
            {

            }
        }
    }
}
