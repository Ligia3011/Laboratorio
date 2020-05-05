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
            Console.WriteLine("Que area desea visualizar:\n\n1.Usuarios\n2.Inventario\n3.Facturas");
            int res = int.Parse(Console.ReadLine());

            char op = 'n';
            while(op! == 's')
            {
                if (res == 1)
                {
                    usu.UsuaPrinc();
                }
                if (res == 2)
                {
                    Console.WriteLine("Inventario de Empresa LOS PATOS");
                }
                if (res == 3)
                {

                }




            }
    }
    }
}