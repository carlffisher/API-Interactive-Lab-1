using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Models;
using NUnit.Framework;


namespace API_Interactive_Lab_1.Tests
{
    public class CocktailControllerTests
    {
        [Test]
        public void Test_Get_Cocktail_No_Params()
        {
            Models.Cocktail expected = new()
            {
                Advice = "I think this is perfect for you!",
                Name = "Dry Martini",
                Ingredient1 = "Vermouth",
                Ingredient2 = "Gin not vodka",
                Ingredient3 = "Vodka not gin",
                Price = 10
            };

            var controller = new CocktailController();
            var result = controller.Get(null);

            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Ingredient1, result.Ingredient1);
            Assert.AreEqual(expected.Ingredient2, result.Ingredient2);
            Assert.AreEqual(expected.Ingredient3, result.Ingredient3);
            Assert.AreEqual(expected.Price, result.Price);
        }

        [Test]
        public void Test_Get_Favourite_Cocktail()
        {
            string name = "Favourite";


            Models.Cocktail expected = new()
            {
                Advice = "It's our most popular",
                Name = "Dry Martini",
                Ingredient1 = "Vermouth",
                Ingredient2 = "Gin not vodka",
                Ingredient3 = "Vodka not gin",
                Price = 10
            };

            var controller = new CocktailController();
            var result = controller.Get(name);

            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Ingredient1, result.Ingredient1);
            Assert.AreEqual(expected.Ingredient2, result.Ingredient2);
            Assert.AreEqual(expected.Ingredient3, result.Ingredient3);
            Assert.AreEqual(expected.Price, result.Price);
        }

        public void Test_Get_A_Cocktail()
        {
            string name = "Margarita";

            Models.Cocktail expected = new()
            {
                Advice = "Perfect for this time of year!",
                Name = name,
                Ingredient1 = "Tequila",
                Ingredient2 = "Triple Sec",
                Ingredient3 = "Lime Juice",
                Price = 15
            };

            var controller = new CocktailController();
            var result = controller.Get(name);

            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Ingredient1, result.Ingredient1);
            Assert.AreEqual(expected.Ingredient2, result.Ingredient2);
            Assert.AreEqual(expected.Ingredient3, result.Ingredient3);
            Assert.AreEqual(expected.Price, result.Price);
        }

        public void Test_Get_An_Unavailable_Cocktail()
        {
            string name = "Bloody Mary";

            Models.Cocktail expected = new()
            {
                Advice = "Sorry, we don't sell that. Can I suggest our most popular cocktail?",
                Name = "Dry Martini",
                Ingredient1 = "Vermouth",
                Ingredient2 = "Gin not vodka",
                Ingredient3 = "Vodka not gin",
                Price = 10
            };

            var controller = new CocktailController();
            var result = controller.Get(name);

            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Ingredient1, result.Ingredient1);
            Assert.AreEqual(expected.Ingredient2, result.Ingredient2);
            Assert.AreEqual(expected.Ingredient3, result.Ingredient3);
            Assert.AreEqual(expected.Price, result.Price);
        }

    }
}


