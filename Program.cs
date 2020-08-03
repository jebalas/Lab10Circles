using System;
using System.ComponentModel.DataAnnotations;

namespace Lab10CirclesClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCircles = 0;
            
            Console.WriteLine("Welcome to the Circle Tester");
            do
            {
                bool inputValid;
                string userInput;
                do
                {
                    Console.Write("Enter radius: ");
                    userInput = Console.ReadLine();
                    inputValid = Validator.RadiusIsValid(userInput);
                } while (!inputValid);

                var radius = double.Parse(userInput);
                var circle = new Circle(radius);

                Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference()}");
                Console.WriteLine($"Area: {circle.CalculateFormattedArea()}");
                numCircles++;
            } while (ToContinue(numCircles));
        }

        public static bool ToContinue(int numCircles)
        {
            bool inputValid;
            string userInput;
            do
            {
                Console.Write("Do you want to continue? (y/n): ");
                userInput = Console.ReadLine();
                inputValid = Validator.ContinueIsValid(userInput);
            } while (!inputValid);

            if (userInput.ToLower() == "y")
            {
                return true;
            }
            else
            {
                Console.WriteLine($"Goodbye. You created {numCircles} Circle object(s)");
                return false;
            }
        }
    }
}
