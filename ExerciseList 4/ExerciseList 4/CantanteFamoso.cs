using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseList_4
{
    class CantanteFamoso
    {
        private string nombre, discoConMasVentas;

        public CantanteFamoso ()
        {
            nombre = "YLVIS";
            discoConMasVentas = "WHAT DOES THE FOX SAY";

        }
        public CantanteFamoso(string nombre, string discoConMasVentas)
        {
            this.nombre = nombre;
            this.discoConMasVentas = discoConMasVentas;
        }
        public string Getnombre()
        {
            return nombre;
        }
        public void Setnombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetDiscoConMasventas()
        {
            return discoConMasVentas;
        }
        public void SetDiscoConMasVEntas(string discoConMasVentas)
        {
            this.discoConMasVentas = discoConMasVentas;
        }
    }

}
