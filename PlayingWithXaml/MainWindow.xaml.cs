using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PlayingWithXaml
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //bool isAdmin = false;
        public MainWindow()
        {
            InitializeComponent();
            Application.Current.Properties["isAdmin"] = false; //default to false in constructor
        }

        private void ValidateUser(object sender, RoutedEventArgs e)
        {
            if (userId.Text == "0" && password.Password == "Letmein")
            {
                Dashboard dashboard = new Dashboard();
                //normal user logic
                Application.Current.Properties["isAdmin"] = false;
                dashboard.Show();
            }
            else if (userId.Text == "1" && password.Password == "Iamadmin")
            {
                Dashboard dashboard = new Dashboard();
                //admin logic
                //isAdmin = true;
                Application.Current.Properties["isAdmin"] = "true";
                dashboard.Show();
            }
            else
            {
                string messageBoxText = "Wrong username or password, \n Pease try again!";
                string caption = "Uhoh!";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(messageBoxText, caption, button, icon);
            }
            
        }
    }
}
