using System.Text.Json;


var BB = new People()
{
    Name = "Bea",
    Age = 20,
};

// Serializacion

string json = JsonSerializer.Serialize(BB);
Console.WriteLine(@"
========Serializando un Json de un objeto convertirlo a Json
");
Console.WriteLine(json);
Console.WriteLine();

//deserializacion
//lleva doble comilla para que c# sepa que es una doble comilla ya que antes empezo con @"
string myjson = @"
{
    ""Name"":""Bea"",
    ""Age"":20}

";
// ponemos ? para indicar que puede que el json venga vacio
People? myPerson = JsonSerializer.Deserialize<People>(myjson);


Console.WriteLine(@"
========Deserializando un Json hacia un objeto en c#
");
Console.WriteLine(myPerson?.Name);
Console.WriteLine(myPerson?.Age);

public class People
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Lo statico pertence a la clase y se puede invocar directamente, por ejemplo People.Get(); sin crear objeto
}