namespace Laskuri
{
    internal class Program
    {
        static void Main(string[] args)
        {






            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter +, -, *, or /. ");
            string item = Console.ReadLine();


            if (item.Contains("+"))
            {
                Console.WriteLine(num1 + num2);
            }
            else if (item.Contains("-"))
            {
                Console.WriteLine(num1 - num2);
            }
            else if (item.Contains("*"))
            {
                Console.WriteLine(num1 * num2);
            }

            else
            {
                Console.WriteLine(num1 / num2);


            }
          }
        }
    }