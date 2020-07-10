using System;
using Test1.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            var printService = new PrintService();
            Console.WriteLine(printService.PrintSumNumbers(3, 4));
            Console.ReadKey();
        }

    }
}
