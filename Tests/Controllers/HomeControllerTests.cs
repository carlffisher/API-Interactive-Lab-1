using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Models;
using NUnit.Framework;


namespace API_Interactive_Lab_1.Tests
{
    public class HomeControllerTests
    {
        [Test]
        public void TestGetHome()
        {

            string expectedContent = "Welcome to the Drinks API!";
        
            var controller = new HomeController();
            var result = controller.Get();

            Assert.AreEqual(expectedContent, result);
        }
        
        /*
        [Test]
        public void TestGetCoffee()
        {

            string expectedContent = "I like coffee!";

            var controller = new CoffeeController();
            var result = controller.Get();

            Assert.AreEqual(expectedContent, result);
        }
        */

        [Test]
        public void Test_Get_Coffee_No_Params()
        {
            Coffee expected = new()
            {
                Name = "latte",
                Id = -1
            };

            var controller = new CoffeeController();
            var result = controller.Get(null);
            
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }

        [Test]
        public void Test_Get_Coffee_Cappuccino()
        {
            string name = "cappuccino";
            
            Coffee expected = new()
            {
                Name = name,
                Id = 7
            };

            var controller = new CoffeeController();
            var result = controller.Get(name);

            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }
    }
}

