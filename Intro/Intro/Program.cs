using System;
using System.Reflection.Metadata;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {

            Salutations.Salutation();
                        Grades.Grade();

            // Esperar la entrada del usuario antes de cerrar la ventana de la consola
            Console.ReadLine();
        }
    }
}
