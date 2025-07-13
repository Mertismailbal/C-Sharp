using System.Diagnostics.Metrics;
using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace _8__Decision_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programın akışımı kontrol etmek ve belirli koşullara göre işlem yapmak için kullanılan yapısal elemanlardır.
            //-IF Else
            //-Ternary If
            //-Switch Case

            #region If-Else
            //Mantıksal bir ifadenin sonucuna bağlı olarak iki farklı kod bloğundan sadece birini çalıştırmayı seçmek için if deyimi kullanılır.

            if (true) //Mantıksal Ifade veya (Koşul)
            { //Scope Area
              //Koşul gerçekleşiyorsa - Yapılacak iş 1  
            }
            else
            {
                //Koşul gerçekleşmiyorsa - Yapılacak iş 2
            }

            //Console.Write("User Name: ");
            //string userName = Console.ReadLine();

            //if (userName == "admin") //Koşul gerçekleşiyor mu
            //{
            //    Console.WriteLine("Hoşgeldin Sahip...");
            //}
            //else
            //{
            //    Console.WriteLine("Üzgünüm Tanıyamadım!!!");
            //}

            //Karşılaştırma Operatörler
            /*
             1) == (Eşittir)
             2) != (Eşit Değildir.)
             3) < (Soldaki değerin Sağdaki değerden küçük olması durumu).
             4) > (Soldaki değerin Sağdaki değerden büyük olması durumu)
             5) <= (Soldaki değerin Sağdaki değerden eşit yada ondan küçük olması durumu)
             6) >= (Soldaki değerin Sağdaki değerden eşit yada ondan büyük olması durumu).
             */

            #endregion

            #region Example-1
            // Take two notes from the user and calculate the average of them. As well as tell that user pass or failed from the lesson.

            int note1, note2,result;
            Console.WriteLine("Please enter your first note: ");
            note1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second note: ");
            note2 = Convert.ToInt32(Console.ReadLine());
            result = (note1 + note2) / 2;
            if (result >= 50)
            {
                Console.WriteLine("Congratulations, you passed the lesson with an average of {0}", result);
            }
            else
            {
                Console.WriteLine("Unfortunately, you failed the lesson with an average of {0}", result);
            }
            #endregion

            #region Example-2
            int note;
            Console.WriteLine("Write your note: ");
            Label:
            try
            {
                note = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception message)
            {
                Console.WriteLine(message.Message.ToString());
                goto Label;
            }           

            if(note<0||note>100)
            {
                Console.WriteLine("Please enter a valid note between 0 and 100.");
                goto Label;
            }
            else if (note >= 50)
            {
                Console.WriteLine("Congratulations, you passed the lesson with a note of {0}", note);
            }
            else
            {
                Console.WriteLine("Unfortunately, you failed the lesson with a note of {0}", note);
            }
            #endregion

            #region Exapmle-3
            //Ask the user to enter a number and determine whether it is even or odd.
            int number;
        Label_1:
            try
            {
                Console.Write("Number : ");
                number = int.Parse(Console.ReadLine());

            }
            catch (Exception message)
            {
                Console.WriteLine(message.Message.ToString());
                goto Label_1;
            }
            if(number%2==0)
            {
                Console.WriteLine("The number {0} is even.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is odd.", number);
            }
            #endregion

            #region Gates
            //Kapı Kullanımı
            //AND (VE) && : Her iki şartında gerçekleşmesi durumu
            //OR (VEYA) || : Şartlardan en az birinin gerçekleşmesi durumu

            //Dip Not
            //AND (VE) & koşulun bir tarafını kontrol eder olumsuz ise diğer tarafı kontrole etmez.
            //OR (VEYA) |

            //Console.Write("Kullanıcı Adı: ");
            //string kullaniciAdi = Console.ReadLine();

            //Console.Write("Kullanıcı Şifre: ");
            //string kullaniciSifre = Console.ReadLine();

            //if (kullaniciAdi == "admin" && kullaniciSifre == "1234")
            //{
            //    Console.WriteLine("Tebrikler, tum bilgiler dogru. Hoş geldiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("Üzgünüm. Kullanıcı Adı veya Şifre hatalı.");
            //}

            //Console.WriteLine(new string('*',20));


            //if (kullaniciAdi == "admin")
            //{
            //    if (kullaniciSifre == "1234")
            //    {
            //        Console.WriteLine("Tebrikler, tüm bilgiler doğru.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kullanici Adı doğru ama Şifre hatalı");
            //    }
            //}
            //else 
            //{
            //    Console.WriteLine("Kullanıcı Adı yanlış. Şifre yanlış mı bil");
            //}
            Console.WriteLine(new string('?',40));
            //Dışarıdan ürün adı girilecek, uygulama bize hangi bölümde olduğunu söylecek.

            //Domates, biber, patlıcan => Sebze bölümüne bakınız.
            //Diş macunu, parfüm, şampuan => Kozmetik bölümü
            //telefon, tablet, pc => teknoloji bölümü
            //başka bir ürün girerse => aradığınız ürün bizde yok.

            //Console.WriteLine("Ürün Giriniz: ");
            //string product = Console.ReadLine();

            //if (product == "Domates" || product == "Biber" || product == "Salatalık" || product == "Patlıcan")
            //{
            //    Console.WriteLine("Sebze bölümüne bakınız Kat-2");
            //}
            //else if (product == "dis macunu" || product == "tuvalet kagıdı" || product == "parfum" || product == "sabun")
            //{
            //    Console.WriteLine("Kozmetik bölümüne bakınız");
            //}
            //else if (product == "pc" || product == "telefon")
            //{
            //    Console.WriteLine("Teknoloji bölümüne bakınız.");
            //}
            //else 
            //{
            //    Console.WriteLine("Marketten çıkınız.");
            //}

            //Kullanıcıdan Vize ve Final Notunu isteyecekseniz (Vizenin yüzde 30) (Finalin yüzde 70) alarak ortalama notu bulacaksınız. Ortalama not 0-15 FF 16-30 DD 31-50 CC 51-70 BB 71-100 AA

            double vizeNot, finalNot, ortalama;

            Console.Write("Vize Notunu Giriniz: ");
            vizeNot = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final Notunu Giriniz: ");
            finalNot = Convert.ToInt32(Console.ReadLine());

            ortalama = (vizeNot * 0.30) + (finalNot * 0.70);

            if (ortalama >= 0 && ortalama < 16)
            {
                Console.WriteLine($"Notunuz: {ortalama} - FF");
            }
            else if (ortalama >= 16 && ortalama < 31)
            {
                Console.WriteLine($"Notunuz: {ortalama} - DD");
            }
            else if (ortalama >= 31 && ortalama < 51)
            {
                Console.WriteLine($"Notunuz: {ortalama} - CC");
            }
            else if (ortalama >= 51 && ortalama < 71)
            {
                Console.WriteLine($"Notunuz: {ortalama} - BB");
            }
            else if (ortalama >= 71 && ortalama <= 100)
            {
                Console.WriteLine($"Notunuz: {ortalama} - AA");
            }
            else
            {
                Console.WriteLine("Hatalı not girişi");
            }
            #endregion
        }
    }
}
