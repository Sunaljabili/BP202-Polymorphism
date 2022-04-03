using System;

namespace AreaApp
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Menu");
            Console.WriteLine("1.Square");
            Console.WriteLine("2.Rectangle");
            Console.WriteLine("0.Quit");

            int answer = Convert.ToInt32(Console.ReadLine());
           
            switch (answer)
            {

                case 1:
                    Square square = new Square(20);
                    square.CalcArea();
                    break;

                case 2:
                    Rectangular rectangular = new Rectangular(20,40);
                    rectangular.CalcArea();
                    break;
                case 0:
                    Console.WriteLine("Proqram bittdi");
                    break;

                default:
                    Console.WriteLine("Bele bir secim yoxdur");
                    break;
            }
        }
    }
}
