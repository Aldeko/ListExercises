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
            Console.WriteLine();
            //List<string> nombres = new List<string>()
            //{
            //    "iker",
            //    "unai",
            //    "natalia"
            //};

            //MostrarLista(nombres);

            OrdenarLista(listaCompra);
            MostrarLista(listaCompra);
            Console.WriteLine();

            BorrarDeLaLista(listaCompra);
            MostrarLista(listaCompra);
            Console.WriteLine();

            ContarElementos(listaCompra);
            Console.WriteLine();
            Console.ReadLine();

        }

        public static void CreaLista(List<string> compra)
        {

            compra.Add("manzanas");
            compra.Add("platanos");
            compra.Add("pescado");
            compra.Add("verduras");
        }
        public static void MostrarLista(List<string> lista)
        {
            foreach (string elemento in lista)
            {
                Console.WriteLine(elemento);
            }
        }
        public static void OrdenarLista(List<string>compra)
        {
            compra = compra.OrderBy(o => o).ToList();
        }
        public static void BorrarDeLaLista(List<string>compra)
        {
            compra.Remove("manzanas");
        }
        public static void ContarElementos(List<string> compra)
        {
            var count = compra.Count();
            Console.WriteLine(count);
        }




    }
}
