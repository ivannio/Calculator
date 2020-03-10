using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by commas and they will be multiplied together");
            var input = Console.ReadLine();

            Console.WriteLine("Would you like to multiply the values or square them? Type 'multiply' or 'square' and press enter");
            var mathToDo = Console.ReadLine();

            int[] parsedNums = Array.ConvertAll(input.Split(','), int.Parse);

            int product = 1;

            string squares = "";

            if (mathToDo == "multiply")
            {      
                foreach (int num in parsedNums)
                {
                    product *= num;
                }
            }
            else if (mathToDo == "square")
            {
                foreach (int num in parsedNums)
                {
                    int squaredNum = num * num;
                    var stringifiedSquare = squaredNum.ToString() + ",";
                    squares += stringifiedSquare;
                }
                char[] charsToTrim = {','};

                squares = squares.TrimEnd(charsToTrim);
            }
            else Console.WriteLine("Sorry, I couldn't tell if you wanted the numbers multiplied or squared. I'm gonna go ahead a shut down, please be more careful when typing in the operation next time, ok? :)");
            Console.ReadLine();

            if (mathToDo == "multiply")
            {
                Console.WriteLine(product);
                Console.ReadLine();
            }
            else if (mathToDo == "square")
            {
                Console.WriteLine(squares);
                Console.ReadLine();
            }
            
        }
    }
}
