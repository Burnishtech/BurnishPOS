
using System;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using POSBizManager.BizManager;

namespace StandalonePOS.Login
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        UserBizManager ubzm = new UserBizManager();
        
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (ubzm.validateUser(txtLoginId.Text, txtPassword.Text))
            {
                MainWindow mw = new MainWindow();
                this.Close();
                mw.Activate();
                mw.Show();
            }
            else
                MessageBox.Show("Invalid User");
        }
    }
}
