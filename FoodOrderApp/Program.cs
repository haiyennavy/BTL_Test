using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Đảm bảo thư mục Images tồn tại
            string imagesPath = Path.Combine(Application.StartupPath, "Images");
            if (!Directory.Exists(imagesPath))
            {
                Directory.CreateDirectory(imagesPath);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm(new User()));
            Application.Run(new LoginForm());
            //Application.Run(new RevenueReportForm());
            //Application.Run(new AdminForm(new User() { UserRole = "Admin" }));
            //Application.Run(new Form1(new User()));

            // test lich mua hang cua user co id = 2 trong db
            //Application.Run(new OrderHistoryForm(2));

            // test rating
            //Application.Run(new RatingForm(new Order()));
        }
    }
}
