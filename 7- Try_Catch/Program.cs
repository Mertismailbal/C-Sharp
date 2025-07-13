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

        //    #region Örnek-1

        //    int number1, number2, dıvıdedBy = 3;            
            
        //    try
        //    {
        //        Console.WriteLine("Would you like to write your first number ?");
        //        number1 = int.Parse(Console.ReadLine());
        //        Console.WriteLine("Would you like to write your second number ?");
        //        number2 = int.Parse(Console.ReadLine());

        //        Console.WriteLine("The reminder will be left from the division: {0} ",(number1+number2)%dıvıdedBy);
        //    }
        //    catch (Exception)
        //    {
        //        //Herhangi hata geldiğinde çalışacak alan.
        //        Console.WriteLine("Bir sayı bile giremedin...");
        //    }


        //    #endregion

        //    #region Örnek-2
            
        //    try
        //    {
        //        Console.WriteLine("This blank has to be filled with your phone number ?");
        //        int phoneNumber = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Your phone number is: {0}", phoneNumber);
        //    }
        //    catch (Exception hata)
        //    {

        //        Console.WriteLine(hata.Message.ToString()); 
        //    }
        //#endregion

        //    #region Örnek-3

        //    Label_1:

        //    try
        //    {
        //        Console.WriteLine("Please fill the blank with your phone number ?");
        //        int phoneNumber = int.Parse(Console.ReadLine());
        //    }
        //    catch (FormatException formatError)
        //    {
        //        //Dönüştürmeden kaynaklı uyumsuzlukta çalışır.
        //        Console.WriteLine("Your format of input was wrong. {0}", formatError.Message.ToString());
        //        goto Label_1; //Etiket kullanımı ile tekrar deneme
        //    }
        //    catch(OverflowException overflowError)
        //    {
        //        //Değerin sınırlarını aşması durumunda çalışır.
        //        Console.WriteLine("Your input was too large or too small. {0}", overflowError.ToString());
        //        goto Label_1; //Etiket kullanımı ile tekrar deneme
        //    }
        //    catch (Exception hata)
        //    {
        //        //Diğer tüm hatalar için çalışır.
        //        Console.WriteLine("An unexpected error occurred: {0}", hata.Message.ToString());
        //        goto Label_1; //Etiket kullanımı ile tekrar deneme
        //    }
        //    finally
        //    {                 //Try-Catch blokları çalıştıktan sonra her durumda çalışacak alandır.
        //        Console.WriteLine("Program has finished its execution.");
        //    }


        //#endregion

        #region Program            
        // Produce the program that takes two numbers from the user using Try-Catch and goto statements, and performs a simple division operation with these numbers.
        //FormatException
        //OverflowException
        //DivideByZeroException

        Label_2:

            double number5, number6, result;
            try
            {
                Console.WriteLine("Which numbers Do you want to Divide ?");
                number5=double.Parse(Console.ReadLine());
                Console.WriteLine("By which number do you want to divide it?\"");
                number6 = double.Parse(Console.ReadLine());
                result = number5 / number6;
                Console.WriteLine("The result of the division is: {0}", result);
            }
            catch (FormatException formatError)
            {
                Console.WriteLine(formatError.Message.ToString());
                goto Label_2;
            }
            catch (OverflowException overflowError)
            {
                Console.WriteLine(overflowError.Message.ToString());
                goto Label_2;
            }
            catch (DivideByZeroException divideByZeroError)
            {
                Console.WriteLine("You cannot divide by zero. {0}", divideByZeroError.Message.ToString());
                goto Label_2;   
            }
            catch (Exception hata)
            {
                Console.WriteLine("An unexpected error occurred: {0}", hata.Message.ToString());
                goto Label_2; 
            }
            finally
            {
                Console.WriteLine("Program has finished its execution.");
            }


            #endregion
        }
    }
}
