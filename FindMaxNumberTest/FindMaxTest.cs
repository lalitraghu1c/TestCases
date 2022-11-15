using FindMaximumNumber;
using NUnit.Framework;

namespace FindMaxNumberTest
{
    public class Tests
    {
        FindMaxNumber maxNum = new FindMaxNumber();
        [Test]
        public void GivenMaxFirstNumber_WhenAnalysed_ShouldReturn_FirstMax()
        {
            //AAA- ARRANGE, ACT, ASSERT
            int result = maxNum.FindMaxInteger(20, 15, 5);
            Assert.AreEqual(20, result);
        }
        [Test]
        public void GivenMaxSecondNumber_WhenAnalysed_ShouldReturn_SecondMax()
        {
            int result = maxNum.FindMaxInteger(15, 20, 5);
            Assert.AreEqual(20, result);
        }
        [Test]
        public void GivenMaxThirdNumber_WhenAnalysed_ShouldReturn_ThirdMax()
        {
            int result = maxNum.FindMaxInteger(15, 5, 20);
            Assert.AreEqual(20, result);
        }
        [Test]
        public void GivenMaxFirstNumberFloat_WhenAnalysed_ShouldReturn_FirstMax()
        {
            float result = maxNum.FindMaxFloat(20.20f, 15.15f, 5.5f);
            Assert.AreEqual(20.20f, result);
        }
        [Test]
        public void GivenMaxSecondNumberFloat_WhenAnalysed_ShouldReturn_SecondMax()
        {
            float result = maxNum.FindMaxFloat(15.15f, 20.20f, 5.5f);
            Assert.AreEqual(20.20f, result);
        }
        [Test]
        public void GivenMaxThirdNumberFloat_WhenAnalysed_ShouldReturn_ThirdMax()
        {
            float result = maxNum.FindMaxFloat(15.15f, 5.4f, 20.20f);
            Assert.AreEqual(20.20f, result);
        }
    }
}

/*
AAA
Arrage - Initialization of variables
int a = 50, b = 30, c = 20;
Act - Creation of object and calling particular method
int max = FindMax.MaxInt(a, b, c);
Assest - Validating the output
Assert.AreEqual(max, 50);
*/