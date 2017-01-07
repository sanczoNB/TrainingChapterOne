using System;
using System.Windows.Forms;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Formatowanie liczb:\n\t {0}, {0:c}, {0:p3}, {0:e3}, \n\t{0:f3}," +
                              " {0:g1}, {0:n10}, {0:r}", 0.123456789);
        }
    }
}
