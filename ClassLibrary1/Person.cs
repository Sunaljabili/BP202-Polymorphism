using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public abstract byte Age { get; set; }
    }
}
