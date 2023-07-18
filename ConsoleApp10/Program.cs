using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 0;
            int i = 0;
            int elt;
            int len;
            int s = 0;
            int[] mass = { 1, 2, 3, 4, 5, 6,2 };
            List<int> num = new List<int>();
            Console.WriteLine("Введите значение искомого элемента");

            elt = Convert.ToInt32(Console.ReadLine());

            len = mass.Length;
            for (i = 0; i <= len-1; i++)
            {
                if (elt == mass[i]) { Console.WriteLine("Элемент найден");  Console.WriteLine(mass[i].ToString() + " " + i.ToString()); s = s + 1; }

            }
            if (s == 0) { Console.WriteLine("Элемент не найден"); }
            Console.ReadKey();
        }
    }

}

