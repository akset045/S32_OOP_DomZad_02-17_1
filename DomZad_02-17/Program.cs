using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomZad_02_17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите число A: ");
            Double A = Double.Parse(Console.ReadLine());

            Console.Write("Введите число B: ");
            Double B = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Сумма чисел: " + (A + B));
            Console.WriteLine();
            Console.Write("Разность чисел: " + (A - B));

            Console.ReadKey();
        }
    }
}
