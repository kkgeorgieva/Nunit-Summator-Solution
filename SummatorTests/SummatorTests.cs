using NUnit.Framework;

namespace Summator.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_Sum_TwoPositiveNums() {

            int result = Summator.Sum(new int[] {5, 7});

            Assert.That(result == 12);
        }

        [Test]
        public void Test_Sum_OnePositiveNum()
        {

            int result = Summator.Sum(new int[] { 5});

            Assert.That(result == 5);
        }

        [Test]
        [Category("Critical")]
        public void Test_Sum_EmptyArray() {
            int expected = Summator.Sum(new int[] { });
            Assert.That(expected == 0);
        }
        [Test]
        public void Test_Sum_EmptyArra()
        {
            int expected = Summator.Sum(new int[] { });
            Assert.That(expected == 0);
        }
    }

}