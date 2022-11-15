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