using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What is your name ?");
            string somebody = Console.ReadLine();
            Line hi = new Line(somebody);
            hi.speak();
            Console.ReadLine();
        }
    }
}
