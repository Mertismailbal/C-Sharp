namespace _30__Methods_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metot Overloading (Metot Aşırı yükleme)
            //C# programlama dilinde aynı isme sahip ancak farklı parametere listelerine sahip (metot imzası) olan metotların tanımlanabilmesini sağlayaun bir dil özelliğidir.Bu özellik sayesinde aynı isme sahip birden fazla metot oluşturabilirsiniz ve aynı isimle çağırabilirsiniz.
            Console.WriteLine("Toplam 1: " + Topla(5, 10));

            Console.WriteLine("Toplam 2: " + Topla(5, 10, 15));

            Console.WriteLine("Mail 1: " + MailOlusturucu("mert"));
            Console.WriteLine("Mail 2: " + MailOlusturucu("mert", "gmail.com"));
            Console.WriteLine(AlanHesapla(5));
            AlanHesapla(5, 10);
            AlanHesapla(2.5);
            //AlanHesapla(yaricap: 2.5);Burada üstekiyle aynısını yapıyoruz aslında ancak parametreyı de dırekt belırtebılıyoruz ne verebılcıegımızı.
        }
        #region Ornek1
        public static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }
        #endregion

        #region Ornek2
        //Mail oluşturucu Ad vericem => fatih@bilgeadam.com || Ad ve Domain fatih@akademi.com

        static string MailOlusturucu(string ad)
        {
            return ad + "@bilgeadam.com";
        }

        static string MailOlusturucu(int ad)
        {
            return ad + "@bilgeadam.com";
        }

        static string MailOlusturucu(string ad, string domain)
        {
            return ad + "@" + domain;
        }
        #endregion

        #region Ornek3
        //Karenin Alanı -> kenar
        //Dikdörtgenin Alanı -> uzun kenar ile kısa kenar
        //Dairebin -> yaricapin karesi * pi

        //AlanHesapla

        /// <summary>
        /// Karenin alanını hesaplayan metot.
        /// </summary>
        /// <param name="kenar"></param>
        /// <returns></returns>
        static double AlanHesapla(int kenar)
        {
            return kenar * kenar;
        }

        /// <summary>
        /// Dikdörtgenin alanını hesaplayan metot.
        /// </summary>
        /// <param name="uzunKenar"></param>
        /// <param name="kisaKenar"></param>
        /// <returns></returns>
        static double AlanHesapla(int uzunKenar, int kisaKenar)
        {
            return kisaKenar * uzunKenar;
        }

        /// <summary>
        /// Dairenin alanını hesaplayan metot.
        /// </summary>
        /// <param name="yaricap"></param>
        /// <returns></returns>
        static double AlanHesapla(double yaricap)
        {
            return Math.PI * yaricap * yaricap;
        }

        #endregion
    }
}
