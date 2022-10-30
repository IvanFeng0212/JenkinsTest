using NUnit.Framework;
using System;
using System.IO;

namespace NUnitTest1
{
    [TestFixture]
    public class Tests
    {
        [Test]
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