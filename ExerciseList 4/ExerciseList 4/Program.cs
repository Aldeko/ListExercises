using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseList_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cantante, disco, salida;

            CantanteFamoso ca1 = new CantanteFamoso("GATIBU", "Laino gustien gainetik");
            CantanteFamoso ca2 = new CantanteFamoso("MICHAEL JACKSON", "Man on the mirror");

            List<CantanteFamoso> listaCantantesFamosos = new List<CantanteFamoso>();
            listaCantantesFamosos.Add(ca1);
            listaCantantesFamosos.Add(ca2);

            foreach (CantanteFamoso  x in listaCantantesFamosos)
            {
                Console.Write(x.Getnombre() + " =====>");
                Console.WriteLine(x.GetDiscoConMasventas());

            }
            do
            {


                do
                {

                    Console.WriteLine("escribe un nombre");
                    cantante = Console.ReadLine();
                    Console.WriteLine("Escribe un disco");
                    disco = Console.ReadLine();

                    if (cantante != "0" && disco != "0")
                    {
                        listaCantantesFamosos.Add(new CantanteFamoso(cantante, disco));
                    }

                } while (cantante != "0" || disco != "0");

                foreach (CantanteFamoso x in listaCantantesFamosos)
                {
                    Console.Write(x.Getnombre() + " =====>");
                    Console.WriteLine(x.GetDiscoConMasventas());
                }

                Console.WriteLine("Quieres meter mas datos? (S/N)");
                salida = Console.ReadLine();
            } while (salida != "N");

                Console.ReadLine();

        }
    }
}
