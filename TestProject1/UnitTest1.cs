using h32.Controllers;
using h32.Data;
using h32.Models;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        /*[SetUp]
        public void Setup()
        {
        }
*/
        [Test]
        public void Test1()
        {
            var lap = new Laptop();
            lap.Price = 200; 
            Assert.AreEqual(200, lap.Price);
        }
        [Test]
        public void Test2()
        {
            h32Context con = new h32Context();
            HomeController cont = new HomeController();

            
            Assert.IsNotNull(cont.Index());

        }
    }
}