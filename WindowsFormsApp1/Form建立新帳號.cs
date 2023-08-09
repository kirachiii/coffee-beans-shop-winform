using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace WindowsFormsApp1
{
    public partial class Form建立新帳號 : Form
    {
        
        private string connectionString = "Data Source=.;Initial Catalog=mydb;Integrated Security=True";
        public Form建立新帳號()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form建立新帳號_Load(object sender, EventArgs e)
        {
            cboGender.Items.Add("男性");
            cboGender.Items.Add("女性");
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 檢查必填欄位是否有填寫
            if (string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtPhone.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtConfirmPassword.Text) ||
                cboGender.SelectedIndex < 0)
            {
                MessageBox.Show("請填寫所有必填欄位！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 檢查兩次輸入的密碼是否相同
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("兩次輸入的密碼不相同！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 將資料插入 userinfo 資料表
            string connectionString = "Data Source=.;Initial Catalog=mydb;Integrated Security=True";
            string sql = "INSERT INTO userinfo (user姓名, user電話, user電子郵件, user出生日期, user性別) OUTPUT INSERTED.userid VALUES (@name, @phone, @email, @birthdate, @gender)";
            int userId;
            string gender = "";
            if (cboGender.SelectedIndex.ToString() == "男性")
            {
                gender = "M";
            }
            else
            {
                gender = "F";
            }
             
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@name", txtName.Text);
                command.Parameters.AddWithValue("@phone", txtPhone.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@birthdate", dtpBirthdate.Value);
                command.Parameters.AddWithValue("@gender", gender);
                connection.Open();
                userId = (int)command.ExecuteScalar();
            }

            // 將帳號與密碼插入 User登入 資料表
            sql = "INSERT INTO User登入 ( userid, UserName, Password) VALUES ( @userid, @username, @password)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@userid", userId);
                command.Parameters.AddWithValue("@username", txtUsername.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
            }

            MessageBox.Show("註冊完畢！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }





        private void chk顯示密碼_CheckedChanged(object sender, EventArgs e)
        {
            if (chk顯示密碼.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

