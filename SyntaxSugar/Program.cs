// See https://aka.ms/new-console-template for more information
namespace SyntaxSugar
{
    class Program
    {   
        // Given an if-else statement, replace it as a ternary operator
        // Print out the results for good measure
        // The real if-else statement is provided as comments
        public static void Main(String[] args)
        {
            int answer = 4;
            string response;

            response = (answer < 9) ? answer + " is less than nine" : answer + " greater than or equal to nine";

            Console.WriteLine(response);
            /*
            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + “greater than or equal to nine”;
            }
            */
        }
    }
}