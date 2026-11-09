using System.IO;
using Tyuiu.FedorovskikhEO.Sprint5.Task0.V28.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint5.Task0.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), " OutPutFileTask0.txt");

            FileInfo fileInfo = new FileInfo(path);
            DataService ds= new DataService();
            ds.SaveToFileTextData(3);

            bool fileExists = fileInfo.Exists;


            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
