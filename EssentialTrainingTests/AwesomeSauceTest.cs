using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;


namespace EssentialTrainingTests
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSausce();
            testInstance.sauses.Add("Tobasco");
            testInstance.sauses.Add("Cholula");
            testInstance.sauses.Add("Trailer Trash");

            //Expected to pass
            Assert.IsTrue(testInstance.IsSauceAwesome("Trailer Trash"));
            //Expected to fail
            Assert.IsFalse(testInstance.IsSauceAwesome("Ketchup"));
        }
    }
}
