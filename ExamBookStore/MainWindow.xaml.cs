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


namespace ExamBookStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MaxWidth = 300;
            MaxHeight = 585;
            MinHeight = 585;
            MinWidth = 300;
           // Rememb.Checked = Properties.Settings.Default.IsRemember;
        }

        private void Button_Registr_Click(object sender, RoutedEventArgs e)
        {
            string login = loginBox.Text.Trim();
            string password = pwdBox.Password.Trim();
            
            
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
