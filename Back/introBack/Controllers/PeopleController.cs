using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace introBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {

    }



    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
    }


}

