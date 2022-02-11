using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAbstractClass
{
    public class Student : BookBorrower
    {
        public override void ReturnBooks(List<Book> books)
        {
            Console.WriteLine("for students we need to check late fees :)");
            Console.WriteLine($"{Identifier} returned books {string.Join(',', books.Select(x => x.Name))}");
        }
    }
}
