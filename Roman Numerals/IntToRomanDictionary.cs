using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals
{

    //Initially situated in the "Converter.cs" class, I felt the dictionary declarations and assignments needed to be in its own class. 
    //Not only are they sensitive factors to the program that should not be easily modified or altered, they also deserver their own class to make it easier to access and understand.

    internal class IntToRomanDictionary
    {
        //Dictionary that takes in two values. An Int and a String. Int will be the key. String will be the value.
       internal Dictionary<int, string> IntToRomanThousands = new Dictionary<int, string>();
        internal Dictionary<int, string> IntToRomanHundreds = new Dictionary<int, string>();
        internal Dictionary<int, string> IntToRomanTens = new Dictionary<int, string>();
        internal Dictionary<int, string> IntToRomanOnes = new Dictionary<int, string>();

        internal void AssignIntToRoman()
        { 
       

           //Store Thousands
            IntToRomanThousands.Add(0, "");
            IntToRomanThousands.Add(1, "M");
            IntToRomanThousands.Add(2, "MM");
            IntToRomanThousands.Add(3, "MMM");

            //Store Hundreds
            IntToRomanHundreds.Add(0, "");
            IntToRomanHundreds.Add(1, "C");
            IntToRomanHundreds.Add(2, "CC");
            IntToRomanHundreds.Add(3, "CCC");
            IntToRomanHundreds.Add(4, "CD");
            IntToRomanHundreds.Add(5, "D");
            IntToRomanHundreds.Add(6, "DC");
            IntToRomanHundreds.Add(7, "DCC");
            IntToRomanHundreds.Add(8, "DCCC");
            IntToRomanHundreds.Add(9, "CM");

            //Store Tens
            IntToRomanTens.Add(0, "");
            IntToRomanTens.Add(1, "X");
            IntToRomanTens.Add(2, "XX");
            IntToRomanTens.Add(3, "XXX");
            IntToRomanTens.Add(4, "XL");
            IntToRomanTens.Add(5, "L");
            IntToRomanTens.Add(6, "LX");
            IntToRomanTens.Add(7, "LXX");
            IntToRomanTens.Add(8, "LXXX");
            IntToRomanTens.Add(9, "XC");

            //Store Ones
            IntToRomanOnes.Add(0, "");
            IntToRomanOnes.Add(1, "I");
            IntToRomanOnes.Add(2, "II");
            IntToRomanOnes.Add(3, "III");
            IntToRomanOnes.Add(4, "IV");
            IntToRomanOnes.Add(5, "V");
            IntToRomanOnes.Add(6, "VI");
            IntToRomanOnes.Add(7, "VII");
            IntToRomanOnes.Add(8, "VIII");
            IntToRomanOnes.Add(9, "IX");

        }

    }

 
}

