using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace laboratorioBim1
{
    class Inventario

    {
        Facturacion fact = new Facturacion();
        static string ruta = "inventario.txt";
        static StreamWriter escribir;
        static StreamReader leer;
        public int cantidad;
        public void mostrarinv()
        {
            Console.WriteLine(mostrarInventario(llenar("ENTER")));
        }
        public void ingreso()
        {
            escribir = File.AppendText(ruta);
            Console.WriteLine("Por Favor Ingresar datos del producto");
            Console.WriteLine("Ingrese fecha");
            string fecha = Console.ReadLine();
            escribir.WriteLine(fecha);
            Console.WriteLine("Ingrese nombre del producto");
            string producto = Console.ReadLine();
            escribir.WriteLine(producto);
            Console.WriteLine("Ingrese el precio del producto");
            string precio = Console.ReadLine();
            escribir.WriteLine(precio);
            Console.WriteLine("Ingrese la cantidad  del producto");
            cantidad = int.Parse(Console.ReadLine());
            escribir.WriteLine(cantidad);
            escribir.Close();
        }
        static string mostrarInventario(string nombre)
        {
            string linea = "Contacto no encontrado";
            leer = File.OpenText(ruta);
            linea = leer.ReadToEnd();
            return linea;
        }
        static string llenar(string dato)
        {
            Console.WriteLine("ingrese " + dato + ":");
            return (Console.ReadLine());
        }

        public void dardebajaprod()
        {
            mostrarinv();
            Console.WriteLine("Ingresar la cantidad que desea que se descuente en el inventario");
            int desc = int.Parse(Console.ReadLine());
            int cambio = cantidad - desc;
        }







    }
}
