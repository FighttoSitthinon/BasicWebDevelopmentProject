using BasicWebDevelopmentProject.Helpers;

namespace BasicWebDevelopmentProject.Tests
{
    public class Test_ValidationHelper
    {
        [SetUp]
        public void Setup()
        {

        }
        [TestCase("4000002500001001", ExpectedResult = true)]   //valid
        [TestCase("4000002500001000", ExpectedResult = false)]  //invalid : invalid card number
        [TestCase("400000250", ExpectedResult = false)]   //invalid : invalid length
        public bool Test_ValidateCreditCard(string value)
        {
            return ValidationHelper.ValidateCreditCard(value);
        }

        [TestCase("1234567890121", ExpectedResult = true)]   //valid
        [TestCase("1234567890120", ExpectedResult = false)]  //invalid : invalid ID
        [TestCase("12345678", ExpectedResult = false)]   //invalid : invalid length
        public bool Test_ValidateCitizen(string value)
        {
            return ValidationHelper.ValidateCitizenId(value);
        }
    }
}
