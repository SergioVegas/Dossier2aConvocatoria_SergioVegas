using static Dossier2aConvocatoria_SergioVegas.Tema2;

namespace Exercici24
{
    public class OddTest
    {
        [Fact]
        public void TestOddNumber()
        {
            Assert.True(IsOdd(7)); // 7 és senar, ha de retornar true
        }

        [Fact]
        public void TestEvenNumber()
        {
            Assert.False(IsOdd(4)); // 4 és parell, ha de retornar false
        }

        [Fact]
        public void TestZero()
        {
            Assert.False(IsOdd(0)); // 0 és parell, ha de retornar false
        }

        [Fact]
        public void TestNegativeOddNumber()
        {
            Assert.True(IsOdd(-3)); // -3 és senar, ha de retornar true
        }

        [Fact]
        public void TestNegativeEvenNumber()
        {
            Assert.False(IsOdd(-2)); // -2 és parell, ha de retornar false
        }
    }
}
