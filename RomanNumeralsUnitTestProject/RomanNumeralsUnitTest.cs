using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roman_Numerals;

namespace RomanNumeralsUnitTestProject
{
    [TestClass]
    public class RomanNumeralsUnitTest
    {

        //Unit Test to check if program runs when UserInput is a number between 1 and 3999
        [TestMethod]
        public void CheckValidNumber()
        {
            int UserInput = 45;

           Converter C = new Converter();
           string output = C.generate(UserInput);

            Assert.AreEqual("XLV", output);


        }

        //Unit Test to check if program identifies that any number above 3999 is invalid
        [TestMethod]
        public void CheckInvalidNumberAbove3999()
        {
            int UserInput = 5000;

            Converter C = new Converter();
            string output = C.generate(UserInput);

            Assert.AreEqual("Invalid Number", output);


        }

        //Unit Test to check if program identifies that any number below 1 is invalid
        [TestMethod]
        public void CheckInvalidNumberBelow1()
        {
            int UserInput = -245;

            Converter C = new Converter();
            string output = C.generate(UserInput);

            Assert.AreEqual("Invalid Number", output);


        }

        //Unit Test to check if program successfully converts a number that has 4 figures.
        [TestMethod]
        public void ConvertNumberinThousands()
        {
            int UserInput = 2018;

            Converter C = new Converter();
            string output = C.generate(UserInput);

            Assert.AreEqual("MMXVIII", output);


        }

        //Unit Test to check if program successfully converts a number that has 3 figures.
        [TestMethod]
        public void ConvertNumberinHundreds()
        {
            int UserInput = 672;

            Converter C = new Converter();
            string output = C.generate(UserInput);

            Assert.AreEqual("DCLXXII", output);


        }

        //Unit Test to check if program successfully converts a number that has 2 figures.
        [TestMethod]
        public void ConvertNumberinTens()
        {
            int UserInput = 31;

            Converter C = new Converter();
            string output = C.generate(UserInput);

            Assert.AreEqual("XXXI", output);


        }

        //Unit Test to check if program successfully converts a single figure number.
        [TestMethod]
        public void ConvertNumberinOnes()
        {
            int UserInput = 8;

            Converter C = new Converter();
            string output = C.generate(UserInput);

            Assert.AreEqual("VIII", output);


        }

    }
}
