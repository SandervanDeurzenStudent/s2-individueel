using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hondenrace
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            
            InitializeComponent();

            //this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        public static int userId { get; set; }
       
        //private void OnKeyDownHandler(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.Return)
        //    {
        //        this.Button_Click(sender, e);
        //    }
        //}

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;
            Login login = new Login();
            int isLoggedIn = login.checkLogin(username, password);
            userId = isLoggedIn;

            if (isLoggedIn > 0)
            {
                Hide();
                form1 dashboard = new form1();
                dashboard.Show();
            }
            if (isLoggedIn == 0)
            {
                MessageBox.Show("Login unsuccessfull, please try again");
            }
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
