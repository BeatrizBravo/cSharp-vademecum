using System;
using Objetos.Models;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida("Test", 1000);
            //bebida.Name = "Test";
            bebida.Beberse(500);
            Console.WriteLine(bebida.Cantidad);
            Console.ReadLine();


        }
    }
}