using API_Interactive_Lab_1.Models;
using Microsoft.AspNetCore.Mvc;


namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    
    [Route("cocktail")]
    public class CocktailController : ControllerBase
    {
        [HttpGet("Favourite")]
        public Cocktail GetFavourite(string? name)
        {
            return new Cocktail
            {
                Advice = "It's our most popular",
                Name = "Dry Martini",
                Ingredient1 = "Vermouth",
                Ingredient2 = "Gin not vodka",
                Ingredient3 = "Vodka not gin",
                Price = 10
            };
        }

        [HttpGet("{name}")]
        public Cocktail Get(string? name)
        {
            if (name == null)
            {
                return new Cocktail
                {
                    Advice = "I think this is perfect for you!",
                    Name = "Dry Martini",
                    Ingredient1 = "Vermouth",
                    Ingredient2 = "Gin not vodka",
                    Ingredient3 = "Vodka not gin",
                    Price = 10
                };
            }
            
            if (name == "Margarita")
            {
                return new Cocktail
                {
                    Advice = "Perfect for this time of year!",
                    Name = name,
                    Ingredient1 = "Tequila",
                    Ingredient2 = "Triple Sec",
                    Ingredient3 = "Lime Juice",
                    Price = 15
                };
            }

            if (name == "Manhatten")
            {
                return new Cocktail
                {
                    Advice = "Well, we are in New York",
                    Name = name,
                    Ingredient1 = "Rye Whisky",
                    Ingredient2 = "Sugar",
                    Ingredient3 = "Lemon Juice",
                    Price = 15
                };

            }
            else
            {
                return new Cocktail
                {
                    Advice = "Sorry, we don't sell that. Can I suggest our most popular cocktail?",
                    Name = "Dry Martini",
                    Ingredient1 = "Vermouth",
                    Ingredient2 = "Gin not vodka",
                    Ingredient3 = "Vodka not gin",
                    Price = 10
                };
            }
        }
    }
}
