
namespace _10__Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch Case ile yapılabilen kontorlerinin hepsini if-else ile de yapabiliriz. Aradaki fark ise if-else büyük-küçüklük gibi durumlarıda kontrol edebiliyorken.
            //***Switch Case yapısı yalnızca eşitlik durumlarını kontrol eder.

            Console.WriteLine("1 [C#], 2 [VB], 3 [JAVA], 4 [C]");
            Console.Write("Lütfen bir dil seçiniz: ");

            int dil = int.Parse(Console.ReadLine());

            switch (dil)
            {
                case 1:
                    Console.WriteLine("Seçilen dil C#");
                    break;
                case 2:
                    Console.WriteLine("Seçilen dil VB");
                    break;
                case 3:
                    Console.WriteLine("Seçilen dil JAVA");
                    break;
                case 4:
                    Console.WriteLine("Seçilen dil C");
                    break;
                default:
                    Console.WriteLine("Senin seçimin...");
                    break;
            }
            Console.Beep(); 
            System.Threading.Thread.Sleep(2000); // 2 saniye beklet
            Console.WriteLine("Mevsim Seçiniz: [Kış] [İlkbahar] [Yaz] [Sonbahar]");
            string mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "Kış":
                    Console.WriteLine("Aralık - Ocak - Şubat");
                    break;
                case "İlkbahar":
                    Console.WriteLine("Mart - Nisan - Mayıs");
                    break;
                case "Yaz":
                    Console.WriteLine("Haziran - Temmuz - Ağustos");
                    break;
                case "Sonbahar":
                    Console.WriteLine("Eylül - Ekim - Kasım");
                    break;
                default:
                    break;
            }

            Console.WriteLine("Lütfen Notunuzu Giriniz: A | B | C | D | F");
            string not = Console.ReadLine();

            switch (not)
            {
                case "A":
                case "B":
                case "C":
                    Console.WriteLine("Geçtiniz...");
                    break;
                case "D":
                    Console.WriteLine("Ortalama ile geçtiniz...");
                    break;
                case "F":
                    Console.WriteLine("Kaldınız...");
                    break;
                default:
                    Console.WriteLine("Hata");
                    break;
            }
        }
    }
}
