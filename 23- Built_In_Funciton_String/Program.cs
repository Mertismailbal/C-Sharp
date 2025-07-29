namespace _23__Built_In_Funciton_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ornekMetin;
           
//            #region CompareTo
//            //Metodu kullandığınız string değerle metoda parametre olarak verilen değeri sözlük mantığıyla karşılaştırır. Eğer sözlükte aynı lokasyonda yer alıyorsa 0, önceyese -1 sonra ise 1 döndürür.
//            ornekMetin = Console.ReadLine();
//            int sonuc = ornekMetin.CompareTo("Merhaba");
//            switch (sonuc)
//            {
//                case 0:
//                    Console.WriteLine("Kelime ile diğer kelime eşleşmekte");
//                    break;
//                case -1:
//                    Console.WriteLine("eşleşmemektedir eksik karakter var");
//                    break;
//                case 1:
//                    Console.WriteLine("Eşleşmeemektedir fazla karakter var.");
//                    break;
//                default:
//                    break;
//            }

//            #endregion

//            #region Contains
//            bool include = ornekMetin.Contains("Merhaba");
//            Console.WriteLine(include ? "Aradığınız metin var" : "aradığınız metin yok.");
//            #endregion

//            #region StartWith
//            //Metodun amacı verilen string değerin başlangıç karakterlerini kontrol etmektir. Eğer başlangıç karakteri verilen değerle eşleşiyorsa true, değilse false döndürür.Büyük küçük harfte önemli.
//            bool beginning = ornekMetin.StartsWith("Mer");
//            Console.WriteLine(beginning ? "Eşleşme var" : "Eşleşme yok");
//            #endregion

//            #region EndWith
//            bool result = ornekMetin.EndsWith("Kadın");

//            Console.WriteLine(result);
//            #endregion

//            #region IndexOf
//            //Metodun amacı verilen string değerin içinde aranan karakterin ilk geçtiği indeksi bulmaktır. Eğer karakter bulunamazsa -1 döndürür.
//            int index = ornekMetin.IndexOf("Merhaba");
//            Console.WriteLine(index);
//            #endregion

//            #region LastIndexOf
//            //Eğer varsa index numarasını yoksa - 1

//            int index1 = ornekMetin.LastIndexOf('a');
//            Console.WriteLine(index1);
//            #endregion

//            #region Remove

//            ornekMetin = ornekMetin.Remove(3, 2);

//            Console.WriteLine(ornekMetin);
//            #endregion

//            #region Replace 
//            //Metodun amacı verilen string değerin içinde aranan karakteri başka bir karakterle değiştirmektir. Eğer karakter bulunamazsa orijinal string değeri döndürülür.
//            ornekMetin = ornekMetin.Replace("Merhaba", "Mer");
//            Console.WriteLine(ornekMetin);
//            #endregion

//            #region Split
//            //Metodun amacı verilen string değeri belirli bir karaktere göre parçalara ayırmaktır. Eğer karakter bulunamazsa orijinal string değeri döndürülür.
//            string[] kelimeler = ornekMetin.Split(',', ';');
//            foreach (var item in kelimeler)
//            {
//                Console.WriteLine(item);
//            }
//            #endregion

//            #region Project
//            Console.WriteLine("Mail gönderme Programı");
//            Console.WriteLine("Kime: ");
//            string mailAdresleri = Console.ReadLine();
//            string[] mailler = mailAdresleri.Split(';');
//            Console.WriteLine($"Gönderilicek olan mail adresleri; \n");
//            for (int i = 0; i < mailler.Length; i++)
//            {
//                Console.WriteLine(mailler[i] + "\n");
//            }
//            #endregion

//            #region Insert
//            Araya eklemek.
//            ornekMetin = Console.ReadLine();
//            ornekMetin = ornekMetin.Insert(5, "cik");
//            Console.WriteLine(ornekMetin);
//            #endregion

//            #region ToLowerToUpper

//            ornekMetin = Console.ReadLine();
//            Console.WriteLine(ornekMetin.ToLower());
//            Console.WriteLine(ornekMetin.ToUpper());
//            #endregion

//            #region SubString
//            Metodun amacı verilen string değerin içinde aranan karakterin ilk geçtiği indeksi bulmaktır.Eğer karakter bulunamazsa - 1 döndürür.
//            ornekMetin = Console.ReadLine();

//            ornekMetin = ornekMetin.Substring(3, 3);
//            Console.WriteLine(ornekMetin);

//            #endregion
//            #region Trim
//            Metodun amacı verilen string değerin başındaki ve sonundaki boşlukları kaldırmaktır.Eğer boşluk bulunamazsa orijinal string değeri döndürülür.
//            ornekMetin = Console.ReadLine();
//            ornekMetin = ornekMetin.Trim();
//            Console.WriteLine(ornekMetin);
//            #endregion
//            Kullanıcıdan alınan bir cümle içinde ki kelime sayısını ve çümlede geçen en uzun kelimenin uzunluğunu bulan bir C# programı yazınız.
//            Console.WriteLine("Lütfen bir kelime yazınız.");
//            string word = Console.ReadLine();
//            int lenght = word.Length;
//            string[] words = word.Split(' ');
//            int enUzunKelime = words[0].Length;
//            foreach (var item in words)
//            {
//                if (item.Length > enUzunKelime)
//                {
//                    enUzunKelime = item.Length;
//                }
//            }
//            Console.WriteLine("En uzun kelime" + enUzunKelime);
            }
    }
}
