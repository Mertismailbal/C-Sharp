namespace _9__Ternary_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ternary If
            //If ifadesinin, daha basit ve kısa sözdizimine sahip kullanım şeklidir.
            //Tek satırda ufak bir karar mekanizması ile yolumuza devam etmek istiyorsanız. Genellikle bir koşulun sonucuna bağlı olarak bir değişkene veri atama istediğimizde kullanılır.

            int number= 3>2?10:20; //Eğer 3>2 ise number değişkenine 10 değerini ata, değilse 20 değerini ata.
            Console.WriteLine(number);

            number -= 10;

            //string sonuc;
            //if (sayi > 0)
            //{
            //    sonuc = "Pozitif";
            //}
            //else
            //{
            //    sonuc = "Negatif";
            //}
            //Along with ternary if
            string result = number >= 0 ? "Positive" : "Negative";
            Console.WriteLine(result);

            Console.WriteLine("Username: ");
            string userName = Console.ReadLine();

            //if (userName == "admin")
            //{
            //    Console.WriteLine("Hoşgeldiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Giriş");
            //}

            //Along with ternary if
            Console.WriteLine(userName=="admin"?"Hoşgeldiniz":"I am not let you go inside");

            #region Example-1
            //Disaridan siparis alinacak olan kitap miktari girilsin. Sipari sayisi 20'den azsa toplam ucretten %5, 20 - 50 araliginda ise %10, 50-100 araligi ise %15, 100'den fazla ise %25 indirim yapilsin. Kitabın birim fiyatı => 50 TLdir... Amac => Odenecek tutari kullaniciya gostermek...

            Console.WriteLine("How many books Would you like to order ? ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Price Per Book is 50$");
            double TotalPrice = 0;  
            while (true)
            {
                bool isValidInput = int.TryParse(Console.ReadLine(), out int bookCount); // Kullanıcıdan kitap sayısını al ve geçerli bir sayı olup olmadığını kontrol et
                if (isValidInput==false||bookCount<=0)
                {
                    Console.WriteLine("Please enter a valid number of books.");
                    continue; // Geçersiz girişte döngüyü başa sar
                }
                else if(bookCount<20)
                {
                    Console.WriteLine("Bekleniyor...");
                    Thread.Sleep(2000); // 2 saniye beklet
                    Console.Beep();     // Bip sesi çıkar
                    TotalPrice = bookCount * 50 * 0.95; // %5 indirim
                    Console.WriteLine("You owe: {0} ",TotalPrice);
                    break;

                }
                else if (bookCount >= 20 && bookCount < 50)
                {
                    Console.WriteLine("Bekleniyor...");
                    Thread.Sleep(2000); // 2 saniye beklet
                    Console.Beep();     // Bip sesi çıkar
                    TotalPrice = bookCount * 50 * 0.90; // %10 indirim
                    Console.WriteLine("You owe: {0} ", TotalPrice);
                    break;
                }
                else if (bookCount >= 50 && bookCount < 100)
                {
                    Console.WriteLine("Bekleniyor...");
                    Thread.Sleep(2000); // 2 saniye beklet
                    Console.Beep();     // Bip sesi çıkar
                    TotalPrice = bookCount * 50 * 0.85; // %15 indirim
                    Console.WriteLine("You owe: {0} ", TotalPrice);
                    break;
                }
                else
                {
                    Console.WriteLine("Bekleniyor...");
                    Thread.Sleep(2000); // 2 saniye beklet
                    Console.Beep();     // Bip sesi çıkar
                    TotalPrice = bookCount * 50 * 0.75; // %25 indirim
                    Console.WriteLine("You owe: {0} ", TotalPrice);
                    break;
                }


            }
            #endregion
        }
    }
}
