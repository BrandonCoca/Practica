using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.Models
{
    public class Celular_Defectuoso: Celular
    {
        public DateTime FechaDefecto { get; set; }
        public string Motivo { get; set; }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - {4} - {5} - {6}", Marca, Modelo, SO, Ram, Almacenamiento, FechaDefecto, Motivo);
        }
    }
}
