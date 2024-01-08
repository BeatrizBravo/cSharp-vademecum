// trabaja con colecciones de manera declarativa
//3 partes, /*
//origen de collection of data (list),
//consutation(nameResul => es un nuevo objeto que crea y devuelve ) and
//ejecution (foreach)

using static System.Runtime.InteropServices.JavaScript.JSType;

var names = new List<string>()
{
    "B1", "B5", "B30", "B4800", "B2000000"

};

var nameResult = from n in names
                 where n.Length > 2 && n.Length < 6
                 orderby n descending
                 select n;

foreach (var name in nameResult)
{
    Console.WriteLine($" with Linq = {name}");
}

// por detras ejecuta funciones como
var namesREsult2 = names.Where(n => n.Length > 2 && n.Length<6)
                        .OrderByDescending(n =>n)
.Select(d=>d);

foreach (var name in namesREsult2)
{
    Console.WriteLine($" with anonymous function = {name}");
}