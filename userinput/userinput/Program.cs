using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userinput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Your Age : ");
            string Age = Console.ReadLine();
            Console.WriteLine("Hello " + Name + " Your are " + Age);

            Console.ReadLine();
        }
    }
}
