namespace _31__Methods_Overloading_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> urunler = new List<string>() { "Kalem", "Kitap", "Defter", "Silgi", "Kalem Kutu", "Tükenmez Kalem", "Not Defteri", "Çanta", "Suluk" };
            List<string> indirimliUrunler = new List<string>() { "Defter", "Kitap" };

            Console.WriteLine("Ürünlermiz; ");
            int i = 1;
            foreach (string product in urunler)
            {
                Console.WriteLine(i+". Ürünümüz: "+product);
                i++;
            }
            Console.WriteLine("Urun secınız");
            string nameOfProduct = Console.ReadLine();
            Console.WriteLine("Kaç adet istiyorusnuız");
            int adet=int.Parse(Console.ReadLine());
            if (indirimliUrunler.Contains(nameOfProduct))
            {
                Console.WriteLine(Calculater(50, adet, 0.2));
            }
            else if (urunler.Contains(nameOfProduct))
            {
                Console.WriteLine(Calculater(50, adet));
            }
         
        }
        static double Calculater(double x, double y)
        {
            return x * y;
        }
        static double Calculater(double x, double y, double z)
        {
            return x * y -(x*z);
        }
    }
}
