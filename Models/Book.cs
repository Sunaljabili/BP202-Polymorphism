using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Book : Product
    {
        public string Genre { get; set; }
        public string  Author { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($" Name : {Name} | Price : {Price}  Genre : {Genre} | Author {Author} " );
        }
    }
}
