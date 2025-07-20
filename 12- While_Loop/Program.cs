namespace _12__While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mantıksal bir ifade gerçekleştiği sürece belirli bir kod bloğunu çalıştırmak için kullanılır.
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            int a = 1;

            //While (Koşul true ise)
            while (a < 10)
            {
                //Çalıştır.
                Console.WriteLine(a);
                a++;
            }
            
            string yesOrNo = "yes"; 
            while(yesOrNo is "yes")
            {
                Console.WriteLine("You are inside of the loop Do you wanna keep going ?\t[Yes]\t[No]");
                yesOrNo = Console.ReadLine().ToLower();
            }

            bool ısRunning = true;
            while(ısRunning)
            {
                Console.WriteLine("Write the user name ?");
                string userName = Console.ReadLine().ToLower();
                Console.WriteLine("Write the password ?");
                string password = Console.ReadLine().ToLower();
                if (userName == "balmertismail@gmail.com" && password == "mertoo")
                {
                    Console.WriteLine("Welcome to your application, it's nice to see you again.");
                    ısRunning = true;
                }
                else
                {
                    Console.WriteLine(":( Try Again");
                    ısRunning = false;
                    
                }
            }
        }
    }
}
