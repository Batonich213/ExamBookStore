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
using MaterialDesignColors;


namespace ExamBookStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        AppContext db;

      
        public MainWindow()
        {
            InitializeComponent();
            MaxWidth = 300;
            MaxHeight = 585;
            MinHeight = 585;
            MinWidth = 300;
        db = new AppContext();

        }

        private void Button_Join_Click(object sender, RoutedEventArgs e)
        {
            string login = loginBox.Text.Trim();
            string password = pwdBox.Password.Trim();

            User authUser = null;
             using (AppContext db = new AppContext())
            { 
                authUser = db.Users.Where(a => a.Login == login && a.Password == password).FirstOrDefault();

            }
            if (authUser != null )
            {
                MessageBox.Show("All good");
            }
            else
            {
                uncorrect.Visibility = Visibility.Visible;
                
            }


        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            
        }

      
    }
}
