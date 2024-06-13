namespace Laskuri
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Calculator asks user one number, then the operator and then other number and gives the answer
            Console.WriteLine("Calculator");


            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter +, -, *, or /. ");
            string op = Console.ReadLine();

            Console.WriteLine("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            //this could also be written as  op == "+" etc.
            if (op.Contains("+"))
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op.Contains("-"))
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op.Contains("*"))
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op.Contains("/"))
            {
                Console.WriteLine(num1 / num2);
            }

            else
            {
                Console.WriteLine("Something is missing.");


            }
          }
        }
    }