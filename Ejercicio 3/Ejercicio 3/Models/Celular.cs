using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.Models
{
    public abstract class Celular
    {
        public string Marca {  get; set; }
        public string Modelo { get; set; }
        public string SO { get; set; }
        public uint Ram {  get; set; }
        public uint Almacenamiento { get; set; }
    }
}
