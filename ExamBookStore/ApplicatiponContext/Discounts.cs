using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBookStore
{
    internal class Discount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Percent { get; set; }

        public List<Book> Books  { get; set; }


    }
}
