using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorioBim1
{
    class Facturacion
    {
        static string ruta = "factura.txt";
        static StreamWriter escribir;
        static StreamReader leer;

        public void facturacion()
        {
            escribir = File.AppendText(ruta);
            escribir.WriteLine("——————————————————————————————————————————————————————");
            escribir.WriteLine("");
            escribir.WriteLine("");
            escribir.WriteLine("");
            escribir.WriteLine("");
            escribir.WriteLine("               \n\nEMPRESA LOS PATOS"             );
            escribir.WriteLine("             \n\nLOS PATOS S.A Company"              );
            escribir.WriteLine("              ALMACEN LOS PATOS no.67"         );
            escribir.WriteLine("      12 CALLE, 1-25, ZONA 10, LOCAL 213, GUATEMALA");
            escribir.WriteLine("                 CIUDAD DE GUATEMALA                ");
            escribir.WriteLine("                  NIT:992229-0");
            escribir.WriteLine("");
            escribir.WriteLine("                    FACTURA");
            escribir.WriteLine("");
            escribir.WriteLine("           SERIE FC Numero 302270000");
            escribir.WriteLine("");
            escribir.WriteLine("");
            escribir.WriteLine("——————————————————————————————————————————————————————");

            escribir.Close();
            personal(llenar("Nombre del comprador"), llenar("apellido"), llenar("direccion"), llenar("nit"));
            char op = 's';
            while (op != 'n')
            {
                productos(llenar("Nombre del producto"));
                sub();
                Console.WriteLine("Otro  producto [s/n]: ");
                op = char.Parse(Console.ReadLine());
            }


        }
        static string llenar(string dato)
        {
            Console.WriteLine("Ingrese " + dato + ": ");
            return (Console.ReadLine());
        }
        static void personal(string nombre, string apellido, string direccion, string nit)
        {
            escribir = File.AppendText(ruta);
            escribir.WriteLine("NOMBRE: " + nombre);
            escribir.WriteLine("APELLIDO: " + apellido);
            escribir.WriteLine("DIRECCION: " + direccion);
            escribir.WriteLine("NIT: " + nit);
            escribir.Close();
        }
        static void productos(string NombreProducto)
        {
            escribir = File.AppendText(ruta);
            escribir.WriteLine("");
            escribir.WriteLine("Nombre del Producto:  " + NombreProducto);
            escribir.Close();
        }
        static void sub()
        {
            double precio = 0;
            double cant = 0;
            Console.WriteLine("precio");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("cantidad");
            cant = double.Parse(Console.ReadLine());
            escribir = File.AppendText(ruta);
            escribir.WriteLine("");
            escribir.WriteLine("Precio:  " + precio + "  " + "Cantidad:  " + cant);
            double SubTotal = precio * cant;
            double total = 0;
            total = total + SubTotal;
            escribir.WriteLine(" Su Total a pagar es:  " + total);
            escribir.Close();

        }
        public void msfac()
        {
            Console.WriteLine(mostrarFactura(llenar("ENTER")));
        }
        static string mostrarFactura(string nombre)
        {
            string linea = "Usuario no encontrado";
            leer = File.OpenText(ruta);
            linea = leer.ReadToEnd();
            return linea;
        }


    }
}
