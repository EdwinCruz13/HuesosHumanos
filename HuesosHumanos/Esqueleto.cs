using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HuesosHumanos
{
    public class Esqueleto
    {
        public List<Hueso> Huesos;
        

        public Esqueleto()
        {
            InicializarEsqueleto();
        }

        /// <summary>
        /// Inicializar el esqueleot humano
        /// </summary>
        private void InicializarEsqueleto()
        {
            Huesos = new List<Hueso>();
        }
        
        /// <summary>
        /// Agregar el hueso humano
        /// </summary>
        /// <param name="hueso">objeto con la información del hueso</param>
        public void AgregarHueso(Hueso hueso)
        {
            if (Huesos.Count() > 206)
            {
                Console.WriteLine("El cuerpo humano solo posee 206 huesos");
                return;
            }

            //agregar el hueso humano
            hueso.Numero = Huesos.Count() + 1; //añadir un numero
            Huesos.Add(hueso);
            Console.WriteLine($"Hueso: {hueso.Nombre} ha sido agregado.");
        }

        /// <summary>
        /// Ordenar la lista de acuerdo a un criterio
        /// </summary>
        /// <param name="_criterio"></param>
        public void Ordenar(String _criterio)
        {
            var unsorted = new List<Hueso>();

            //buscar la propiedad en el objecto
            PropertyInfo property = typeof(Hueso).GetProperty(_criterio);
            if (property != null)
            {
                unsorted = Huesos.OrderBy(x => property.GetValue(x)).ToList();
                Huesos = unsorted;
            }
            else Console.WriteLine("Criterio de ordenación invalida :*");
        }

        public void Imprimir()
        {
            foreach (Hueso hueso in Huesos)
            {
                Console.WriteLine($"{hueso.Nombre} con un peso de {hueso.Peso}, una densidad de {hueso.Densidad}, mide {hueso.Longitud} cm2 y con diámetro de {hueso.Diametro} cm.");
            }
        }
    }
}
