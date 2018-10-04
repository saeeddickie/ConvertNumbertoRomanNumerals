using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Roman_Numerals
{
    class Program
    {
        //The main method that handles the method call and the text-based UI. 
        static void Main(string[] args)
        {
            int UserNumber;
            string output;

            do
            {
            
                Console.Out.Write("--Convert your number to a roman numeral--" + "\n");

                Console.Out.Write("Enter your number: ");

                //User enters number and a new instance of Converter.cs is called. the method within it "generate" is called and uses the number the user has inputted.
                UserNumber = Convert.ToInt32(Console.ReadLine());
                Converter C = new Converter();
                output = C.generate(UserNumber);

                //The logic in "Converter.cs" checks if a number is valid or not and then returns the outcome. 
                //The If else statement uses that outcome to notify the user to enter a correct number

                if (output == "Invalid Number")
                {
                    Console.Out.Write("\n" + "Your number " + UserNumber + " is invalid." + "\n");
                    Console.Out.Write("The number cannot be less than 1 and greater than 3999" + "\n");
                    Console.Out.Write("Press any key to try another number" + "\n");
                    Console.ReadLine();
                }
                else
                {
                    Console.Out.Write("\n" + "The roman numeral for " + UserNumber + " is " + output + "\n");
                    Console.Out.Write("Press any key to end the program" + "\n");
                    Console.ReadLine();
                }

            } while (output == "Invalid Number");
        }

    }
}
