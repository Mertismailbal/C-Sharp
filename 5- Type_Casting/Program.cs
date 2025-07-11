namespace _5__Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tip Dönüşümü (Type Casting): bir veri tipinden başka bir veri tipine değerleri dönüştürme.
            //İki Farklı tip dönüşümü vardır.
            //Implict Conversion (Bilinçsiz Dönüşüm)
            //Explict Conversion (Bilinçli Dönüşüm)

            #region Implict Conversion

            //Bilinçsiz Dönüşüm: Küçük tipten büyük tipe dönüşümde kullanılır ve veri kaybı olmaz.

            short variable = 23456;
            int variable2 = variable; //Küçük tipten büyük tipe dönüşümde veri kaybı olmaz.

            Console.WriteLine("Short degiskeni: {0}, Int degiskeni: {1}",variable,variable2);

            #endregion

            #region Explict Conversion

            int variable3 = 1234567890;
            short variable4 = (short)variable3; //Büyük tipten küçük tipe dönüşümde veri kaybı olabilir.
            Console.WriteLine("Short degiskeni: {0}, Int degiskeni: {1}", variable3, variable4);
            #endregion

            #region Convert Class
            string number = "123";

            int number1=Convert.ToInt32(number); //String'den Int'e dönüşüm

            byte number2 = Convert.ToByte(number); //String'den Byte'a dönüşüm

            short number3 = Convert.ToInt16(number); //String'den Short'a dönüşüm

            long number4 = Convert.ToInt64(number); //String'den Long'a dönüşüm

            double number5 = Convert.ToDouble(number); //String'den Double'a dönüşüm

            float number6 = Convert.ToSingle(number); //String'den Float'a dönüşüm

            char character = 'A';
            Console.WriteLine(Convert.ToInt32(character));

            int number7 = 65;
            Console.WriteLine(Convert.ToChar(number7)); //Int'den Char'a dönüşüm

            #endregion

            #region Parse Method
            //Parse Metodu: yalnızca string veri tipini belirli bir türe dönüştürebilir.
            //Parse metodunun avantajı hızlı ve kolay bir şekilde uygulanması.

            string sayiDizi = "123";
            int sayi;
            double ondalik;


            sayi = int.Parse(sayiDizi);

            int oku = int.Parse(Console.ReadLine());

            int age = int.Parse("37");

            ondalik = double.Parse(sayiDizi);
            double pi = double.Parse("2.14");

            bool doğruMu = bool.Parse("True");

            #endregion

            #region ToString()


            double vizeNot = 70.5;
            string not1 = vizeNot.ToString();
            string sayi1 = 50.ToString();


            #endregion

        }
    }
}
