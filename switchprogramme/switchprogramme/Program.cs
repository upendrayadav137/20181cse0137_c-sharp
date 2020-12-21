using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchprogramme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(8));
            Console.ReadLine();
        }
        static string GetDay(int num)
        {
            string day;
            switch (num)
            {
                case 0:
                    day = "sunday";
                    break;
                case 1:
                    day = "monday";
                    break;
                case 2:
                    day = "tuesday";
                    break;
                case 3:
                    day = "wednesday";
                    break;
                case 4:
                    day = "thursday";
                    break;
                case 5:
                    day = "friday";
                    break;
                case 6:
                    day = "satuday";
                    break;
                default :
                    day = "invalid Day no.";
                    break;
            }
            return day;
        }
    }
}
