using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___16_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete (2) chislo");
            string number = Console.ReadLine();
            int dignumber = Convert.ToInt32(number,2);
            string hexnumber = Convert.ToString(dignumber, 16);
            Console.WriteLine("{0}[2]={1}[10]={2}[16]", number, dignumber,hexnumber.ToUpper());
        }
    }
}
