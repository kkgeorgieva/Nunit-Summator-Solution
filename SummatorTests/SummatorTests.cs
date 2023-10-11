using NUnit.Framework;

namespace Summator.Tests
{
    [TestFixture]
    public class Tests
    {
        private Summator summator;

        [SetUp]
        public void SetUp() {
            summator = new Summator();
        }

        [Test]
        public void Test_Sum_TwoPositiveNums() {

            int result = summator.Sum(new int[] {5, 7});

            Assert.That(result == 12);
         
        }

        [Test]
        public void Test_Sum_OnePositiveNum()
        {

            int result = summator.Sum(new int[] { 5});

            Assert.That(result == 5);
        }

        [Test]
        [Category("Critical")]
        public void Test_Sum_EmptyArray() {
            int expected = summator.Sum(new int[] { });
            Assert.That(expected == 0);
        }
      
    }

}