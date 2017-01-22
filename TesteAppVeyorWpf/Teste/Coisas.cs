using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teste
{
    [TestClass]
    public class Coisas
    {
        [TestMethod]
        public void Soma()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void Pokemon()
        {
            Assert.AreEqual("Charmander", "Charmander");
        }
    }
}
