using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public static class Resultados
    {
        public static string Digito(uint n)
        {
            string numero;
            if (n == 0) return numero = "cero";
            else if (n == 1) return numero = "uno";
            else if (n == 2) return numero = "dos";
            else if (n == 3) return numero = "tres";
            else if (n == 4) return numero = "cuatro";
            else if (n == 5) return numero = "cinco";
            else if (n == 6) return numero = "seis";
            else if (n == 7) return numero = "siete";
            else if (n == 8) return numero = "ocho";
            else if (n == 9) return numero = "nueve";
            else if (n == 10) return numero = "diez";
            else if (n == 11) return numero = "once";
            else if (n == 12) return numero = "doce";
            else if (n == 13) return numero = "trece";
            else if (n == 14) return numero = "catorce";
            else if (n == 15) return numero = "quince";
            else if (n < 20) return numero = "dieci" + Digito(n - 10);
            else if (n == 20) return numero = "veinte";
            else if (n < 30) return numero = "veinti" + Digito(n - 20);
            else if (n == 30) return numero = "treinta";
            else if (n < 40) return numero = "treinta y " + Digito(n - 30);
            else if (n == 40) return numero = "cuarenta";
            else if (n < 50) return numero = "cuarenta y " + Digito(n - 40);
            else if (n == 50) return numero = "cincuenta";
            else if (n < 60) return numero = "cincuenta y " + Digito(n - 50);
            else if (n == 60) return numero = "sesenta";
            else if (n < 70) return numero = "sesenta y " + Digito(n - 60);
            else if (n == 70) return numero = "setenta";
            else if (n < 80) return numero = "setenta y " + Digito(n - 70);
            else if (n == 80) return numero = "ochenta";
            else if (n < 90) return numero = "ochenta y " + Digito(n - 80);
            else if (n == 90) return numero = "noventa";
            else if (n < 100) return numero = "noventa y " + Digito(n - 90);
            else if (n == 100) return numero = "cien";
            else if (n < 200) return numero = "ciento" + Digito(n - 100);
            else return numero = "Demasiado alto";
        }
    }
}
