//Made By : Sajid Ayman  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Library_Management_System
{
    class Book
    {
        public int Id { set; get; }
        public String Title { set; get; }
        public String AuthorName { set; get; }
        public bool IsAvailable { set; get; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Book Id:{Id}\nBook Name:{Title}\nAuthor Name:{AuthorName}\n");
        }
        public Book(int id, string title, string authorName)
        {
            Id=id;
            Title=title;
            AuthorName=authorName;
            IsAvailable=true ;
        }
    }
}
