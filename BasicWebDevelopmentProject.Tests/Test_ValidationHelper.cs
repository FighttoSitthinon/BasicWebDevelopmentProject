using BasicWebDevelopmentProject.Helpers;

namespace BasicWebDevelopmentProject.Helpers
{
    public class Test_ValidationHelper
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void ValidateCitizenId_Ture()
        {
            string id1="1234567890121";                       
            bool result =  ValidationHelper.ValidateCitizenId(id1);         
            Assert.That(result,Is.True);

            string id2="3535311854243";
            bool result2 =  ValidationHelper.ValidateCitizenId(id2);         
            Assert.That(result2,Is.True);
        }

        [Test]
        public void ValidateCitizenId_False()
        {
            string id1="1234567890123";           
            bool result =  ValidationHelper.ValidateCitizenId(id1);         
            Assert.That(result,Is.False);

            string id2="3453454351115";
            bool result2 =  ValidationHelper.ValidateCitizenId(id2);         
            Assert.That(result2,Is.False);
        }

        [Test]
        public void ValidateCreditCard_Ture()
        {
            string id1="4360000001000005";                       
            bool result =  ValidationHelper.ValidateCreditCard(id1);         
            Assert.That(result,Is.True);

            string id2="4571000000000001";
            bool result2 =  ValidationHelper.ValidateCreditCard(id2);         
            Assert.That(result2,Is.True);
        }

        [Test]
        public void ValidateCreditCard_False()
        {
            string id1="1234567890123123";           
            bool result =  ValidationHelper.ValidateCreditCard(id1);         
            Assert.That(result,Is.False);

            string id2="3453454351115555";
            bool result2 =  ValidationHelper.ValidateCreditCard(id2);         
            Assert.That(result2,Is.False);
        }
    }
}
