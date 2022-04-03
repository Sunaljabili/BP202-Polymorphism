using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public  class Journal:Product
    {
        public string Company { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Company :{Company} | Name : {Name}  | Price : {Price}");
        }
    }
}
