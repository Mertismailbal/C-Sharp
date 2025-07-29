namespace _25__Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metotlar, belirli bir işlevi yerine getirmek için hazırlanmış belirli bir kod bloğunu bir isim altında toplayıp. Kodu çalıştırmak istediğimiz yerde vermiş oluğumuz isimle çağırıp içerisinde ki kodun yeniden kullanılmasına izin veren yapıdır.
            Console.WriteLine("Adını Nedir");
            string ad = Console.ReadLine();

            EkranaYazıYaz();

            Console.WriteLine(ad);

            TekCiftSayiToplami();
        }
        //[erişim belirleyici] [niteliyici varsa?] [dönüş tipi] [metot adı]([parametreler varsa?]) 
        //Erişim belirleyicisi: Bu metodu kimler kullabilir.
        //Niteliyici: static (opsiyoneldir.)
        //Dönüş Tipi: Metotdu görevini yaptıktan sonra ne türde bilge verecek (string, int, vb.). void = geri değer döndürmez.
        //Metot adı: metodun gorevini tanımlayan anlamlı bir isim.
        //parametre liste: (opsiyoneldir)
        static void EkranaYazıYaz()//Metodun Başlığı
        {
            //Metodun Gövdesi
            Console.WriteLine("Naber");
        }
        //1 den 100 kadar olan çift sayıların toplamı ile tek sayılarını toplamını bulan metodu yazınız.
        static void TekCiftSayiToplami()
        {
            int totalOfEven = 0;
            int totalOfOdd = 0;
            for(int i = 0; i <= 100; i++)
            {
                if(i%2==0)
                {
                    totalOfEven += i;
                }
                else
                    totalOfOdd += i;
            }
            Console.WriteLine($"Çiftlerin toplamı {totalOfEven}\nTeklerin toplamı: {totalOfOdd}");
        }
        }
}
