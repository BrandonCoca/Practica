using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_3.Models;

namespace Ejercicio_3.Controllers
{
    class CelularNuevoController
    {
        public void Agregar(List<Celular_Nuevo> celularNuevo, Celular_Nuevo item)
        {
            celularNuevo.Add(item);
        }
        public void Mostrar(List<Celular_Nuevo> mostrarCelular)
        {
            foreach(var item in mostrarCelular)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
