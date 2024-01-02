using System;
using Objetos.Models;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida("Daddy", 1200); 
            //bebida.Name = "Test";
            bebida.Beberse(500);
            Console.WriteLine(bebida.Name);
            Console.WriteLine(bebida.Cantidad);
            Console.WriteLine("++++++++++++++");
            /*            Console.ReadLine();
            */
            Orange orange = new Orange(2000); //hijo
            orange.Beberse(500);
            Console.WriteLine(orange.Name);
            Console.WriteLine(orange.Cantidad);
            Console.ReadLine();

        }
    }
}