using static Dossier2aConvocatoria_SergioVegas.Tema2;

namespace Exercici23
{
    [TestClass]
    public class NumberTests
    {
        [TestMethod]
        public void TestEvenNumber()
        {
            Assert.IsTrue(IsEven(4)); // 4 és parell, ha de retornar true
        }

        [TestMethod]
        public void TestOddNumber()
        {
            Assert.IsFalse(IsEven(7)); // 7 és imparell, ha de retornar false
        }

        [TestMethod]
        public void TestZero()
        {
            Assert.IsTrue(IsEven(0)); // 0 es considera parell, ha de retornar true
        }

        [TestMethod]
        public void TestNegativeEvenNumber()
        {
            Assert.IsTrue(IsEven(-2)); // -2 és parell, ha de retornar true
        }

        [TestMethod]
        public void TestNegativeOddNumber()
        {
            Assert.IsFalse(IsEven(-3)); // -3 és imparell, ha de retornar false
        }
    }
}
