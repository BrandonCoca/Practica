using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numero: ");
            uint dato;
            dato = uint.Parse(Console.ReadLine());
            string operacion = Resultados.Digito(dato);
            Console.WriteLine(operacion);
            Console.ReadKey();
        }
    }
}
