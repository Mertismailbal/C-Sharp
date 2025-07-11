namespace _3__Object_Var_Dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object, Var, Dynamic

            #region Object
            //Object, tüm tiplerin atasıdır. 
            //Object tipi, genellikle çok çeşitli türlerle çalışmanın gerektiği durumlarda kullanılır.

            object a = 10;
            object b = 'k';
            object c = "metin";
            object d = 12.9;

            Console.WriteLine((int)a * 2);

            #endregion

            #region Var
            //Compile Time ve Run Time

            //Var, derleme zamanında atanan verinin tipine dönüşür. (C# 3.0 ile geldi)


            var a1 = 10;
            var b1 = 'k';
            var c1 = "metin";
            var d1 = 12.9;

            Console.WriteLine(a1 * 2);

            #endregion

            #region Dynamic

            //Dynamic ise çalışma zamanında atanan verinin tipine dönüşür. (C# 4.0 ile geldi)

            dynamic a2 = 10;
            dynamic b2 = 'k';
            dynamic c2 = "metin";
            dynamic d2 = 12.9;

            Console.WriteLine(a2 * 2);

            #endregion

            DateTime now;
            now = DateTime.Now;

            Console.WriteLine(now);
        }
    }
}
