using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crea una instancia de contexto
            Modelo.Contexto db = new Modelo.Contexto();

            //crea una instancia de la clase producto
            Modelo.Producto producto1 = new Modelo.Producto { Codigo = 1, Nombre="Mouse", Precio=1250.00 };

            //agregar a la colección (memoria) de Producto
            db.Productos.Add(producto1);

            //grabar en la base de datos
            db.SaveChanges();

            Console.WriteLine($"Producto: {producto1.Nombre} agregado a la base de datos");
            Console.WriteLine("\nPresione una tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
