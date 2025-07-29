namespace _18__Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sehir1 = "İstanbuıl";
            string sehir2 = "Ankara";
            string sehir3 = "İzmir";
            string[] sehirler = { "İstanbul", "Anakra", "İzmir" };
            Console.WriteLine(sehirler[2]);
            //Diziler aynı tipte değerlerin bir arada taşınmasını sağlayan referans tipli yapılardır. Dizilerin en önemli özelliği elemanlarını ismiyle değil indeks sırasıyla erişim sağlamasıdır.

            //Dizi oluştururken ya eleman sayısını yada elemanlarını vermek zorundasın. Çünkü referans tipli olduğundan dolayı belleğin heap kısmında kendine belirli bir boyutta alan açmak zorundadır
            int[] sayılar = new int[5] { 70, 64, 43, 56, 66 };
            Console.WriteLine(sayılar[0]);

            double[] notlar;
            notlar = new double[5];
            notlar[0] = 70.5;
            notlar[1] = 80.5;
            notlar[2] = 90.5;
            Console.WriteLine(notlar[2]);
            notlar = new double[10];
            //Dizi Tanımlama
            int[] numbers = new int[5];
            int[] numbers2 = new int[3] { 1, 2, 3 };
            int[] numbers3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Dizinin elemanlarına erişim
            numbers[2] = 5; //Diziye eleman yazma.
            int num = numbers[2]; //Diziden eleman okuma.

            Console.WriteLine("\n" + new string('*', 20) + '?');

            //Dizinin tüm elemanlarına erişim.
            string[] sehirler2 = { "İstanbul", "Ankara", "İzmir", "Bursa", "Adana" };
            for (int i = 0; i < sehirler2.Length; i++)
            {
                Console.WriteLine(sehirler2[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            string[] cars = new string[6]
            {
                "BMW",
                "Mercedes",
                "Audi",
                "Toyota",
                "Ford",
                "Volkswagen"
            };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            foreach (char item in "Fatih Alkan")
            {
                Console.WriteLine(item);
            }

            //Objects
            object[] everyitems = { 15, "BMqw", 14.5, 'c' };
            int[] deneme = new int[4] { 10, 11, 12, 13, };
            Console.WriteLine(deneme[3] * 3);
            Console.WriteLine((int)everyitems[0] * 2);
            Console.WriteLine("\n" + new string('-', 50) + "\n");

            #region Ornek-1
            //1) 10 elemanlı bir sayı dizisi tanımlayın.
            //2) Dizinin tüm elemanlarını ekrana yazdırın.
            //3) Dizin toplam değerini ekrana yazdırın.

            double[] numbers45 = new double[10] { 1.5, 2.5, 3.5, 4.5, 5.5, 6.5, 7.5, 8.5, 9.5, 10.5 };
            for (int i = 0; i < numbers45.Length; i++)
            {
                Console.WriteLine(i);
            }
            double total = 0;
            foreach (double item in numbers45)
            {
                total += item;
            }
            Console.WriteLine(total);

            #endregion
            #region Ornek-2
            //Bir öğrencin bir derse ait notlarının hesaplandığı program.
            Console.WriteLine("How many notes Do you want to enter ?");
            int many=Convert.ToInt32(Console.ReadLine());
            double[] numbers7 = new double[many];
            for(int i = 0; i < many; i++)
            {
                Console.WriteLine($"Please write your {i+1}. note.");
                numbers7[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Notlar");
            foreach(double not in numbers7)
            {
                Console.WriteLine(not);
            }
            double notToplam = 0;
            for(int i = 0;i < numbers7.Length; i++)
            {
                notToplam += numbers7[i];
            }
            Console.WriteLine("Ortalama"+notToplam/numbers7.Length);


            #endregion
        }
    }
}
