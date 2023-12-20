using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBookStore
{
    internal class Books
    {
        public int id { get; set; }
        public string name { get; set; }
        public int releaseYear { get; set; }

        public string publisher { get; set; }

      public  Books(int releaseYear, string name, string publisher)
        {
            this.releaseYear = releaseYear;
            this.name = name;
            this.publisher = publisher; 
            

        }

      


    }
}
