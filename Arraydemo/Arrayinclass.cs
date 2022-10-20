using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraydemo
{
    public class book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string publisher { get; set; }
        public int Price { get; set; }
    }
    public class course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int durationmonth { get; set; }
        public int fees { get; set; }
    }
    public class Arrayinclass
    {
        static void Main(string[] args)
        {
            book[] booklist = new book[3]
            {
                new book{Id=1,Name="book1",publisher="ak",Price=345},
                new book{Id=2,Name="book2",publisher="bk",Price=445},
                new book{Id=1,Name="book3",publisher="tk",Price=645},
            };

            foreach (book b in booklist)
            {
                Console.WriteLine($"{b.Id} {b.Name}{b.publisher} {b.Price}");
            }

            course[] courselist = new course[3]
            {
                new course{Id=1, Name="c++", durationmonth=4,fees=34566},
               new course{Id=2, Name="java", durationmonth=5,fees=45000},
               new course{Id=1, Name="SQL", durationmonth=4,fees=45000},
            };

            foreach (course c in courselist)
            {
                Console.WriteLine($"{c.Id} {c.Name} {c.durationmonth} {c.fees}");



            }
        }
    }
}