namespace _13__Do_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string durum = "yes";

            //do
            //{
            //    Console.WriteLine("Döngünün içindesin");
            //    Console.WriteLine("Devam mı? [yes] [no]: ");
            //    durum = Console.ReadLine();
            //} while (durum != "no");

            string kullaniciAdi = "";
            string kullaniciSifre = "";

            do
            {
                Console.WriteLine("User Name: ");
                kullaniciAdi = Console.ReadLine();
                Console.WriteLine("Password: ");
                kullaniciSifre = Console.ReadLine();
            } while (kullaniciAdi != "admin" || kullaniciSifre != "1234");


            Console.WriteLine("You are outside of the loop");

            //Özetle, do-while döngüsü bir işlemin en az bir kez yapılması gerektiği durumlarda kullanılır.
        }
    
    }
}
