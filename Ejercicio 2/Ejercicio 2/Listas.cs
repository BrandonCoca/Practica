using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public static class Listas
    {
        public static uint MultiplosDos(uint x)
        {
            if (x % 2 == 0) return x;
            else return 0;
        }
        public static uint Primos(uint x)
        {
            uint veces = 0;
            if (x == 0) return 0;
            else if (x == 1) return 0;
            else if (x == 2) return x;
            else
            {
                for (int i = 2; i <= x; i++)
                {
                    if (x % i == 0) veces++;
                }
                if (veces == 1) return x;
                else return 0;
            }
        }
        public static uint MultiplosCinco(uint x)
        {
            if (x % 5 == 0) return x;
            else return 0;
        }
        public static uint Perfectos(uint x)
        {
            uint sumando = 0;
            List<uint> divisores = new List<uint>();
            if (x == 1) return 0;
            else
            {
                for(uint i = 1; i < x; i++)
                {
                    if (x % i == 0) divisores.Add(i);
                }
                foreach(uint suma in divisores)
                {
                    sumando = sumando + suma; 
                }
                if (sumando == x) return x; 
                else return 0;
            }
        }
    }
}
