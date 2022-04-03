using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Student:Person
    {
        public Student(string name, string surname, byte age, int iqrank, int languagerank)
        {
            if (age >6 && age < 20)
            {
                Name = name;
                Surname = surname;
                Age = age;
                IQRank = iqrank;
                LanguageRank = languagerank;
            }
        }
        byte _age;
        int _iqrank;
        int _languagerank;
        public int IQRank { get => _iqrank; set { if (value >= 0 && value <= 100) _iqrank = value; } }
        public int LanguageRank { get => _languagerank; set { if (value >= 0 && value <= 100) _languagerank = value; } }
        public override byte Age { get =>_age; set { if (value > 6 && value < 20) _age = value; } }

        public void ExamResult()
        {
            if (IQRank+ LanguageRank < 120)
            {
                Console.WriteLine("kesilmisiniz!");
            }
        }
    }
}
