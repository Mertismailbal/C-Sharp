namespace _11__For_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Döngülerin genel amacı belirli bir kod bloğunu tekrarlatmaktır.
            -For Döngüsü (*Adet,Sayı - Önemli olan bir miktar)
            -While Döngüsü (*Koşul - Belirli bir koşul gerçekleşene kadar.)
            -Do While Döngüsü
            -Foreach Döngüsü (Diziler birlikte kullanılır.)
             */

            //FOr Döngüsü: belir bir miktar geçerli olduğu sürece belirli bir kod bloğunu tekrar çalıştırmak için kullanılan kontrol yapısıdır. (Genellikle belirli bir syaıda tekrarlanan işlem yapmak için kullanılır.)

            //(Başlangıç Değer - Koşul - Artış/Değişim)
            for (int i = 0; i < 10; i++)
            {
                //Döngü bloğu (Her döngüde çalıştırılacak kod blokları buraya yazılır.)
                Console.WriteLine("Merhaba Dünya");
            }

            /*For Döngüsünün Çalışma Mantığı
             * Baştaki i değişkeni, sadece döngünün başında bir defa oluşturulur.
             * Eğer ortadki koşul doğru ise döngü bloğu çalıştırılır.
             * Sondaki kontrol değişkeni güncellenir ve mantıksal ifade yenide hesaplanır.
             * Ortadaki koşul false dönene kadar.
             */

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Döngü sayısı: {0}", i);
            }

            //for (; ;)
            //{
            //    Console.WriteLine("Someone stop me...");
            //}

            #region Exapmle-1
            //1 den 100 kadar olan çift sayıların toplamını ekrana yazdıran program.
            for(int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            //1 den 100 kadar olan çift sayıların toplamı ile tek sayıların toplamını ekrana yazdıran program.
            int oddSum = 0;
            int evenSum = 0;
            for (int i=0;i<=100;i++)
            {
                
                evenSum= i%2==0?evenSum+i: evenSum;
                oddSum = i % 2 == 1 ? oddSum + i : oddSum;
                
            }
            Console.WriteLine($"Total of odd is {oddSum}\nTotal of even is {evenSum}");

            //100 den 0'a kadar olan sayıların hem 3 hemde 7 bölünenleri ekrana yazdır.
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i =0;i<=100;i++)
            {
                if(i%3==0&&i%7==0)
                    Console.WriteLine(i);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            for (char i='A';i <= 'Z'; i++)
            {
                Console.WriteLine((int)i+" "+i);
            }

            for(int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i+"X"+j+" = "+i*j);
                }
            }

            //Kullanıcıdan aldığı uzunluk bilgisine göre ekrana dikdörtgen çizen uygulama.
            Console.Write("Uzunluk-1:");
            int uzunluk1 = int.Parse(Console.ReadLine());

            Console.Write("Uzunluk-2:");
            int uzunluk2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 1; i <= uzunluk1; i++)
            {
                for (int j = 1; j <= uzunluk2; j++)
                {

                    Console.Write("*");
                    Thread.Sleep(500);
                    Console.Beep();
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
