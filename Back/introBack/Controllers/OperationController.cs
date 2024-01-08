using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace introBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    // the endpoint se crea en automatico
    public class OperationController : ControllerBase
    {
        [HttpGet]// especificamos que entramos por el metodo get: para obtener algo
        public decimal Get(decimal a, decimal b ) //list all
        {
            return a+b;
        }
        [HttpPost] //create o sumit data a new resource on the server
/*        public decimal Sub(decimal a, decimal b, Numbers numbers)
        {
            return a - b;

        }   */    
        public decimal Sub(Numbers numbers)
        {
            return numbers.A - numbers.B;

        }
        [HttpPut] //update o replace o create a new resource in the server
        public decimal Edit(decimal a, decimal b)
        {
            return a * b;
        } 
        
        [HttpDelete] // delete
        public decimal Delete(decimal a, decimal b)
        {
            return a / b;
        }

        //[HttpPost]//partially update o modify the data, do not create if there is not exits 
    }

    public class Numbers
    {
        public decimal A { get; set;}
        public decimal B { get; set;}   
    }
}
