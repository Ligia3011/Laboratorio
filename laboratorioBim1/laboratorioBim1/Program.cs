using System;

namespace laboratorioBim1
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuarios usu = new Usuarios();
            Inventario inve = new Inventario();
            Facturacion fact = new Facturacion();
            Console.WriteLine("Sistema de ventas de Empresa LOS PATOS");
            

            char op = 'n';
            while(op! == 's')
            {
               
                    usu.UsuaPrinc();
                
                
                Console.WriteLine("Desea salir [s/n]");
                op = char.Parse(Console.ReadLine());




            }
        } 
    }
    
}