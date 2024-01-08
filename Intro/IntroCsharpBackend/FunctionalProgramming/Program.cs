using System;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions functions = new Functions();
            FirstClassFunction firstClassFunction = new FirstClassFunction();

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

           // funtion de orden superior
            var showAction = firstClassFunction.SomeAction;
            showAction(show, "Hola caracola", "Bea");
        }
    }
}


/*//Funcion PURA 
// queno altere el resultado externo y el mismo resultado con la misma entrada

int Sub(int v1, int v2)
{
    return v1 - v2;
}


// No funcional pura porque tomaria el valor de hoy
DateTime GetTomorrow()
{
    return DateTime.Now.AddDays(1);
}DateTime GetTomorrowPuro(DateTime date)
{
    return date.AddDays(1); // ya no depende de un elemento calculado internamente. Externamente le damos la fecha
}
*//**********STRUCT****************************
Una estructura es un tipo de dato que puede contener variables, métodos, propiedades y otros miembros de datos. 
A diferencia de las clases, las estructuras son tipos de valor y se pasan por valor en lugar de por referencia.

Las estructuras se definen utilizando la palabra clave "struct" seguida del nombre de la estructura. 
Dentro de la estructura, se pueden declarar variables y otros miembros de datos. 
struct Persona
{
    public string Nombre;
    public int Edad;
}

// Uso de la estructura
Persona persona1;
persona1.Nombre = "Juan";
persona1.Edad = 25;

Console.WriteLine($"Nombre: {persona1.Nombre}, Edad: {persona1.Edad}");
En este ejemplo, se define una estructura llamada "Persona" que tiene dos miembros de datos: "Nombre" y "Edad". Luego, se crea una variable de tipo "Persona" llamada "persona1" y se asignan valores a sus miembros. Finalmente, se imprime el nombre y la edad de la persona.

Las estructuras son útiles cuando se necesita agrupar datos relacionados en un solo tipo de valor. 
A diferencia de las clases, las estructuras se almacenan en la pila en lugar del montón, 
lo que puede ser beneficioso en términos de rendimiento y uso de memoria.
 
 
 
 *//*


//Se podria clonar el elemento para que sea inmutable
Drink ToUpperPURO(Drink drink)  // no alteraria el objeto drink, 54
{
    var drink2 = new Drink() //  no altera el objeto drink original. Crea un nuevo objeto drink2 con el nombre en mayúsculas y lo devuelve.
    {
        Name = drink.Name.ToUpper(),
    };
    return drink2;
}
Drink ToUpper(Drink drink)  // no pura, alteraria el objeto drink, 54
{
    drink.Name = drink.Name.ToUpper();
    return drink;
}

class Drink
{
    public string Name { get; set; }
}*/

