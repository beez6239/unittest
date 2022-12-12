using Microsoft.VisualStudio.TestTools.UnitTesting;
using BAL;
namespace TestP1
{
    [TestClass]
    public class studentcalTest
    {
        [TestMethod]
        public void getstudents_printoutallstudents()
        {
            //arrange
            var student = new studentcal();
            //act
            var result = student.getstudents();
            
            //Assert
            Assert.IsTrue(result);

        }
    }
}
