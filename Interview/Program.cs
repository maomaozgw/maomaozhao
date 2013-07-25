using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            FindAloneOne.DoFind(500000);
            Console.WriteLine(timer.ElapsedTicks);
            timer.Restart();
            FindAloneOne.DoFind2(500000);
            Console.WriteLine(timer.ElapsedTicks);
            Console.ReadKey(true);
        }
    }
}
