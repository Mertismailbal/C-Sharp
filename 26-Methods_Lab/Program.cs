namespace _26_Methods_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                StartCalculater();
            }

        }
        static void StartCalculater() {
            Console.WriteLine("İşlemlerimiz: [1-Toplama] [2-Çarpma] [3-Çıkış]");
            Console.Write("Lütfen bir işlem seçiniz: ");
            string choosen=Console.ReadLine();
            switch (choosen)
            {
                case "1":
                    Additioın();
                    break;
                case "2":
                    Multiplication();
                    break;
                case "3":
                    Console.WriteLine("Programdan çıkılıyor...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem seçimi.");
                    break;
            }
        }
        static void Additioın()
        {
            Console.Write("Lütfen 1. sayıyı giriniz: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Lütfen 2. sayıyı giriniz: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Toplam: {num1 + num2}");
        }
        static void Multiplication()
        {
            Console.WriteLine("Lütfen 1. sayıyı giriniz.");
            if(double.TryParse(Console.ReadLine(),out double num1));
            Console.WriteLine("Lütfen 2. sayıyı giriniz.");
            double num2=double.Parse(Console.ReadLine());
            Console.WriteLine($"Çarpım: {num1 * num2}");
        }

    }
}
