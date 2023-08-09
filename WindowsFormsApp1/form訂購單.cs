using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{

    public partial class form訂購單 : Form
    {
        List<string> listProductName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listPid = new List<int>();
        List<int> liststock = new List<int>();
        List<int> listpprice = new List<int>();

        public form訂購單()
        {

        }

        private void from訂購單_Load(object sender, EventArgs e)
        {
            
            
        }

        

        private void btn登入_Click(object sender, EventArgs e)
        {
            Form from登入 = new Form登入();
            from登入.ShowDialog();
        }

        private void comboBoxQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }
    }
}
