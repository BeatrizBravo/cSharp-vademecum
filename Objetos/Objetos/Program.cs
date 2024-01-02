using System;
using Objetos.Models;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida("Test", 1200); //papa
            //bebida.Name = "Test";
            bebida.Beberse(500);
            Console.WriteLine(bebida.Cantidad);
            /*            Console.ReadLine();
            */
            Orange orange = new Orange(2000); //hijo
            orange.Beberse(500);
            Console.WriteLine(orange.Cantidad);
            Console.ReadLine();

        }
    }
}