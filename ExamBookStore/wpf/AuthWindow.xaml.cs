using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignColors;


namespace ExamBookStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {

        AppContext db = new AppContext();

      
        public AuthWindow()
        {
                InitializeComponent();
            int UserCount = db.Users.Count<User>();
            if (UserCount == 0)
            {
                User user = new User("user", "1234");
                db.Users.Add(user);
                db.SaveChanges();
            }
            MaxWidth = 300;
            MaxHeight = 585;
            MinHeight = 585;
            MinWidth = 300;
            
                
            

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
            if (authUser != null)
            {

                MainWindow main = new MainWindow();

                 this.Hide();
                 main.Show();
                 this.Close();

            }
            else
            {
                uncorrect.Visibility = Visibility.Visible;
                
            }


        }


      
    }
}
