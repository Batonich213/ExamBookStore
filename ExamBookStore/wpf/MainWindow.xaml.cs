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

            MaxHeight = 550;
            MaxWidth = 800;
            MinHeight = 550;
            MinWidth = 800;

            db = new AppContext();
            

          
           
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

            string publisher = Publisher.Text;
            int releaseYear = Convert.ToInt32(ReleaseYear.Text);
            string bookName = BooksName.Text;

            if (releaseYear < 800)
            {
                MessageBox.Show("Вы ввели некорректную дату");
            }
            else
            {

            Book book = new Book(releaseYear, bookName, publisher);

 
                using (AppContext db = new AppContext())
                {

                db.Book.Add(book);

                    
                    db.SaveChanges();
                }
                MessageBox.Show("Книга успешно добавлена");
               
               

            }

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

                    using(AppContext db = new AppContext())
                    {

                    db.Book.Remove(bookID);
                    db.SaveChanges();
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
