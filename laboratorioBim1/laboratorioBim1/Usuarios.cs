using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace laboratorioBim1
{
    
        class Usuarios
        {
            Inventario inve = new Inventario();
            Facturacion fact = new Facturacion();
            static string ruta = "Usuarios.txt";
            static StreamReader leer;
            static StreamWriter escribir;
            static void u()
            {
                escribir = File.AppendText(ruta);
                escribir.WriteLine("Admin01");
                escribir.Close();
            }
            public void UsuaPri()
            {

                Console.WriteLine("Su puesto es de Administrador o Trabajador [A/T]");
                char user = char.Parse(Console.ReadLine());
                if (user == 'A')
                {

                    Console.WriteLine("Ingrese la contrasena");
                    int contra = int.Parse(Console.ReadLine());
                    if (contra == 123)
                    {
                        Console.WriteLine("Que desea hacer?\n1.Crear usuario\n2.Mostrar Inventario\n3.Mostrar Usuarios\n4. Mostrar Facturas");
                        int admin = int.Parse(Console.ReadLine());
                        if (admin == 1)
                        {
                            crear(llenar("nombre"), llenar("contrasena"), llenar("cargo"));

                        }
                        if (admin == 2)
                        {
                            inve.mostrarinv();
                        }
                        if (admin == 3)
                        {
                            Console.WriteLine(mostrarUsuario(llenar("ingrese nombre a buscar")));
                        }
                        if (admin == 4)
                        {
                            fact.msfac();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Usted no esta autorizado para ingresar a esta area");
                    }
                }
                else if (user == 'T')
                {
                    Console.WriteLine("Ingrese la contrasena");
                    int contra = int.Parse(Console.ReadLine());
                    if (contra == 456)
                    {
                        Console.WriteLine("Que desea hacer?\n1.cargar inventario\n2.Facturar producto");
                        int admin = int.Parse(Console.ReadLine());
                        if (admin == 1)
                        {
                            inve.ingreso();
                        }
                        else if (admin == 2)
                        {
                            fact.facturacion();
                        }

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




