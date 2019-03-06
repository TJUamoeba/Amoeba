using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello! What's your name ?");
            String GuestName = Console.ReadLine();
            Host.speak(GuestName);
            Console.ReadLine();

        }
    }
}
