using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesList
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREAR 2 FUNCIONES

            List<string> listaCompra = new List<string>();
            CreaLista(listaCompra);
            MostrarLista(listaCompra);
            Console.ReadLine();

        }

        public static void CreaLista(List<string> compra)
        {

            compra.Add("manzanas");
            compra.Add("platanos");
            compra.Add("pescado");
            compra.Add("verduras");
        }
        public static void MostrarLista(List<string> compra)
        {
            foreach (string x in compra)
            {
                Console.WriteLine(x);
            }
        }
        
        
    }
}
