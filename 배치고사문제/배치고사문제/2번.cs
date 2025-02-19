using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 배치고사문제
{
    internal class Class1
    {
        static void Add(int result, int i)
        {
            result += i;
        }

        static void Main(string[] args)
        {
            int total = 10;
            Console.WriteLine(total);
            Add(200, total);
            Console.WriteLine(total);
        }
    }
}
