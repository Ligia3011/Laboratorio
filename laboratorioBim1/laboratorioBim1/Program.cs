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
            Console.WriteLine("            Sistema de la  Empresa LOS PATOS            ");
            Console.WriteLine("   EMPRESA LOS PATOS La mejor empresa de aparatos electronicos   ");


            char op = 'n';
            while(op! == 's')
            {
               
                    usu.UsuaPri();
                
                
                Console.WriteLine("Desea salir [s/n]");
                op = char.Parse(Console.ReadLine());




            }
        } 
    }
    
}