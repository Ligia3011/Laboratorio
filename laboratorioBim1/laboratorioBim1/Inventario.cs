using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace laboratorioBim1
{
    class Inventario

    {
        static string ruta = "Inventario.txt";
        static FileStream Archivo;
        static StreamReader leer;
        static StreamWriter escribir;

        static string inventario = "Inventario.txt";
        static string inventario2 = "Inventario2.txt";
        static string facturas1 = "Fcturas.txt";
        static FileStream Archivo;
        static StreamReader Leer;
        static StreamWriter Escribir;

        public void ingresar() 
        {
            Escribir = File.AppendText(ruta);
            Console.WriteLine("Ingrese los datos correspondientes al inventario");
            Console.WriteLine("Ingrese el nombre del producto");
            string producto = Console.ReadLine();
            Escribir.WriteLine("" + producto);
            Console.WriteLine("Ingrese el precio del producto");
            string precio = Console.ReadLine();
            Escribir.WriteLine("" + precio);
            Console.WriteLine("Ingrese la cantidad del producto");
            string cantidad = Console.ReadLine();
            Escribir.WriteLine("" + cantidad);

        }




    }
}
