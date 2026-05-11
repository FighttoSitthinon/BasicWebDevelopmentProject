using BasicWebDevelopmentProject.Helpers;

namespace BasicWebDevelopmentProject.Tests
{
    public class Test_ValidationHelper
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void test_card_validation_1()
        {
            string card_id = "4549420001927672";
            Assert.That(ValidationHelper.ValidateCreditCard(card_id), Is.EqualTo(true));
        }
        [Test]
        public void test_card_validation_2()
        {
            string card_id = "4549420001927671";
            Assert.That(ValidationHelper.ValidateCreditCard(card_id), Is.EqualTo(false));
        }
        [Test]
        public void test_card_validation_3()
        {
            string card_id = "532352";
            Assert.That(ValidationHelper.ValidateCreditCard(card_id), Is.EqualTo(false));
        }
        [Test]
        public void test_id_validation_1()
        {
            string card_id = "8121389985207";
            Assert.That(ValidationHelper.ValidateCitizenId(card_id), Is.EqualTo(true));
        }
        [Test]
        public void test_id_validation_2()
        {
            string card_id = "8121389985201";
            Assert.That(ValidationHelper.ValidateCitizenId(card_id), Is.EqualTo(false));
        }
        [Test]
        public void test_id_validation_3()
        {
            string card_id = "23423";
            Assert.That(ValidationHelper.ValidateCitizenId(card_id), Is.EqualTo(false));
        }
    }
}
