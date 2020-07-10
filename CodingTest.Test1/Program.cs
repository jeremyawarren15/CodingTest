using CodingTest.Test1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ss = new SumService();

            Console.WriteLine(ss.SumNumbers(4, 5));
            Console.ReadKey();
        }
    }
}
