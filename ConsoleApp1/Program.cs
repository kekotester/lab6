using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение параметра x: ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double F = 3 * Math.Sin(x + 2);
            Console.WriteLine($"Значение F = {F}");
            Console.ReadLine();


        }
    }
}
