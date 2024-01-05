//Sale sale = new Sale();
var sale = new Sale(15); //azucar sintactica, escribir mas facil y mas legible, no var sino no repetir nombre clase
var message = sale.GetInfo();

Console.WriteLine(message);


class Sale
{
    public decimal Total { get; set; }

    //constructor para obligar a que reciba algo
    public Sale(decimal total)
    { this.Total = total; }

    public string GetInfo()
    {
        return $" Total = {Total}";
    }

}