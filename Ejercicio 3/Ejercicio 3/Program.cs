using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using Ejercicio_3.Controllers;
using Ejercicio_3.Models;

namespace Ejercicio_3
{
    class Program
    {
        static CelularNuevoController _celularNuevoController = new CelularNuevoController();
        static CelularDefectuosoController _celularDefectuosoController = new CelularDefectuosoController();
        static void Main(string[] args)
        {
            List<Celular_Nuevo> celularesNuevos = new List<Celular_Nuevo>();

            Celular_Nuevo uno = new Celular_Nuevo() {Marca = "Samsung", Modelo = "S20", SO = "Android", Ram = 8, Almacenamiento = 128, FechaIngreso = DateTime.Parse("2015-04-30"), Precio = 1800};
            _celularNuevoController.Agregar(celularesNuevos, uno);
            Celular_Nuevo dos = new Celular_Nuevo() {Marca = "Samsung", Modelo = "S21", SO = "Android", Ram = 16, Almacenamiento = 64, FechaIngreso = DateTime.Parse("2005-01-12"), Precio = 2100};
            _celularNuevoController.Agregar(celularesNuevos, dos);
            Celular_Nuevo tres = new Celular_Nuevo() {Marca = "Apple", Modelo = "iPhone 15", SO = "iOS", Ram = 12, Almacenamiento = 32, FechaIngreso = DateTime.Parse("2005-08-06"), Precio = 2600};
            _celularNuevoController.Agregar(celularesNuevos, tres);
            Celular_Nuevo cuatro = new Celular_Nuevo() {Marca = "Samsung", Modelo = "S21", SO = "Android", Ram = 8, Almacenamiento = 128, FechaIngreso = DateTime.Parse("2005-05-17"), Precio = 2100};
            _celularNuevoController.Agregar(celularesNuevos, cuatro);
            Celular_Nuevo cinco = new Celular_Nuevo() {Marca = "Samsung", Modelo = "S21", SO = "Android", Ram = 8, Almacenamiento = 128, FechaIngreso = DateTime.Parse("2011-12-31"), Precio = 2100};
            _celularNuevoController.Agregar(celularesNuevos, cinco);
            Celular_Nuevo seis = new Celular_Nuevo() {Marca = "Apple", Modelo = "iPhone 15", SO = "iOS", Ram = 16, Almacenamiento = 32, FechaIngreso = DateTime.Parse("2015-12-07"), Precio = 2200};
            _celularNuevoController.Agregar(celularesNuevos, seis);
            Celular_Nuevo siete = new Celular_Nuevo() {Marca = "Apple", Modelo = "iPhone 13", SO = "iOS", Ram = 12, Almacenamiento = 128, FechaIngreso = DateTime.Parse("2015-10-02"), Precio = 2000};
            _celularNuevoController.Agregar(celularesNuevos, siete);
            Celular_Nuevo ocho = new Celular_Nuevo() {Marca = "Apple", Modelo = "iPhone 15", SO = "iOS", Ram = 4, Almacenamiento = 64, FechaIngreso = DateTime.Parse("2005-11-25"), Precio = 2100};
            _celularNuevoController.Agregar(celularesNuevos, ocho);
            Celular_Nuevo nueve = new Celular_Nuevo() {Marca = "Samsung", Modelo = "S20", SO = "Android", Ram = 8, Almacenamiento = 64, FechaIngreso = DateTime.Parse("2018-02-23"), Precio = 1800};
            _celularNuevoController.Agregar(celularesNuevos, nueve);
            Celular_Nuevo diez = new Celular_Nuevo() {Marca = "Apple", Modelo = "iPhone 13", SO = "iOSd", Ram = 12, Almacenamiento = 128, FechaIngreso = DateTime.Parse("2005-07-14"), Precio = 1900};
            _celularNuevoController.Agregar(celularesNuevos, diez);

            Console.Write("Promedio del precio de los celulares: ");
            var Prom_Celular = celularesNuevos.Average(x => x.Precio);
            Console.WriteLine(Prom_Celular);

            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Los celulares de marca Samsung");
            var Cel_MarcaS = celularesNuevos.Where(y => y.Marca == "Samsung");
            foreach(var item in Cel_MarcaS)
            {
                Console.WriteLine(item.Modelo + "-" + item.SO + "-" + item.Ram + "GB-" + item.Almacenamiento + "GB");
            }

            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Los celulares que son de RAM = 8GB, SO = Android y Almacenamiento de 128GB");
            var Celular_RSA = from condiciones in celularesNuevos
                              where condiciones.Ram == 8 && condiciones.SO == "Android" && condiciones.Almacenamiento == 128
                              select condiciones;
            foreach(var item in Celular_RSA)
            {
                Console.WriteLine(item.Marca + "-" + item.Modelo);
            }

            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Mostrar los celulares que se ingresaron el ano 2005");
            var Celular_Ingreso = from fecha in celularesNuevos
                                  where fecha.FechaIngreso.Year == DateTime.Parse("2005-01-01").Year
                                  select fecha;
            foreach(var item in Celular_Ingreso)
            {
                Console.WriteLine(item.Marca + "-" + item.Modelo + "-" + item.SO + "-" + item.Ram + "GB-" + item.Almacenamiento + "GB");
            }

            Console.WriteLine("--------------------------------------------------------------------------------");

            var AppleLambda = celularesNuevos.Where(z => z.Marca == "Apple");
            foreach(var item in AppleLambda)
            {
                Console.WriteLine(item.Modelo + "-" + item.Precio);
            }

            Console.WriteLine("--------------------------------------------------------------------------------");

            var AppleLinQ = from marcas in celularesNuevos
                            where marcas.Marca == "Apple"
                            select marcas;
            foreach(var item in AppleLinQ)
            {
                Console.WriteLine(item.Modelo + "-" + item.Precio);
            }

            Console.ReadKey();
        }
    }
}
