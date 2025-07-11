namespace _4__Arithmetic_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region AritmetikOperatörler
            //Matematiksel işlemler (+) Toplama, (-) Fark (/) Bolum (*) Carpım (%) Mod Alm0a

            int a = 5, b = 6;
            Console.WriteLine("A Çarpı B: {0}", a * b);

            //(=) Atama operatörü

            int c = 5, d = 6;
            int sonuc = c * d;
            Console.WriteLine("C Çarpı D: {0}", sonuc);

            int sayi1 = 5;
            int sayi2 = 6;
            int kalan = sayi2 % sayi1;

            Console.WriteLine("Sayı 2 nin Sayi 1 bölümünden kalan: " + kalan);

            int deger1 = 5;
            int deger2 = 6;
            int toplam = deger1 + deger2;

            Console.WriteLine("Deger 1: {0} Değer 2: {1} Toplamı: {2}", deger1, deger2, toplam);

            //(+) Birleştirme
            string deger3 = "Fatih";
            string deger4 = "Alkan";

            Console.WriteLine(deger3 + deger4 + 5 + 2);
            Console.WriteLine(deger3 + deger4 + (5 + 2));
            #endregion

            #region Artırma-Azaltma Operatörleri

            int number1 = 20;
            number1 = number1 - 5;
            Console.WriteLine("Sonuç: " + number1);

            //Birleşik Atama
            int number2 = 20;
            number2 -= 5;
            Console.WriteLine("Sonuç: " + number2);

            //Birartırma - Birazaltma
            int number3 = 20;
            int z = number3++; //ÖNCE Atama Sonra Artırma

            int number4 = 20;
            int w = ++number4; //ÖNCE Artırma Sonra Atama

            Console.WriteLine("Sonuc Z: " + z);
            Console.WriteLine("Sonuc 1: " + number3);
            Console.WriteLine("Sonuc W: " + w);

            //Örnek Uygulama

            int i = 10;
            int j = 5;

            int k = i++ + ++j - --i + j++ - ++i; //1
            int l = 10 + 6 - 10 + 6 - 11; //1

            Console.WriteLine("Sonuc: " + k);

            #endregion

            #region KosulOperatörleri

            //Ve (AND) (&&) - Veya (OR) (||)

            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);

            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);

            int m = 5;
            int n = 10;

            Console.WriteLine(m == n);
            Console.WriteLine(m != n);

            #endregion
        }
    }
}
