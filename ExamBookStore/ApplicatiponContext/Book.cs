using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBookStore
{
    internal class Book
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }

        public string Publisher { get; set; }

      public  Book(int ReleaseYear, string Name, string Publisher)
        {
            this.ReleaseYear = ReleaseYear;
            this.Name = Name;
            this.Publisher = Publisher; 
            

        }

      


    }
}
