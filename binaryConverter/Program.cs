using System;

namespace binaryConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number or a string to convert to binary");
            string input = Console.ReadLine();

            bool isInt = int.TryParse(input, out int result);

            if (isInt)
            {
                string binary = Convert.ToString(result, 2);
                Console.WriteLine(binary);
            }
            else
            {
                string binary = "";
                foreach (char c in input)
                {
                    binary += Convert.ToString(c, 2) + "";
                }
                Console.WriteLine(binary);
                
            }
            Console.ReadLine();
        }
    }
}

// Could improve on this by adding a loop so that once the enter key is clicked,
// it will ask for another input
