using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShopConsole;
using NUnit.Framework;

namespace Tester
{
    [TestFixture]
    public class TesterClass
    {
        FlowerShop shop;

        [SetUp]
        public void Init()
        {
            shop = new FlowerShop();
            shop.AddFlower(new Flower("tulipán", 1500, false));
            shop.AddFlower(new Flower("krizantén", 800, false));
            shop.AddFlower(new Flower("körömvirág", 2800, true));
            shop.AddFlower(new Flower("kaktusz", 1200, true));
            shop.AddFlower(new Flower("rózsa", 900, false));
            shop.AddFlower(new Flower("napraforgóvirág", 400, false));
            shop.AddFlower(new Flower("nárcisz", 1800, false));
        }

        [TestCase]
        public void FlowerAddTest()
        {
            Assert.That(shop.Items.Length == 7);
        }

        [TestCase]
        public void FlowerAddTestAdvanced()
        {
            Flower[] expectedFlowers = new Flower[7];
            expectedFlowers[0] = new Flower("tulipán", 1500, false);
            expectedFlowers[1] = new Flower("krizantén", 800, false);
            expectedFlowers[2] = new Flower("körömvirág", 2800, true);
            expectedFlowers[3] = new Flower("kaktusz", 1200, true);
            expectedFlowers[4] = new Flower("rózsa", 900, false);
            expectedFlowers[5] = new Flower("napraforgóvirág", 400, false);
            expectedFlowers[6] = new Flower("nárcisz", 1800, false);

            Assert.AreEqual(shop.Items, expectedFlowers);
        }

        [TestCase]
        public void FilterTest()
        {
            Flower[] expectedFlowers = new Flower[2];
            expectedFlowers[0] = new Flower("körömvirág", 2800, true);
            expectedFlowers[1] = new Flower("napraforgóvirág", 400, false);

            Flower[] filtered = shop.Filter("virág");

            Assert.AreEqual(filtered, expectedFlowers);
        }


        [TestCase]
        public void FlowerNameExceptionTest()
        {
            Assert.Throws(typeof(ArgumentException), delegate()
            {
                shop.AddFlower(new Flower("a", 100, false));
            });
        }
    }
}
