using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form登入 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=mydb;Integrated Security=True");
        public Form登入()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form登入_Load(object sender, EventArgs e)
        {
            txt密碼.PasswordChar = '*';

        }
        private void btn登入_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=mydb;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT UserId FROM User登入 WHERE UserName=@username AND Password=@password", con);
                cmd.Parameters.AddWithValue("@username", txt帳號.Text);
                cmd.Parameters.AddWithValue("@password", txt密碼.Text);
                var result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    MessageBox.Show("登入成功!");
                    int userId = Convert.ToInt32(result);
                    GlobarVar.登入者ID = userId;
                    (int role, string name) = GetUserRoleAndName(txt帳號.Text);
                    GlobarVar.username = name;

                    if (role == 1) // 員工
                    {
                        GlobarVar.身分確認 = 2;

                    }
                    else if (role == 2) // 主管
                    {
                        GlobarVar.身分確認 = 3;

                    }
                    else // 客戶
                    {
                        GlobarVar.身分確認 = 1;

                    }
                    this.Hide();

                }

            
                else
                {
                    MessageBox.Show("帳號或密碼錯誤，請重新輸入。");
                }
                con.Close();

            }
        }
        private (int, string) GetUserRoleAndName(string username)
        {
            int role = 0;
            string name = string.Empty;
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=mydb;Integrated Security=True"))
            {
                con.Open();
                SqlCommand getRoleCmd = new SqlCommand("SELECT u.user身分, u.user姓名 FROM User登入 AS l JOIN userinfo AS u ON l.UserId = u.UserId WHERE l.UserName = @username", con);
                getRoleCmd.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = getRoleCmd.ExecuteReader();
                if (reader.Read())
                {
                    role = Convert.ToInt32(reader["user身分"]);
                    name = reader["user姓名"].ToString();
                }
                con.Close();
            }
            return (role, name);
        }
    
        private void btn建立新帳號_Click(object sender, EventArgs e)
            {
                Form 新帳號form = new Form建立新帳號();
                新帳號form.ShowDialog();
            }

        private void chk顯示密碼_CheckedChanged(object sender, EventArgs e)
        {
            if (chk顯示密碼.Checked)
            {
                txt密碼.PasswordChar = '\0';

            }
            else
            {
                txt密碼.PasswordChar = '*';

            }
        }
    }
    }

