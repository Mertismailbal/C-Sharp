namespace _28__Value_Returning_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Sqrt(2) * 2;
            Console.WriteLine(result);
            Console.WriteLine(Sqrt(8));
            Console.WriteLine(Hello());
            Start();
            Console.WriteLine("Fiyat Giriniz: ");
            double fiyat = double.Parse(Console.ReadLine());

            double kdvFiyat = KdvCalculater(fiyat, 1.20);
            double kdvFiyat2 = KdvCalculater(fiyat);
            Console.WriteLine($"Yüzde 10 KdvLi Fiyat: {KdvCalculater(fiyat, 1.10)}");


        }
        static int Sqrt(int number)
        {
            return number * number;
        }
        static string Hello()
        {
            return "Hello World!";
        }
        /// <summary>
        /// Basit bir hesap makinesi uygulaması. Kullanıcıdan iki sayı ve bir işlem alır, sonucu hesaplar ve ekrana yazdırır.
        /// </summary>
        private static void Start()
        {
            Console.WriteLine("Please choose the operation [+,-,*,/]");
            char operation = Char.Parse(Console.ReadLine());
            Console.WriteLine("1. Sayı");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. Sayı");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(sayi1,sayi2,operation));
        }
        /// <summary>
        /// Hesap makinası için hesaplama işleminin yapıldğı metot 
        /// </summary>
        /// <param name="number1">Alınan birinci sayı</param>
        /// <param name="number2">alınan ikinci sayı </param>
        /// <param name="operation">Yapılıcak olan işlem</param>
        /// <returns>İşlemin sonucu </returns>
        static double Calculate(int number1,int number2,char operation)
        {
            switch (operation)
            {
                case '+':
                    return number1 + number2;
                case '-':
                    return number1 - number2;
                case '*':
                    return number1 * number2;
                case '/':
                    if (number2 == 0)
                    {
                        Console.WriteLine("Bölme işlemi 0'a bölünemez.");
                        return 0;
                    }
                    return (double)number1 / number2;
                default:
                    Console.WriteLine("Geçersiz işlem.");
                    return 0;
            }
        }
        /// <summary>
        /// KDV hesaplama metodu. Eğer değer girilmezse varsayılan olarak 1000 TL ve %20 KDV oranı ile çalışır.
        /// </summary>
        /// <param name="miktar"></param>
        /// <param name="oran"></param>
        /// <returns></returns>
        static double KdvCalculater(double miktar=1000,double oran = 1.20)
        {
            return miktar * oran;
        }
    }
}
