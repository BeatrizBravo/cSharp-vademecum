//Sale sale = new Sale();
var sale = new Sale(15); //azucar sintactica, escribir mas facil y mas legible, no var sino no repetir nombre clase
var message = sale.GetInfo();

Console.WriteLine(message);


var saleWithTax = new SaleWithTax(20);
//var infoTax = saleWithTax.GetInfoWithTax();
var infoTax = saleWithTax.GetInfo();
Console.WriteLine(infoTax);
var getInfoOverload = saleWithTax.GetInfo(4);
Console.WriteLine(getInfoOverload);




class Sale //papa
{
    public decimal Total { get; set; }

    //constructor para obligar a que reciba algo
    public Sale(decimal total)
    { this.Total = total; }

    public virtual string GetInfo() // para dejar que luego lo OVERRIDE el hijo
    {
        return $"Total without tax = {Total}";
    }

}

class SaleWithTax : Sale //hijo
{
    // adding more
    public decimal Tax { get; set; }

    // sale from creation, father, force to have on element called total
    //constructor
    public SaleWithTax(decimal total) : base(total) //mandamos al padre
    {

    }

    //modificamos el metodo de papa "GetInfo" que tendra la keyword Virtual
    public override string GetInfo()
    {
        return $"Total with Tax = {Total} \t with  Tax = {Tax}";
    }

    // adding more // ya no es necesario porque modificamos GetInfo ya que hace la misma accion
    /*    public string GetInfoWithTax()
        {
            return $"Total with Tax = {Total} \n Tax = {Tax}";
        }*/


    // sobrecarga, metodo con el mismo nombre pero con diferente entrada de datos
    public  string GetInfo( int a)
    {
        return $"overload parameter is  {a.ToString()}";
    }
}