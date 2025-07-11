using System;

namespace _7__Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              ISTISNA TIPLERİ
             -Derleme Zamanı Hatası (Compile Time): Derleme aşamasında ortaya çıkan hatalardır. Bu tür hatalar genellikle yazım hataları (syntax) olarak karşımıza çıkar. Yönetmesi en kolay hata tipidir. Visual Studio anlık olarak bizlere yardımcı olur.

             -Calışma Zamanı Hatası (Runtime): Program çalışırken ortaya çıkan hatalardır. Yüzde 90 kullanıcı odaklıdır. Try-Catch bloklarıyla yönetilebilir.

             -Mantıksal Hatalar: Uygulamanın algoritmasından kaynaklıdır. Yüzde yüz yazılımcı kaynaklı hatalardır.
              */

            #region Örnek-1

            int number1, number2, dıvıdedBy = 3;            
            
            try
            {
                Console.WriteLine("Would you like to write your first number ?");
                number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Would you like to write your second number ?");
                number2 = int.Parse(Console.ReadLine());

                Console.WriteLine("The reminder will be left from the division: {0} ",(number1+number2)%dıvıdedBy);
            }
            catch (Exception)
            {
                //Herhangi hata geldiğinde çalışacak alan.
                Console.WriteLine("Bir sayı bile giremedin...");
            }


            #endregion
        }
    }
}
