using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace MSTest1
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Main_Exec_Success()
        {
            // Arrange
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                JenkinsTest.Program.Main();

                var res = sw.ToString().Trim();

                // Assert
                Assert.AreEqual("Hello World!", res);
            }
        }
    }
}