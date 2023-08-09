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
    public partial class Form修改個人資料 : Form
    {
        private int userID;
        private string userg = "";
        public Form修改個人資料()
        {
            InitializeComponent();
        }

        private void Form修改個人資料_Load(object sender, EventArgs e)
        {
            userID = GlobarVar.登入者ID;

            // 讀取使用者資料，並顯示在對應的控制項上
            SqlConnection conn = new SqlConnection(GlobarVar.strDBConnectionString);
            string sql = "SELECT * FROM userinfo WHERE userID = @userID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userID", userID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt姓名.Text = reader["user姓名"].ToString();
                txt電話.Text = reader["user電話"].ToString();
                txt電子郵件.Text = reader["user電子郵件"].ToString();
                dtp生日.Value = (DateTime)reader["user出生日期"];
                string gender = reader["user性別"].ToString();
                if (gender == "M")
                {
                    rdom.Checked = true;

                }
                else if (gender == "F")
                {
                    rdof.Checked = true;

                }
            }
            reader.Close();
            conn.Close();
        }

        private void btn儲存_Click(object sender, EventArgs e)
        {
            int userID = GlobarVar.登入者ID;
            if (rdom.Checked)
            {
                userg = "M";
            }
            else { userg = "F"; }

            // 更新使用者資料
            SqlConnection conn = new SqlConnection(GlobarVar.strDBConnectionString);
            string sql = "UPDATE userinfo SET user姓名 = @name, user電話 = @phone, user電子郵件 = @email, "
                + "user出生日期 = @birthday, user性別 = @gender WHERE userID = @userID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", txt姓名.Text);
            cmd.Parameters.AddWithValue("@phone", txt電話.Text);
            cmd.Parameters.AddWithValue("@email", txt電子郵件.Text);
            cmd.Parameters.AddWithValue("@birthday", dtp生日.Value);
            cmd.Parameters.AddWithValue("@gender", userg);
            cmd.Parameters.AddWithValue("@userID", userID);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show($"已更新 {rows} 筆資料。");
        }
    }
}
