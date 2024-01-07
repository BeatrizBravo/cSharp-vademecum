//GENERIC =  ayuda a crear clases genericas
// Ayuda a reutilizr codigo tanto en metodo como clases, es comun en collecciones






var numbers = new MyList<int>(5); // al crear el objeto recien le pasamos el tipo
var names = new MyList<string>(5);
var colors = new MyList<Colors>(3);

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);

Console.WriteLine(numbers);
Console.WriteLine();
Console.WriteLine(numbers.GetContent());


names.Add("one");
names.Add("two");
names.Add("three");
Console.WriteLine(names.GetContent());

colors.Add(new Colors()    
    {
        Color = "Red",
        Price = 5

    });
colors.Add(new Colors()    
    {
        Color = "Black",
        Price = 5

    });

Console.WriteLine(colors.GetContent());

public class MyList<T> //T = standard es T para decir que nuestro tipo de dato es generico osea desconocido

{
    private List<T> _list; //_ guin bajo = porque es privado // reserva la memoria para el objeto, NO la CREA
    private int _limit; // pa la longitud dela lista

    public MyList(int limit) //lista de elementos limita con este metodo
    {
        _limit = limit;
        _list = new List<T>(); //aqui CREA el objeto
    }

    public void Add(T element)
    {
        if (_list.Count < _limit) 
        { 
        _list.Add(element);
        }
    }

    public string GetContent() //imprime lalista
    {
        string content = "";
        foreach (var element in _list)
        {
            content += element +" , ";   
        }
        return content;
    }












}


public class Colors
{
    public string Color { get; set; }
    public int Price { get; set; }

    //Todas las clases heredan de Object
    public override string ToString()
    {
        return Color;
    }
    // los objetos no tienen el dato como los tipos nativos y como queremos imprimir hacemos cast
}
