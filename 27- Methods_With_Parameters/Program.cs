using System.Numerics;
using System.Threading.Channels;

namespace _27__Methods_With_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            EkranaYazıYaz("Mert İsmail Bal");
            EkranaYazıYaz("Mert İsmail Bal", 5);
            string[] basket = new string[5] { "Elma", "Armut", "Muz", "Çilek", "Kivi" };
            PrintTheBasketList(basket);
            Calculater();
        }
        static void EkranaYazıYaz(string name)
        {
            Console.WriteLine(name);
        }
        static void EkranaYazıYaz(string name, int many)
        {
            for (int i = 0; i < many; i++)
            {
                Console.WriteLine(name);
            }
        }
        static void PrintTheBasketList(string[] basket)
        {
            foreach (var item in basket)
            {
                Console.WriteLine(item);
            }
        }
        static void Calculater()
        {
            Console.WriteLine("Which arithmetic operation would you like to do ? [1-Addition] [2-Subtraction] [3-Multiplication]");
            string operation = Console.ReadLine();
            Console.WriteLine("First number please enter ?");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number please enter ?");
            int number2 = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case "1":
                    Addition(number1, number2);
                    break;
                case "2":
                    Subtraction(number1, number2);
                    break;
                case "3":
                    Multiplication(number1, number2);
                    break;
                default:
                    Console.WriteLine("Options doesnt consist of what you want.");
                    break;
            }
        }
        static void Addition(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }
        static void Subtraction(int number1, int number2)
        {
            Console.WriteLine(number1 - number2);
        }
        static void Multiplication(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);

        }
    }
}
