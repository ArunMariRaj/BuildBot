using BuildBotTrial;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BuildBotTrial.Tests
{
    [Binding]
    public class BuildBotTrialFeatureSteps
    {
        Calculator calculator = new Calculator();

        public int Result { get; private set; }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int firstNumber)
        {
            calculator.FirstNumber = firstNumber;
        }

        [Given(@"I also have entered (.*) into the calculator")]
        public void GivenIAlsoHaveEnteredIntoTheCalculator(int secondNumber)
        {
            calculator.SecondNumber = secondNumber;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Result = calculator.Add();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int Expected)
        {
            Assert.AreEqual(Expected, Result);
        }
    }
}
