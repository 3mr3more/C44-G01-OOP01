using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo
{
    internal struct Point
    {
        public int X = default; // 4

        public int Y = default; // 4

        // Constructor: Special Methods
        //             1. Named Like Struct
        //             1. Has No Return Type

        // CLR : Will Generate Paremeterless Contructor
        // This Construtor Will Initialized The Attributes With The Default Value


        // Constructor
        //public Point()
        //{

        //}

        //.NET 5.0 C# 9.0
        //.NET 6.0 C# 10.0
        //.NET 7.0 C# 11.0
        //.NET 8.0 C# 12.0

        public Point() { 

X = 12;
Y = 12;

}

        public Point(int x, int y)

        {

            X = x;
            Y = y;

        }
        public void PrintPoint()

        {

            Console.WriteLine(value: $"({X}, {Y})");

        }

    }
}