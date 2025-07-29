namespace _32__Local_Methods_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            EkranaYaz();

            void EkranaYaz()
            {
                Console.WriteLine("Merhaba Dünya");
            }

            Console.WriteLine(Hesapla(5, 10, "toplam"));

        }

        public static int Hesapla(int a, int b, string islem)
        {
            int result = 0;

            if (islem == "toplam")
            {
                return Topla(a, b);
            }
            else if (islem == "fark")
            {
                return Fark(a, b);
            }
            else if (islem == "carp")
            {
                return Carp(a, b);
            }
            else
            {
                return Bol(a, b);
            }

            //Lambda Ifadesi

            int Topla(int sayi1, int sayi2) => sayi1 + sayi2;

            int Fark(int sayi1, int sayi2) => sayi1 - sayi2;

            int Carp(int sayi1, int sayi2) => sayi1 * sayi2;

            int Bol(int sayi1, int sayi2) => sayi1 / sayi2;
        }

    }
}