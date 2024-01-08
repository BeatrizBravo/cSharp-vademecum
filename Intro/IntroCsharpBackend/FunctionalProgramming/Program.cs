using System;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions functions = new Functions();
            FirstClassFunction firstClassFunction = new FirstClassFunction();
            Lambda lambda = new Lambda();

            Console.WriteLine(functions.Sub(1, 2));
            Console.WriteLine(functions.GetTomorrowPuro(DateTime.Now));

            DateTime fechaEnero = new DateTime(2024, 1, 8);
            Console.WriteLine(functions.GetTomorrowPuro(fechaEnero));

            var drink = new Drink()
            {
                Name = "water"
            };
            Console.WriteLine($"drink-originalObject-trasDeclararlo: {drink.Name}");
            Console.WriteLine($"drink-Passing the function-PURA: {functions.ToUpperPURO(drink).Name}");
            Console.WriteLine($"drink-originalObject-despuesFuncionPURA: {drink.Name}");
            Console.WriteLine($"drink-Passing the function-no pura: {functions.ToUpper(drink).Name}");
            Console.WriteLine($"drink-originalObject-despuesFuncion: {drink.Name}");


            /************************        First class function *************/
                 
            var show = firstClassFunction.Show; //sin poner parentesis para guardar la funcion en una variable
            //show("Hola", "Bea");
            var showf = firstClassFunction.showRetrornaAlgo;

           // funtion de orden superior
            var showAction = firstClassFunction.SomeAction;
            showAction(show, "Hola caracola", "Bea");

            var showFunc = firstClassFunction.SomeFunc;
            showFunc(showf, "Hola caracola en Mayuscula", "Beaa");


            Console.WriteLine("-------------Lambda---------------");


        }
    }
}


