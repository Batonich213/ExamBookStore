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

            MaxHeight = 500;
            MaxWidth = 800;
            MinHeight = 500;
            MinWidth = 800;

            db = new AppContext();
            

            //listUsers.ItemsSource = users;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string publisher = Publisher.Text;
            int releaseYear = Convert.ToInt32(ReleaseYear.Text);
            string bookName = BooksName.Text;

            if (releaseYear < 800)
            {
                MessageBox.Show("Вы ввели некорректную дату");
            }

            Books book = new Books(releaseYear, bookName, publisher);

          

            db.Books.Add(book);
            db.SaveChanges();

        }

 
    }
}
