using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PasswordLibraryTests;
using PasswordLibraryVasilyev;

namespace PasswordLibraryTests
{
    [TestClass]
    public class PasswordClassTests
    {
        /// <summary>
        /// Пустая строка возвращает 0 баллов
        /// </summary>
        [TestMethod]
        public void PasswordStrengthCheker_EmptyString_Return0()
        {
            //Arrange
            string password = "";
            int expected = 0;
            //Act
            int action = PasswordClass.PasswordStrengthCheker(password);
            //Assert
            Assert.AreEqual(expected, action);
        }
        /// <summary>
        /// Кириллица возрващает ошибку
        /// </summary>
        [TestMethod]
        public void PasswordStrengthCheker_RussianLetters_ReturnException()
        {
            //Arrange
            string password = "Иванов";
            int expected = 0;
            //Act
            Action action =() => PasswordClass.PasswordStrengthCheker(password);
            //Assert
            Assert.ThrowsException<Exception>(action);
        }
        /// <summary>
        /// Сложный пароль, возрващает 5 баллов
        /// </summary>
        [TestMethod]
        public void PasswordStrengthCheker_5score_Return5()
        {
            //Arrange
            string password = "P2ssw0rd#";
            int expected = 5;
            //Act
            int action = PasswordClass.PasswordStrengthCheker(password);
            //Assert
            Assert.AreEqual(expected, action);
        }
        /// <summary>
        /// Пароль без цифр и символов возвращает 3 балла
        /// </summary>
        [TestMethod]
        public void PasswordStrengthCheker_3score_Return3()
        {
            //Arrange
            string password = "Password";
            int expected = 3;
            //Act
            int action = PasswordClass.PasswordStrengthCheker(password);
            //Assert
            Assert.AreEqual(expected, action);
        }
        /// <summary>
        /// Пароль без спецсимволов возрващает 4 балла
        /// </summary>
        [TestMethod]
        public void PasswordStrengthCheker_4score_Return4()
        {
            //Arrange
            string password = "Passw0ord";
            int expected = 4;
            //Act
            int action = PasswordClass.PasswordStrengthCheker(password);
            //Assert
            Assert.AreEqual(expected, action);
        }
        /// <summary>
        /// Короткий пароль без цифр и спецсиволов возвращает 2 балла
        /// </summary>
        [TestMethod]
        public void PasswordStrengthCheker_2score_Return4()
        {
            //Arrange
            string password = "Passw";
            int expected = 2;
            //Act
            int action = PasswordClass.PasswordStrengthCheker(password);
            //Assert
            Assert.AreEqual(expected, action);
        }

    }
}
