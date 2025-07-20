namespace _16__Prime_Number_Finding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = "yes";

            while (answer == "yes")
            {
                Console.Write("Enter a number to check if it's prime: ");

                if (int.TryParse(Console.ReadLine(), out int number) && number > 1)
                {
                    bool isPrime = number == 2 || number == 3 || number == 5 || number == 7;

                    if (!isPrime)
                    {
                        isPrime = true;
                        for (int i = 2; i <= Math.Sqrt(number); i++)
                        {
                            if (number % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }

                    Console.WriteLine(isPrime ? "Your number is prime" : $"{number} is not prime");
                }
                else
                {
                    Console.WriteLine("Please enter a valid positive number greater than 1.");
                    continue;
                }

                Console.Write("Do you want to try another number? [yes/no]: ");
                while (true)
                {
                    answer = Console.ReadLine().Trim().ToLower();
                    if (answer == "yes" || answer == "no")
                        break;
                    Console.Write("Invalid input. Please enter 'yes' or 'no': ");
                }
            }
            //string yesOrNo = "yes";
            //while (yesOrNo == "yes")
            //{
            //    Console.WriteLine("Which number do you want to check if it is a prime number?");
            //    if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            //    {
            //        if (!new[] { 2, 3, 5, 7 }.Contains(number))
            //        {
            //            for (int i = 2; i<= Math.Sqrt(number); i++)
            //            {
            //                if (number % i == 0)
            //                {
            //                    Console.WriteLine($"{number} is not prime");
            //                    yesOrNo = "no"; // Exit the loop if a divisor is found
            //                    break;
            //                }

            //            }
            //            if(yesOrNo!="no")
            //                Console.WriteLine("Your number is Prime");

            //        }
            //        else
            //            Console.WriteLine("Your number is prime");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a valid answer.");
            //        continue;
            //    }
            //    Console.WriteLine("Do you want to learn another number ?[Yes][No]");
            //    while (true)
            //    {
            //        yesOrNo = Console.ReadLine().ToLower();
            //        if (yesOrNo == "yes" || yesOrNo == "no")
            //            break;
            //        else
            //            Console.WriteLine("Please enter a valid answer.");
            //    }
            //}
        }
    }
}
