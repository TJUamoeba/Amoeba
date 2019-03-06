using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello1
{
    class Line
    {
        private String GuestName { get; set; }
        public Line(String str)
        {
            GuestName = str;
        }
        public void speak()
        {
            Console.WriteLine("Hello {0}!", GuestName);
        }
    }
}
