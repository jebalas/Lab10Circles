using System;
namespace Lab10CirclesClass
{
    public class Validator
    {
        public static bool ContinueIsValid(string userInput)
        {
            if (userInput.ToLower() == "y" || userInput.ToLower() == "n")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid Entry. Please enter y or n! ");
                return false;
            }
        }

        public static bool RadiusIsValid(string userInput)
        {
            if (double.TryParse(userInput, out double x))
            {
                return true;
            }
            else
            {
                Console.WriteLine("That is not a valid number. Please try again! ");
                return false;
            }
        }
    }
}
