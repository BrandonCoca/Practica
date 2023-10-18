using Ejercicio_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.Controllers
{
    class CelularDefectuosoController
    {
        public void Agregar(List<Celular_Defectuoso> celularDefectuoso, Celular_Defectuoso item)
        {
            celularDefectuoso.Add(item);
        }
        public void Mostrar(List<Celular_Defectuoso> mostrarCelular)
        {
            foreach (var item in mostrarCelular)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
