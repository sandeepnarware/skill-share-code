using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAbstractClass
{
    public class Teacher : BookBorrower
    {
        public override void ReturnBooks(List<Book> books)
        {
            Console.WriteLine("for teacher we do not need to check late fees :)");
            Console.WriteLine($"{Identifier} returned books {string.Join(',', books.Select(x => x.Name))}");
        }
    }
}
