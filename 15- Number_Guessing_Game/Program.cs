namespace _15__Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to number gueessing game!");
            Console.WriteLine("You could try 3 times. Guesss the number between [1,21]");
            Random random = new Random();
            int randomNumber=random.NextDouble() < 0.5 ? random.Next(1, 11) : random.Next(11, 21);
            int guess = 0;
            while (true)
            {
                for (int i = 3; i > 0; i--)
                {
                    if (int.TryParse(Console.ReadLine(), out int x))
                    {
                        if (x < 1 || x > 21)
                        {
                            Console.WriteLine("Please enter a valid number.");
                            i++;
                            continue;
                        }
                        else
                        {
                            guess = x;  
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                        i++; ;
                        continue;
                    }
                    if (guess < randomNumber)
                    {
                        Console.WriteLine("Your guess is too low. Try again.");
                        continue;
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("Your guess is too high. Try again.");
                        continue;
                    }
                    else if(guess == randomNumber)
                    {
                    Label1:
                        Console.WriteLine("Congratulations! You've guessed the number correctly.");
                        Console.WriteLine("Do you want to play again? [Yes][No]");
                        string playAgain = Console.ReadLine().ToLower();
                        if (playAgain == "yes")
                        {
                            randomNumber = random.NextDouble() < 0.5 ? random.Next(1, 11) : random.Next(11, 21);
                            i = 3; // Reset the attempts
                            Console.WriteLine("Hello, Welcome to number gueessing game!");
                            Console.WriteLine("You could try 3 times. Guesss the number between [1,21]");
                            continue;
                        }
                        else if (playAgain == "no")
                        {
                            Console.WriteLine("Thank you for playing!");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Exiting the game.");
                            goto Label1;
                        }
                    }                   
                }
            Label2:
                Console.WriteLine("Sorry you lost the game,number is: {0} Do you wanna try again ?[Yes][No]",randomNumber);
                string playAgain2 = Console.ReadLine().ToLower();
                if (playAgain2 == "yes")
                {
                    randomNumber = random.NextDouble() < 0.5 ? random.Next(1, 11) : random.Next(11, 21);
                    continue;
                }
                else if (playAgain2 == "no")
                {
                    Console.WriteLine("Thank you for playing!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Exiting the game.");
                    goto Label2;
                }
            }

        }
    }
}
