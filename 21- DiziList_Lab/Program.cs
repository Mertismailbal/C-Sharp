namespace _21__DiziList_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir sınıftaki 5 öğrencinin notlarını bir diziye kayedecek programı yazınız ve bu notların ortalamasını hesaplayınız.

            //string[] students = new string[5];
            //int[] notes = new int[5];
            //Console.WriteLine($"{students.Length} students' name enter ?");
            //for(int i = 0; i < students.Length; i++)
            //{
            //    Console.Write($"Student {i + 1} name: ");
            //    students[i] = Console.ReadLine();
            //}
            //int no = 0;
            //foreach(string student in students)
            //{
            //    Console.WriteLine(student+"'s note will be filled.");
            //    notes[no] = Convert.ToInt32(Console.ReadLine());
            //    no++;
            //}
            //int total = 0;
            //for(int j = 0; j < notes.Length; j++)
            //{
            //    Console.WriteLine($"{students[j]}'s note is {notes[j]}.");
            //    total += notes[j];

            //}
            //double avarage =(total) / notes.Length;
            //for (int z = 0; z < students.Length; z++)
            //{
            //    if (notes[z] >= avarage)
            //    {
            //        Console.WriteLine($"{students[z]} is success with {notes[z]}.");
            //    }
            //    else
            //        Console.WriteLine($"{students[z]} is fail with {notes[z]}.");
            //}

            //Kullanıcıdan alınan ürünlerle bir alışveriş listesi oluşturan program yazınız.
            List<string> basket=new List<string>();
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("Please enter the product you want to add to the basket: ");
                string product = Console.ReadLine();
                basket.Add(product);
                Console.WriteLine("Do you want to continue adding products? (yes/no)");
                string answer = Console.ReadLine().ToLower();
                if (answer != "yes")
                {
                    isContinue = false;
                }
            }
            isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("İf you bought some products please enter the name one by one.");
                string product = Console.ReadLine();
                if (basket.Contains(product))
                {
                    basket.Remove(product);
                    Console.WriteLine($"{product} has been removed from your basket.");
                    
                    
                }
                else
                {
                    Console.WriteLine("Product couldn't find");

                }
                Console.WriteLine("Do you want to keep going ?");
                isContinue = Console.ReadLine().ToLower() == "yes" ? true : false;
            }

        }
    }
}
