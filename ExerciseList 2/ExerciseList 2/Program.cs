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
            List<double> decimales = new List<double>();

            string num;
            do
            {
                Console.WriteLine("introduce un número");
                num = Console.ReadLine();

                if (!num.Contains("-"))
                {
                    if (num.Contains(".") || num.Contains(","))
                    {
                        double numDecimal = Convert.ToDouble(num);
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
            }
            while (!num.Contains("-"));
            
            Console.ReadLine();

            foreach (int x in enteros)
            {
                Console.WriteLine(x);
                
            }
            Console.WriteLine(enteros.Sum());
            Console.WriteLine(enteros.Count-1);

            foreach (double x in decimales)
            {
                Console.WriteLine(x);
                
            }
            Console.WriteLine(decimales.Sum());

            double sumaTotal = decimales.Sum() + enteros.Sum();


            Console.ReadLine();
        }
    }
}
