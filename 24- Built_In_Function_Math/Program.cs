namespace _24__Built_In_Function_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.PI.ToString());
            int mutlakDeger = Math.Abs(-45);
            Console.WriteLine(mutlakDeger);

            //Kuvvet Alma
            Console.WriteLine(Math.Pow(3, 4));

            //Karaköt
            Console.WriteLine(Math.Sqrt(16));

            //Floor = Verilen ondalık değeri bir alt değere tamamlar.
            Console.WriteLine(Math.Floor(12.98));

            //Ceiling = Verilen ondalık değeri bir üst değere tamamlar.
            Console.WriteLine(Math.Ceiling(12.48));

            //Truncate = Sayının ondalık kısmına bakma yalnızca tam sayı kısmını bize verir.
            Console.WriteLine(Math.Truncate(12.98));

            //Round = Sayının yarısından fazlasını bir üste yarısından azını bir alta yuvarlar.
            Console.WriteLine(Math.Round(12.65));
            Console.WriteLine(Math.Round(12.45));
            Console.WriteLine(Math.Round(12.50));
            Console.WriteLine(Math.Round(13.50));

            //Sayının pozitif mi negatif mi notr mü olduğunu
            Console.WriteLine(Math.Sign(-25));

            //Max ve Min

            Console.WriteLine(Math.Max(20, 30));
            Console.WriteLine(Math.Min(20, 30));

            //Girilen 3 sayıdan en büyüğünü ve en küçük bulan programı yazınız.

            Console.WriteLine("Sayı1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Sayı2: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Sayı3: ");
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"En Büyük: {Math.Max(num3, Math.Max(num1, num2))}");
            Console.WriteLine($"En Küçük: {Math.Min(num3, Math.Min(num1, num2))}");


        }
    }
}
