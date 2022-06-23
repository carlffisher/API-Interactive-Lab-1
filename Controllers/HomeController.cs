﻿using API_Interactive_Lab_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    // [Route("[controller]")]
    // [Route("Noodles")]
    // [Route("/")]

    [Route("Home/Index")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Welcome to the Drinks API!";
        }
    }

    [Route("coffee")]
    public class CoffeeController : ControllerBase
    {
        [HttpGet("{name}")]
        public Coffee Get(string? name)
        {
            return new Coffee { Id = (name != null ? 7 : -1), Name = name ?? "latte" };
        }

        [HttpGet("lover")]
        public string GetCoffeeLover()
        {
            return "I like coffee!";
        }
    }

    /*
    [Route("coffee/lover")]
    public class CoffeeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "I like coffee!";
        }
    }
    */

}