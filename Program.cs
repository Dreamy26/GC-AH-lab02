using System;

namespace AH_lab02
{
    class Program
    {
        private static string response;

        static void Main(string[] args)


        {
            
                do
                {
                Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");
                Console.WriteLine("Enter Length");
                //Rectangle Area: A (area) = L (length) x W (width)
                Console.Write("Please Enter the LENGTH of the room at GC: ");
                decimal lengthSide = decimal.Parse(Console.ReadLine());
                Console.Write("Please Enter the WIDTH of the room at GC: ");
                decimal widthSide = decimal.Parse(Console.ReadLine());

                decimal area = lengthSide * widthSide;
                //Rectangle Perimeter: A (area) = L 2(length) + W 2(width)
                decimal perimeter = (lengthSide * 2) + (widthSide * 2);

                Console.WriteLine("The Area of the room at Grand Circus' is: {0}", area);
                Console.WriteLine("The Perimeter of the room at Grand Circus' is: {0}", perimeter);

                Console.WriteLine("Would you like to continue (y/n)?");
                response = Console.ReadLine();
            } while (response == "y") ;

                Console.WriteLine("Goodbye!");
            
        }
    }
}
