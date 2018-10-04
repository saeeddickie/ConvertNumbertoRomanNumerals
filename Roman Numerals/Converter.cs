using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals
{
    //The logic where the conversion takes place. 

    public class Converter : IRomanNumeralGenerator
    {

        public string generate(int number)
        {
            /*the string that will contain the converted Roman numeral. What is required from the method since it is a string generate(int number).
            It expects an int number and needs to return a string*/
            string ConvertedOutputRomanNumber = "";

            /*Creates an instance of the IntToRoman class and initiates the "AssignIntToRoman" method.
            This method is what builds the dictionary. Without calling this method first, the logic below won't have any way to convert numeral values to Roman.*/
            IntToRomanDictionary ITR = new IntToRomanDictionary();
            ITR.AssignIntToRoman();

            //Check if the number entered is valid.
            if ((number >= 1) && (number < 3999))
            {

                /*Dictionary key for thousands number is obtained by division. If the value is 0 then an empty string is used.
                 Because it is an int. You won't get back a decimal. Only a single figure that'll work with the dictionary*/
                int key = number / 1000;

                //Add the dictionary value to the string output based on the "key" above.
                ConvertedOutputRomanNumber += ITR.IntToRomanThousands[key];

                //Obtain hundreds, tens, ones numbers in the overall figure by using the remainder operator. Essentially removing the thousands number. 
                number %= 1000;

                //Key now becomes the new number (obtained after using remainder operator)
                key = number / 100;

                //Here the second roman numeral is concatenated to the first roman numeral to build the overall roman numeral number.
                ConvertedOutputRomanNumber += ITR.IntToRomanHundreds[key];
                number %= 100;

                key = number / 10;
                ConvertedOutputRomanNumber += ITR.IntToRomanTens[key];
                number %= 10;

                key = number;
                ConvertedOutputRomanNumber += ITR.IntToRomanOnes[key];

                //return the ConvertedOutputRomanNumber string value. 
                return ConvertedOutputRomanNumber;

            }

            /*if the number isn't valid then return string "Invalid Number". Originally set return as null but figured it should keep to the rules by returning a string regardless of whether 
            it is valid or not.*/

            else
            {
                ConvertedOutputRomanNumber = "Invalid Number";
                return ConvertedOutputRomanNumber;
            }


        }
    }
}
