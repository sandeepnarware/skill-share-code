using Common;
using LearningAbstractClass;
using PlayGround;
using System;
using System.Collections.Generic;

namespace PlayGround
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student sushant = new();
            var books = new List<Book> { new Book { Name = "Networks" }, new Book { Name = "E&TC" } };
            sushant.ReadBooks(books);
            sushant.BorrowBooks(books);
            sushant.ReturnBooks(books);


            Teacher MrMethew = new();
            var booksForTeacher = new List<Book> { new Book { Name = "Networks" }, new Book { Name = "E&TC" } };
            MrMethew.ReadBooks(booksForTeacher);
            MrMethew.BorrowBooks(booksForTeacher);
            MrMethew.ReturnBooks(booksForTeacher);

        }
    }
}