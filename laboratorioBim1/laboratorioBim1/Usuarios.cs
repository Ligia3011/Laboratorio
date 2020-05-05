using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace laboratorioBim1
{
    class Usuarios
    {
        Inventario inve = new Inventario();
        static string ruta = "Ususarios.txt";
        Facturacion fact = new Facturacion();
        static StreamReader leer;
        static StreamWriter escribir;

        static void u()
        {
            escribir = File.AppendText(ruta);
            escribir.WriteLine("Admin01");
            escribir.Close();
        }

        public void UsuaPrinc()
        {
            Console.WriteLine("El usuario que requiere es administrador o trabajador [A/T]");
            char user1 = char.Parse(Console.ReadLine());
            if(user1== 'A') 
            {
                Console.WriteLine("Ingrese la contraseña del usuario");
                int password = int.Parse(Console.ReadLine());
                if(password==789) 
                {
                    Console.WriteLine("Que opcion desea realizar:\n1.Crear usuario\n2.Mostrar inventario\n3.Mostrar usuarios\n4.Mostrar Facturas");
                    int admin = int.Parse(Console.ReadLine());
                    if(admin==1) 
                    {
                        crear(llenar("nombre"), llenar("contraseña"));
                    }
                    if (admin == 2)
                    {
                        inve.mostrarinv();
                    }
                    if (admin == 3)
                    {
                        Console.WriteLine(buscar(llenar("Ingresar el nombre que desea buscar")));
                    }
                    if (admin == 4)

                    {
                        fact.mostrarfac();
                    }
                    else
                    {
                        Console.WriteLine("Usuario NO AUTORIZADO");
                    }
                    static void crear(string nombre, string contraseña)
                    {
                        escribir = File.AppendText(ruta);
                        escribir.WriteLine(nombre + "" + contraseña);
                        escribir.Close();

                           

                    }
                    static string llenar(string dato)
                    {
                        Console.WriteLine("Ingresar"+dato+ ":");
                        return (Console.ReadLine());



                    }
            }
            static string buscar(string dato)
            {
                string linea = "Usuario no encontrado";
                leer = File.OpenText(ruta);
                linea = leer.ReadToEnd();
                return linea;

        }
            }
            else if(user1== 'T')
            {
                Console.WriteLine("Ingrese la contraseña del usuario");
                int password = int.Parse(Console.ReadLine());
                if (password == 456) 
                {
                    Console.WriteLine("Que opcion desea realizar:\n1.Cargar Inventario\n2.Mostrar Facturas");
                    int trab = int.Parse(Console.ReadLine());
                    if (trab == 1) 
                    {
                        inv.ingreso();
                    }
                    if (trab == 2)
                    {
                        fact.Facturacion();
                    }
                    else
                    {
                        Console.WriteLine("Usted no esta autorizado para ingresar a esta area");
                    }
                }
            }
            static void crear(string nombre, string contrasena, string cargo)
            {
                escribir = File.AppendText(ruta);
                escribir.WriteLine(nombre + " " + contrasena + " " + cargo);
                escribir.Close();
            }
            static string llenar(string dato)
            {
                Console.WriteLine("ingrese " + dato + ":");
                return (Console.ReadLine());
            }
            static string mostrarUsuario(string nombre)
            {
                string linea = "Contacto no encontrado";
                leer = File.OpenText(ruta);
                linea = leer.ReadToEnd();
                return linea;
            }
        }


}
}
