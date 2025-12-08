using Tyuiu.RochevYA.Sprint6.Task0.V25.Lib;
namespace Tyuiu.RochevYA.Sprint6.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.866, ds.Calculate(3));
        }
    }
}
