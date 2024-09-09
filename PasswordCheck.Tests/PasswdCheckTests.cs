using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PasswordCheck;
namespace PasswordCheck.Tests
{
    [TestClass]
    public class PasswdCheckTests
    {
        [TestMethod]
        public void CheckPassword_A_1ball()
        {
            // Arrange
            string password = "A";
            int expected = 1;  

            //Act
            Passwd passwd = new Passwd();
            int actual = passwd.CheckPassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPassword_aA_2ball()
        {
            string password = "aA";
            int expected =2;

            Passwd passwd = new Passwd();
            int actual = passwd.CheckPassword(password);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPassword_AntonKrugovov_3ball()
        {
            string password = "AntonKrugovov";
            int expected = 3;

            Passwd passwd = new Passwd();
            int actual = passwd.CheckPassword(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckPassword_AntonKrugovov2411_4ball()
        {
            string password = "AntonKrugovov2411";
            int expected = 4;

            Passwd passwd = new Passwd();
            int actual = passwd.CheckPassword(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckPassword_AntonKrugovov2411SpecSim_5ball()
        {
            string password = "AntonKrugovov2411!!!";
            int expected = 5;

            Passwd passwd = new Passwd();
            int actual = passwd.CheckPassword(password);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckPassword_pusto_0ball()
        {
            string password = "";
            int expected = 0;

            Passwd passwd = new Passwd();
            int actual = passwd.CheckPassword(password);

            Assert.AreEqual(expected, actual);
        }
    }
}
