using System.Net.Http.Headers;
using System.Threading.Channels;

namespace _14__Calculater_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator Lab!\nToday, we will produce the basic calculater.");
            double firstNumber = 0, secondnumber=0;
            string operation = " ";
            while(operation != string.Empty)
            {
                try
                {
                    Console.WriteLine("Write your first number?");
                    firstNumber=double.Parse(Console.ReadLine());
                    Console.Beep();
                    System.Threading.Thread.Sleep(1000); // Wait for 1 second
                    Console.WriteLine("Write your second number?");
                    secondnumber = double.Parse(Console.ReadLine());
                    Console.Beep();
                    if (secondnumber == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
                        continue;
                    }
                    System.Threading.Thread.Sleep(1000); // Wait for 1 second
                    
                    while (true)
                    {
                        Console.WriteLine("What kind of operation do you want to do? [ + ] [ - ] [ * ] [ / ]");
                        operation = Console.ReadLine().Trim();
                        if (new[] {"-","+","*","/"}.Contains(operation))
                            break;
                                                     
                        else
                        {
                            Console.WriteLine("Invalid operation. Please enter one of the following: +, -, *, /");
                            continue;
                        }
                    }
                    Console.WriteLine("Calculating...");
                    Console.Beep();
                    System.Threading.Thread.Sleep(1000); // Wait for 1 second                    
                    break;
                }
                catch (Exception error)
                {
                    Console.WriteLine("An error occurred while reading the input. Please ensure you enter valid numbers and operations. {0}", error);
                    System.Threading.Thread.Sleep(2000); // Wait for 1 second
                    Console.Clear();
                    continue;
                }
            }
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"The result of {firstNumber} + {secondnumber} is {firstNumber + secondnumber}");
                    break;
                case "-":
                    Console.WriteLine($"The result of {firstNumber} - {secondnumber} is {firstNumber - secondnumber}");
                    break;
                case "*":
                    Console.WriteLine($"The result of {firstNumber} * {secondnumber} is {firstNumber * secondnumber}");
                    break;
                case "/":
                    
                    Console.WriteLine($"The result of {firstNumber} / {secondnumber} is {firstNumber / secondnumber}");
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please enter one of the following: +, -, *, /");
                    break;
            }

        }
    }
}
