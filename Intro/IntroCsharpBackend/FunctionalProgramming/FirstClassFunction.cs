using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FunctionalProgramming
{
    internal class FirstClassFunction
    {
        public void Show(string message, string name)
        {
            Console.WriteLine("soy la funcion interna, vengo de fuera ");
            Console.WriteLine($"Aqui esta el  show:  {message} {name}");
        }

        //Action = funtion que recibe elementos y no retorna nada como la funcion Show
        public void SomeAction(Action<string, string>show, string message, string name ) 
        {
            Console.WriteLine("Hago algo al incio, hago callback");
            show(message, name);//algo en el medio, o hasta que termine = CALLBACK Action
            Console.WriteLine("Algo al final despues de usar otra fuencion externa");
                
         }
    }
}
