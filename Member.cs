//Made By : Sajid Ayman  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    class Member : Person
    {
        public Member(int id, string name)
        {
            Name=name;
            Id=id;
        }
        List<Book> BorrowBooks = new List<Book>();
        public override void PrintInfo()
        {
            Console.WriteLine($"User Id:{Id}\nUser Name:{Name}");
        }
        public void BorrowBook(Book b1)
        {
            if (b1.IsAvailable)
            {
                BorrowBooks.Add(b1);
            }
            else
            {
                Console.WriteLine("Unvailable Book ."); 
            }
        }
        public void ReturnBook(Book b1)
        {
            if (!b1.IsAvailable)
            {
                Console.WriteLine($"Book {b1.Title} is returnd!");
                BorrowBooks.Remove(b1); 
            }
            else
            {
                Console.WriteLine("Book is not borrowed ."); 
            }
        }
        public void DisplayBorrowedBooks()
        {
            Console.WriteLine("******Borrow Books******"); 
            foreach(var i in BorrowBooks)
            {
                i.DisplayInfo(); 
            }
        }
       
    }
}
