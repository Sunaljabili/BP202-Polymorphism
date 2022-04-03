using System;
using System.Collections.Generic;
using System.Text;

namespace AreaApp
{
     class Rectangular:Figure
    {
        public Rectangular(int width,int length)
        {
            Width = width;
            Length = length;
        }
        private int _width;
        private int _length;
        public int Width {
            get
            {
                return _width;
            }
            set {
                if (value > 0)
                {

                    _width = value;
                }
            } 
        }
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0)
                {

                    _length = value;
                }
            }
        }

        

        public override void CalcArea()
        {
            Console.WriteLine($"{ _width * _length }");
        }
    }
}
