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
            Assert.AreEqual("t", "t");
        }

        [TestMethod]
        public void Pokemonx()
        {
            Assert.AreEqual("tt", "tt");
        }

        [TestMethod]
        public void TesteNovo()
        {
            Assert.AreEqual("a", "a");
        }

        [TestMethod]
        public void TesteMaisTeste()
        {
            Assert.AreEqual("a", "a");
        }
    }
}
