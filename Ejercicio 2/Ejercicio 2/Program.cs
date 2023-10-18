using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<uint> numeros = new List<uint>();
            List<uint> resultados = new List<uint>();
            uint n;
            Console.WriteLine("Cuantos numeros deseas anadir");
            n = uint.Parse(Console.ReadLine());
            Console.WriteLine("Anada " + n + " numeros:");
            for(int i = 0; i < n; i++)
            {
                numeros.Add(uint.Parse(Console.ReadLine()));
            }
            numeros.Sort();
            for (int i = 0; i < n; i++)
            {
                resultados.Add(Listas.MultiplosDos(numeros[i]));
            }
            resultados.RemoveAll(x => x == 0);
            resultados = resultados.Distinct().ToList();
            Console.Write("Lista 1: ");
            foreach(uint var in resultados)
            {
                Console.Write(var + " ");
            }
            resultados.Clear();
            for (int i = 0; i < n; i++)
            {
                resultados.Add(Listas.Primos(numeros[i]));
            }
            resultados.RemoveAll(x => x == 0);
            resultados = resultados.Distinct().ToList();
            Console.Write("\nLista 2: ");
            foreach (uint var in resultados)
            {
                Console.Write(var + " ");
            }
            resultados.Clear();
            for (int i = 0; i < n; i++)
            {
                resultados.Add(Listas.MultiplosCinco(numeros[i]));
            }
            resultados.RemoveAll(x => x == 0);
            resultados = resultados.Distinct().ToList();
            Console.Write("\nLista 3: ");
            foreach (uint var in resultados)
            {
                Console.Write(var + " ");
            }
            resultados.Clear();
            for (int i = 0; i < n; i++)
            {
                resultados.Add(Listas.Perfectos(numeros[i]));
            }
            resultados.RemoveAll(x => x == 0);
            resultados = resultados.Distinct().ToList();
            Console.Write("\nLista 4: ");
            foreach (uint var in resultados)
            {
                Console.Write(var + " ");
            }
            resultados.Clear();
            Console.ReadKey();
        }
    }
}
