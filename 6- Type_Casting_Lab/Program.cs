namespace _6__Type_Casting_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dışarıdan alınan iki sayının toplamıyla farkının birbirine bölümünden kalan kaçtır?

            Console.Write("Birinci sayıyı giriniz: ");
            double number1=Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine((number1+number2)%(number1-number2));

            //Dışarıdan girilen bir sayının 10 eksiğinin 20 fazlasının 2 bölümünden kalanın karesi kaçtır?

            number2=(int.Parse(Console.ReadLine())-10+20)%2;
            number2 *= number2;
            Console.WriteLine("karesi: {0}",number2);

            //Muz fiyatı kullanıcıdan dolar cinsinden alınsın. (dolar 33.4) bana TL cinsinden ekrana yazdırılsın. Kdv li fiyatıda yazılın (Yüzde 20)
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("PLease wirte the price of banana per kg ?");
            double priceOfBanana = Convert.ToDouble(Console.ReadLine())/33.4;
            Console.WriteLine($"Banana\'s price:{priceOfBanana}\nBanana\'s Price along with KDV:{priceOfBanana+(priceOfBanana*0.2)}");
        }
    }
}
