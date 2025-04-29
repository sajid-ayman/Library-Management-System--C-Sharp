//Made By : Sajid Ayman  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    class Library
    {
        List<Book> Books = new List<Book>();
        List<Person> Members = new List<Person>();
        public void AddBook(Book b)
        {
            Books.Add(b);
        }
        public void AddMember(Member p)
        {
            Members.Add(p); 
        }
        public Book FindBookById(int id)
        {
            return (Books.Find(Book => Book.Id==id)); 
        }
        public Person FindMemberById(int id)
        {
            return Members.Find(Person => Person.Id==id);  
        }
        public void DisplayAllBooks()
        {
            Console.WriteLine("********All Books********");
            foreach (var i in Books)
            {
                i.DisplayInfo(); 
            }
        }
        public void DisplayAllMembers()
        {
            Console.WriteLine("********All Members********");
            foreach (var i in Members)
            {
                i.PrintInfo(); 
            }
        }
    }
}
