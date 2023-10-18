using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.Models
{
    public class Celular_Nuevo: Celular
    {
        public DateTime FechaIngreso { get; set; }
        public uint Precio { get; set; }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - {4} - {5} - {6}", Marca, Modelo, SO, Ram, Almacenamiento, FechaIngreso, Precio);
        }
    }
}
