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
                escribir.WriteLine("Admin#1");
                escribir.Close();
            }
            public void UsuaPri()
            {

                Console.WriteLine("Su puesto es de Administrador o Trabajador [A/T]");
                char user = char.Parse(Console.ReadLine());
                if (user == 'A')
                {

                    Console.WriteLine("Ingrese la contrasena");
                    int password = int.Parse(Console.ReadLine());
                    if (password ==122 )
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
                            Console.WriteLine(mostrarUsuario(llenar("Ingrese el nombre del usuario que desea buscar")));
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
                        Console.WriteLine("Que desea realizar?\n1.cargar inventario\n2.Facturar producto");
                        int admi = int.Parse(Console.ReadLine());
                        if (admi == 1)
                        {
                            inve.ingreso();
                        }
                        else if (admi == 2)
                        {
                            fact.facturacion();
                        }

                    }
                    else
                    {
                        Console.WriteLine("Usuario NO AUTORIZADO");
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
                Console.WriteLine("Ingrese " + dato + ":");
                return (Console.ReadLine());
            }
            static string mostrarUsuario(string nombre)
            {
                string linea = "Usuario no encontrado";
                leer = File.OpenText(ruta);
                linea = leer.ReadToEnd();
                return linea;
            }

        }
    }




