using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TDDtest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //mutiple test entry into our data row, to cross check and confirm the program is solid
        [DataRow("50","5", "250")]
        [DataRow("25", "4", "56")]
        [DataRow("20", "5","100")]
        public void AreaCalculatorTest(string length, string width, string espectedResult)
        {
            double lengt = double.Parse(length);
            double widt = double.Parse(width);
            double expRslt = double.Parse(espectedResult);
            var recArea = new RecArea();
            double result = recArea.AreaCalculatorTest(lengt, widt);
            Assert.AreEqual(expRslt,result); //checks the expected result against the actual result
        }
    }
}

