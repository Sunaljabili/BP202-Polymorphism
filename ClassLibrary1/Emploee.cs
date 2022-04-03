using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Emploee:Person
    {
        public Emploee(string name , string surname, byte age, double workHour, double salaryOfHour)
        {
            if (age > 18)
            {
                Name = name;
                Surname = surname;
                Age = age;
                SalaryOfHour = salaryOfHour;
                WorkingHour = workHour;
            }
        }

        double _workingHour;
        byte _age;
        public double SalaryOfHour { get; set; }
        public double WorkingHour { get => _workingHour; set { if (value / 30 <= 8) _workingHour = value; } }
        public override byte Age { get => _age; set { if (value >= 18) _age = value; } }

        public void CalculateSalary()
        {
            double Salary = 0;
            if (WorkingHour*SalaryOfHour>=250)
            {
                Salary = WorkingHour * SalaryOfHour;
                Console.WriteLine(Salary);
            }
            else
                Console.WriteLine("maasiniz 250den asagi ola bilmez");
            
        }
    }
}
