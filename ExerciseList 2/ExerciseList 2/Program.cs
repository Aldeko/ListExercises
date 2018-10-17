using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseList_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> enteros = new List<int>();
            List<decimal> decimales = new List<decimal>();

            string num;
            do
            {
                Console.WriteLine("introduce un número");
                num = Console.ReadLine();

                if (num.Contains(".") || num.Contains(","))
                {
                    decimal numDecimal = Convert.ToDecimal(num);
                    decimales.Add(numDecimal);
                    Console.WriteLine("Es decimal");
                }
                else
                {
                    int numEntero = Convert.ToInt32(num);
                    enteros.Add(numEntero);
                    Console.WriteLine("Es entero");
                }
            }
            while (num != "120");
            enteros.Remove(120);
            foreach (int x in enteros)
            {
                Console.WriteLine(x);
            }
            foreach (decimal x in decimales)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }
    }
}
