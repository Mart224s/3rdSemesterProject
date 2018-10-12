using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeightConvertLibrary;


namespace UnitTestingWeightConverter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        // Expected to pass
        public void OzToGrams()
        {
            Assert.AreEqual(2834.9523125, WeightConverter.OzToGrams(100), 0.0001);
        }

        [TestMethod]
        // Expected to pass
        public void GramsToOz()
        {
            Assert.AreEqual(3.527396195, WeightConverter.GramsToOz(100), 0.0001);
        }
        
         
      
 


    }
}
