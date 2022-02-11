using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAbstractClass
{
    public class Librarian : BookBorrower
    {
        public override void ReturnBooks(List<Book> books)
        {
            Console.WriteLine($"{Identifier} returned books {string.Join(',', books.Select(x => x.Name))}");
        }
    }
}
