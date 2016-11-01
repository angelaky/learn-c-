using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime date = DateTime.Now;
            date = date.AddDays(10);
            Console.WriteLine("ALOOO");
            Console.WriteLine("Today + 10 is {0:d} at {0:T}", date) ;
            Console.WriteLine($"Today + 10 is {date.ToShortDateString()} at {date.ToShortTimeString()}");
        }
    }
}
