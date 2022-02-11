using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningAbstractClass
{
    public abstract class BookBorrower
    {
        public string Identifier { get; set; }
        public List<Book> BookBorrowed { get; set; }

        public void ReadBooks(List<Book> books)
        {
            Console.WriteLine($"{Identifier} tooks books {string.Join(',', books.Select(x => x.Name))} to read");
        }

        public void BorrowBooks(List<Book> books)
        {
            Console.WriteLine($"{Identifier} borrowed books {string.Join(',', books.Select(x => x.Name))}");
        }

        public abstract void ReturnBooks(List<Book> books);
    }
}
