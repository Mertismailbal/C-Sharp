
namespace _20__List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T>, genellikle dizilere benze şekilde veri saklamak ve işlemek için kullanılan dinamik bir koleksiyon (Collection) türüdür.

            //Dizinin Handikapları
            //1-Boyut zorunluluğu
            //2-Tip zorunluluğu

            //List<string> sehirler = new List<string>() { "Istanbul", "Ankara", "Izmir" };
            //sehirler.Add("Trabzon");
            //sehirler.Add("Konya");
            //sehirler.Add("Samsun");

            //Console.WriteLine(sehirler[2]);

            List<string> cities= new List<string>(){
                "Istanbul",
                "Ankara",
                "Izmir",
                "Bursa",
                "Adana"
            };
            cities.Add("Trabzon");
            cities.Add("Konya");
            cities.Add("Samsun");
            Console.WriteLine(cities);

            foreach(string city in cities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine(cities.Count);
            cities.Add("Rize");
            cities.Add("Edirne");
            cities.Add("Bingöl");

            Console.WriteLine("Ekleme Yapıldı Yeni Boyut: " + cities.Count);
            cities.Remove("Ankara"); //Elemanı siler."
            cities.RemoveAt(2); //İndex numarasına göre siler.
            Console.WriteLine("Silme Yapıldı Yeni Boyut: " + cities.Count);
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine(cities[i]);
            }

            //List<T> elamanları dizilere benzer şekilde saklar ancak boyutu dinamik olarak büyütebilir ve küçültebilir. Dizelere göre daha esnek ve geniş kullanım imkanı sağlar. Ancak büyük koleksiyonlarda performans açısından dikattli kullanılması gerekebilir.

            List<int> numbers = new List<int>()
            {
                10,20,30
            };
            numbers.Add(40);
            numbers.TrimExcess();// Listeyi en son eklenen eleman sayısına göre boyutlandırır. Yani fazladan bellek kullanımını önler.
            #region ReferenceType

            Console.WriteLine("\n" + new string('*', 20) + "\n");
            Console.WriteLine("Sayılar - 1\n");

            List<double> sayilar1 = new List<double>();
            sayilar1.Add(50);
            sayilar1.Add(44.9);
            sayilar1.Add(53.5);
            sayilar1.Add(34);

            foreach (double sayi in sayilar1)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("\n" + new string('*', 20) + "\n");
            Console.WriteLine("Sayılar - 2\n");

            List<double> sayilar2 = sayilar1;
            sayilar2.Add(12);
            sayilar2.Add(43);

            foreach (double sayi in sayilar2)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("\n" + new string('*', 20) + "\n");
            Console.WriteLine("Sayılar - 1\n");

            foreach (double sayi in sayilar1)
            {
                Console.WriteLine(sayi);
            }

            //Burası çok öneöli çünkü referans tipli bir yapı olduğundan dolayı sayilar1 ve sayilar2 aynı bellekteki veriyi tutuyorlar. Yani birinde yapılan değişiklik diğerini de etkiler.
            #endregion
        }


    }
}
