using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelLibrary;

namespace MSModelLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Gram G = new Gram(1);
            Ounces O = new Ounces(1);
            Converter Converter = new Converter();

            double gramToOunces = 0.0352739619;
            double ouncesToGram = 28.3495231;


            Assert.AreEqual(gramToOunces, Converter.ConvertToOunces(G));
            Assert.AreEqual(ouncesToGram, Converter.ConvertToGram(O));



        }
    }
}
