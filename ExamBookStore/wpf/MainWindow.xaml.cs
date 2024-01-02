using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using System.Windows.Shapes;


namespace ExamBookStore
{
    public partial class MainWindow : Window
    {
        AppContext db;
        public MainWindow()
        {
            InitializeComponent();
            MaxHeight = 550;
            MaxWidth = 800;
            MinHeight = 550;
            MinWidth = 800;
            db = new AppContext(); ;

            using (AppContext db = new AppContext())
            {
            
            List<Book> books = db.Book.ToList();
            ListBooks.ItemsSource = books;
            }
           

        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string publisher = TextPublisher.Text;
            int releaseYear = Convert.ToInt32(TextReleaseYear.Text);
            string bookName = TextBooksName.Text;
            double price = Convert.ToDouble(TextPrice.Text);
            Book book = new Book(releaseYear, bookName, publisher, price);
            using (AppContext db = new AppContext())
            {
                db.Book.Add(book);
                db.SaveChanges();
                List<Book> books = db.Book.ToList();
                ListBooks.ItemsSource = books;

            }
            MessageBox.Show("Книга успешно добавлена");
            TextBooksName.Clear();
            TextReleaseYear.Clear();
            TextPublisher.Clear();
            TextPrice.Clear();
        }
        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int? ID = Convert.ToInt32(BookID.Text);
                Book bookID = null;
                using (AppContext db = new AppContext())
                {
                    bookID = db.Book.Where(b => b.Id == ID).FirstOrDefault();
                }
                if (bookID == null)
                {
                    MessageBox.Show("Такой книги нет");
                }
                else
                {
                    using (AppContext db = new AppContext())
                    {
                        db.Book.Remove(bookID);
                        db.SaveChanges();
                        List<Book> books = db.Book.ToList();
                        ListBooks.ItemsSource = checked(books);
                        
                    }
                    MessageBox.Show("Книга успешно удалена");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
