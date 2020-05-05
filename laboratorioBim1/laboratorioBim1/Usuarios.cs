using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace laboratorioBim1
{
    class Usuarios
    {
        
        static string ruta = "Ususarios.txt";
        static FileStream Archivo;
        static StreamReader leer;
        static StreamWriter escribir;
        
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
                    Console.WriteLine("Que opcion desea realizar:\n1.Crear usuario\n2.Mostrar usuarios\n3.Mostrar inventario\n4.Mostrar Facturas");
                    int admin = int.Parse(Console.ReadLine());
                    if(admin==1) 
                    {
                        crear(llenar("nombre"), llenar("contraseña"));
                    }
                    if (admin == 2)
                    {
                        
                    }
                    if (admin == 3)
                    {
                        Console.WriteLine(buscar(llenar("Ingresar el nombre que desea buscar")));
                    }
                    if (admin == 4)
                    {
                       
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
        }


}
}
