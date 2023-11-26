using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GofmanDV.Sprint5.Task7.V20.Lib;

namespace Tyuiu.GofmanDV.Sprint5.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\slava\source\repos\Tyuiu.GofmanDV.Sprint5\Tyuiu.GofmanDV.Sprint5.Task7.V20\bin\Debug\OutPutDataFileTask7V20.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
