using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace introBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    // the endpoint se crea en automatico
    public class OperationController : ControllerBase
    {
        [HttpGet]// especificamos que entramos por get
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
