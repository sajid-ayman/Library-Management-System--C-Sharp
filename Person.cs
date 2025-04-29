//Made By : Sajid Ayman  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library_Management_System
{
    abstract class  Person
    {
        public string Name { set;get; }
        public int Id { set; get; }
        

        public abstract void PrintInfo();
    }
}
