namespace _2__Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# programlama dilinde, değerleri saklamak ve işlemekl için kullanılan adlandırılmış bellek yapılarıdır.

            /* Yorum satırı için yukarıdaki gibi veya uzun haldekiler için bunu kullanabilirz.*/
            int a = 1;
            int b = 2;
            int c = a + b;
            Console.WriteLine(c);
            int d, e;
            e = 45;

            //Değişken Tanımlama
            //veri_tipi degisken_adi
            //veri_tipi: değişkenin saklayacağı veri türünü belirtir.
            //degisken_adi: taşıyacağınız veriye erişim için vereceğiniz isim.

            //Değişken Tanımlama
            //veri_tipi degisken_adi
            //veri_tipi: değişkenin saklayacağı veri türünü belirtir.
            //degisken_adi: taşıyacağınız veriye erişim için vereceğiniz isim.

            //Değişken Tanımlamada Dikkat Edilecek Durumlar
            /*
                Tanımlama yaparken büyük-küçük harf ayrımı vardır.
                Değişken adı rakam ile başlamaz. Rakamla bitebilir.
                Teknik isimler verilemez.
                Özel karakter içermez. (_) hariç
                Boşluk kullanılamaz.
                Türkçe karakter kullanılmamalıdır.

                *camelCase
                *Kullanmıyacağınız değişkenleri asla tanımlamayınız.
             */

            //Temel Veri Tipleri
            #region Sayısal Veri Tipleri

            //Min: -128 Max: 127 - 8bit
            sbyte degiskenBir = 127;

            //Min: 0 Max: 255 - 8 bit
            byte degiskenIki = 255;

            //Min: -32768 Max: 32767 - 16 bit
            short degiskenUc = -23456;

            //Min: 0 MAx: 65535 - 16 bit
            ushort degiskenDort = 12312;

            //*Int => 32 bit
            //Min: -2.1 Milyar Max: 2.1 Milyar
            int degiskenBes = -12321312;
            Int32 degiskenAlti = 12312312;

            //Min: 0 Max 4.2 Milyar
            uint degiskenYedi = 1231231212;

            //Min: -9.2 Katrilyon Max: 9.2 Katrilyon - 64 Bit
            long degiskenSekiz = 21312321312213;

            //Max: 18 Katrilyon. Min:0
            ulong degiskenDokuz = 12312312312312312311;

            //Ondalıklı Sayılar

            //.dan sonra 7 hane desteği => 32bit
            float ondalikliSayi1 = 2.121F;

            //.dan sonra 13 hane desteği => 64bit
            double ondalikliSayi2 = 2.12312321;

            //.dan sonra 27 hane desteği => 128bit
            decimal ondalikliSayi3 = 2.1232m;

            #endregion

            #region Metinsel Veri Tipleri

            //Karakter
            char basHarfim = 'A';

            string metin = "Buraya istediğiniz yazı yazabilirsiniz.";

            #endregion

            #region Mantıksal veri Tipleri

            bool bugunTatilmi = true;
            bool yeniKayitVarmi = false;
            bool buyukMu = 10 > 2;

            Console.WriteLine(buyukMu);
            #endregion

            #region Örnek-1
            string name, surName;
            Console.WriteLine("Lütfen adınızı giriniz: ");
            name = Console.ReadLine();
            Console.WriteLine("Lütfen soyadınızı giriniz: ");
            surName = Console.ReadLine();
            Console.WriteLine($"İsminiz : {name+" "+surName}");
            #endregion

            //Operatörler (Toplama(+), Fark(-), Carpım(*), Bolum(/))
            #region Ornek-2
            int sayi1 = 10, sayi2 = 20;
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);

            #endregion

            #region Ornek-3
            int yas = 37;
            int yil = 2024;

            int dogumYili = yil - yas;
            Console.WriteLine(dogumYili);
            #endregion

            #region Ornek-4
            string ad = "Mert";
            string soyad = "Bal";

            string tamIsim = ad + " " + soyad;
            Console.WriteLine(tamIsim);
            #endregion

            #region Ornek-5
            double toplamPara = 100;
            double kisiSayisi = 3;
            double kisiBasiPara = toplamPara / kisiSayisi;

            Console.WriteLine(kisiBasiPara);
            #endregion

            #region Ornek-6
            bool gectiMi = true;
            Console.Write("Sınavdan Geçti Mi?");
            Console.WriteLine(gectiMi);
            #endregion

            #region Ornek-7
            //(+) Birleştirme Operatörü

            string name2 = "Mert";
            int age = 37;

            //Birleştirme Operatörü
            Console.WriteLine("Benim adım: " + name + " dir. Yaşım: " + (age + 2) + " dır.");

            //PlaceHolder (Yer Tutucu)
            Console.WriteLine("Benim adım: {0} dır. Yaşım: {1} dır.", name, age + 2);

            //String Interpolation
            Console.WriteLine($"Benim adım: {name} dır. Yaşım {age + 2} dır.");

            //Escape Sequences
            Console.WriteLine("\t Merhaba Dünya \n Bilge Adam \t Yazılım Eğitimi \\ Hocamızdan notlar \"Console.Writeline('Ders Bitti)\"");

            #endregion

            #region Escape Sequeances   
            Console.WriteLine("1. Yeni satır kullanımı (\\n):");
            Console.WriteLine("Merhaba\nDünya");

            Console.WriteLine("\n2. Sekme boşluğu (\\t):");
            Console.WriteLine("Ad:\tAhmet");
            Console.WriteLine("Soyad:\tYılmaz");

            Console.WriteLine("\n3. Çift tırnak kullanımı (\\\"):");
            Console.WriteLine("Ona dedi ki: \"Hoş geldin!\"");

            Console.WriteLine("\n4. Ters slash karakteri (\\\\):");
            Console.WriteLine("Dosya yolu: C:\\Users\\Ahmet");

            Console.WriteLine("\n5. Tek tırnak kullanımı (\\'):");
            Console.WriteLine("O\'nun arabası var.");

            Console.WriteLine("\n6. Geri silme karakteri (\\b):");
            Console.WriteLine("ABC\bD"); // Çıktı: ABD

            Console.WriteLine("\n7. Satır başına dönme (\\r):");
            Console.Write("Yükleniyor...");
            Thread.Sleep(1000);
            Console.Write("\rTamamlandı!   "); // Önceki yazının üstüne yazar

            Console.WriteLine("\n\n8. Beep sesi (\\a):");
            Console.Write("\a"); // Bip sesi (bazı bilgisayarlarda çalışmayabilir)

            Console.WriteLine("\n\nProgram sona erdi.");
            #endregion

            #region Ornek-9
            //İki tam sayı tanımlanacak üçüncü bir değişken kullanmadan yer değiştirme sağlanacak
            //a=23 b=34 => a=34 b=23

            int f=23, g = 34;
            Console.WriteLine($"Önceki Değerler: f={f}, g={g}");
            f = f + g;
            g = f - g;
            f = f - g;
            Console.WriteLine("İşlem sonrası f: {0} ve g: {1}", f, g);

            #endregion

            #region Örnek-10
            int z = 10, y = 20, x = 30;
            if (x < y)
            {
                x = x + y;
                y = x - y;
                x = x - y;
            }

            if(y < z)
            {
                y = y + z;
                z = y - z;
                y = y - z;
            }

            if(x < z)
            {
                z = z + x;
                x = z - x;
                z = z - x;
            }

            Console.WriteLine($"Sonuç: x={x}, y={y}, z={z}\a");
            #endregion
        }
    }
}
