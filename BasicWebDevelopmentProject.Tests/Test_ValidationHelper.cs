using BasicWebDevelopmentProject.Helpers;

namespace BasicWebDevelopmentProject.Tests
{
    public class Test_ValidationHelper
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("4549420001927672", true)] // Valid
        [TestCase("4549420001927671", false)] // Valid: wrong number
        [TestCase("532352", false)] // Invalid: wrong length
        public void test_card_validation(string value, bool expected)
        {
            bool result = ValidationHelper.ValidateCreditCard(value);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("8121389985207", true)] // Valid
        [TestCase("8121389985201", false)] // Valid: wrong number
        [TestCase("23423", false)] // Invalid: wrong length
        public void test_id_validation(string value, bool expected)
        {
            bool result = ValidationHelper.ValidateCitizenId(value);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
