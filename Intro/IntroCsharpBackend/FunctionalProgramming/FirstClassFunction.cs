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
            Console.WriteLine("soy la funcion interna que no retorna cosas, vengo de fuera ");
            Console.WriteLine($"Aqui esta el  show:  {message} {name}");
        }

        //Action = funtion que recibe elementos y no retorna nada como la funcion Show
        public void SomeAction(Action<string, string>show, string message, string name ) 
        {
            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine("Hago algo al incio, hago callback Action");
            show(message, name);//algo en el medio, o hasta que termine = CALLBACK Action
            Console.WriteLine("Algo al final despues de usar otra fuencion externa");
                
         }

        public string showRetrornaAlgo(string message, string name)
        {
            return $"Aqui esta el  show que retora algo:  {message.ToUpper()} {name.ToUpper()}";
        }

        public void SomeFunc(Func<string, string, string> f, string message, string name) //el ultimo parametro dice typo que retorna
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Hago algo al incio, hago callback de una Func porque retorno algo");
            f(message, name);//algo en el medio, o hasta que termine = CALLBACK Func
            Console.WriteLine("Algo al final despues de usar otra fuencion externa");

        }
    }
}
