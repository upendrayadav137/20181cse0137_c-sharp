using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bettercalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the num1 : ");
            double num1=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the num2 : ");
            double num2=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the op : ");
            string op=Console.ReadLine();
            if (op == "+")
            {
              Console.WriteLine(num1+num2) ;
            }else if(op == "-")
            {
                Console.WriteLine(num1-num2) ;
            }else if (op == "*")
            {
                Console.WriteLine(num1*num2);
            }else if (op == "/")
            {
                Console.WriteLine(num1/num2);
            }else
            {
                Console.WriteLine("Invalid operation");
            }
            Console.ReadLine();
        }
    }
}
