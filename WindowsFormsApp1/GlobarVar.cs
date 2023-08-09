using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp1.Form商品資料;

namespace WindowsFormsApp1
{
    internal class GlobarVar
    {
        public static string image_dir = @"..\圖片";
        public static string strDBConnectionString = "";
        public static int 身分確認 = 0;
        public static List<CartItem> _cartItems = new List<CartItem>();
        public static bool 設計模式 = false;
        public static bool 新增模式 = false;
        public static int 登入者ID { get; set; }
        public static string username;
    }
}
