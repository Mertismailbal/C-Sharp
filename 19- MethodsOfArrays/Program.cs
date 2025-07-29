using System.Security.Cryptography.X509Certificates;

namespace _19__MethodsOfArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi Properties(Özellik) ve Methods (Metotlar)
            string[] cities = { "İstanbul", "Ankara", "İzmir", "Bursa", "Adana","Ankara" };

            //Lenght: Dizinin boyutunu verir.
            Console.WriteLine(cities.Length);

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("\n" + new string('*', 20));

            #region Clear
            //Temizleme
            //Array.Clear(cities);
            //Array.Clear(cities,3,2); //3. indexten başlayarak 2 elemanı temizler.
            
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
            #endregion
            #region Sort
            //Dizinin elemanını küçükten büyüğe doğru sıralar.
            //Array.Sort(cities);
            Console.WriteLine(new string('-',20));
            Array.Sort(cities, 2, 3); //Belirli bir alanı sıralama.

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
            #endregion
            #region IndexOf
            //Dizide aradığımız elemanın index nuamrasını bize döndürür.Eğer aradığımız eleman yoksa -1 döner. Aramaya en baştan başlar o nedenle aynı öğreden birden fazla varsa ilk bulduğunu döndürür.

            Console.WriteLine("Aramak istediğiniz şehri seçiniz: ");
            string searchCity = Console.ReadLine();
            int index=Array.IndexOf(cities,searchCity);
            Console.WriteLine(index);
            index = Array.IndexOf(cities, searchCity, 2);
            Console.WriteLine(index);
            Console.WriteLine(index>0? "Aradığınız index blundu":"Aradığınız bulunamadı");
            #endregion
            #region LAstIndexOf
            //En sondan aramaya baslar
            Console.WriteLine("Aramak istediğiniz şehri seçiniz ?");
            Console.WriteLine(Array.LastIndexOf(cities,Console.ReadLine()));
            #endregion
            #region Reverse
            //Dizinin elemanlarını ters çevirir.
            Array.Reverse(cities);
            foreach(string city in cities)
            {
                Console.WriteLine(city+" "+Array.IndexOf(cities,city));
            }
            #endregion
            #region Copy
            string[] cities2 = new string[6];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    cities2[i] = cities[i];
            //};

            Array.Copy(cities, cities2, 4);
            foreach (string city in cities2)
            {
                Console.WriteLine(city);
            }
            #endregion
            #region Resize
            //Yeniden boyutlandırma.

            Array.Resize(ref cities, 12);
            Console.WriteLine("Yeni Boyut: " + cities.Length);

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}
