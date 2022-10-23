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
using System.Windows.Shapes;

namespace PlayingWithXaml
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        
        public Dashboard()
        {
            InitializeComponent();
            Loaded += Dashboard_Loaded;         
        }

        private void Dashboard_Loaded(object sender, RoutedEventArgs e)
        {
            if (Application.Current.Properties["isAdmin"] == "true")
            {
                userLevel.Content = "ADMIN";
            }
            else
            {
                userLevel.Content = "NORMAL";
            }
        }

        private void NormalStuff(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "Doing normal stuff";
            string caption = "Normal";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBox.Show(messageBoxText, caption, button, icon);
            
        }

        private void AdminStuff(object sender, RoutedEventArgs e)
        {
            if (Application.Current.Properties["isAdmin"] == "true")
            {
                string messageBoxText = "Doing Admin stuff";
                string caption = "Admin";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBox.Show(messageBoxText, caption, button, icon);
            }
            else
            {
                string messageBoxText = "UHOH, You are not authorised";
                string caption = "Admin";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(messageBoxText, caption, button, icon);
            }

        }
    }
}
