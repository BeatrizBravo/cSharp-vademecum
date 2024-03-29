﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace introBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        //respuesta de  un tipo especifico, una lista de ppersona
        // pueden entrar por get or all in postman metemos la url/people/all
        [HttpGet("all")]
        public List<People> GetPeople()=> Repository.People;
    }
    public class Repository
    {
        public static List<People> People = new List<People>()
        {
            new People() { Id = 1, Name = "Pedro", Birthdate = new DateTime(1990, 10, 1) },
            new People() { Id = 2, Name = "Juan", Birthdate = new DateTime(1990, 12, 1)},
            new People()  {Id = 3, Name = "Muan", Birthdate = new DateTime(1990, 3, 1) }
        };
    }


    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
    }


}

