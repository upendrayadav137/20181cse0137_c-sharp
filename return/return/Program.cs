using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @return
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cube(3));

            Console.ReadLine();
        }
        static int Cube(int num)
        {
            int Result = num * num * num;
            return Result;
        }


    }
}
