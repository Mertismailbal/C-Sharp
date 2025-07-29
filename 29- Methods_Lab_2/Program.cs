namespace _29__Methods_Lab_2
{
    internal class Program
    {   
        static List<string> students = new List<string>();
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }
        }
        static void Menu()
        {
            Console.WriteLine("1 - Öğrenci Ekle");
            Console.WriteLine("2 - Öğrencileri Listele");
            Console.WriteLine("3 - Öğrenci Sil");
            Console.WriteLine("4 - Çıkış");
            Console.WriteLine("Please Choose one of them ?");
            string choice;
            try
            {
                choice = Console.ReadLine();
            }
            catch 
            {
                choice = "4"; // Default to exit if input is invalid
            }
            switch (choice)
            {
                case "1":
                    Console.WriteLine("which name of student do you want to add ?");
                    string name = Console.ReadLine().ToLower().Trim();
                    AddStudent(name);
                    break;
                case "2":
                    ListStudents();
                    break;
                case "3":
                    RemoveStudent();
                    break;
                case "4":
                    Console.WriteLine("Programdan çıkılıyor...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem seçimi.");
                    break;
            }

        }
        static void AddStudent(string name)
        {
            if (!students.Contains(name)&&name is not null) {
                students.Add(name);
                Console.WriteLine($"{name} is added to list.");
            }
            else
                Console.WriteLine(name+" is already in the list or name is null. Please try again.");
        }
        static void ListStudents()
        {
            if (students.Count > 0)
            {
               for(int i=0; i < students.Count; i++)
                {
                    Console.WriteLine(students[i]);
                }
            }
            else {
                Console.WriteLine("There is nobody in the list do you want to add anyone ? [E]-[H]");
                if(Console.ReadLine()?.ToUpper().Trim() == "E")
                {
                    Console.WriteLine("Please enter the name of the student you want to add:");
                    string name = Console.ReadLine().ToLower().Trim();
                    AddStudent(name);
                }
                else
                {
                    Menu();
                }
            }
        }
        static void RemoveStudent()
        {
            if (students.Count > 0)
            {
                Console.WriteLine("Which student do you want to Remove");
                string deletedName= Console.ReadLine().ToLower().Trim();
                if (students.Contains(deletedName))
                {
                    int index=students.IndexOf(deletedName);
                    students.RemoveAt(index);
                    //students.Remove(deletedName); 
                }
                else
                {
                    Console.WriteLine("There is no such student in the list.");
                }
            }
            else
            {
                Console.WriteLine("There is nobody in the list do you want to add anyone ? [E]-[H]");
                if (Console.ReadLine()?.ToUpper().Trim() == "E")
                {
                    Console.WriteLine("Please enter the name of the student you want to add:");
                    string name = Console.ReadLine().ToLower().Trim();
                    AddStudent(name);
                }
                else
                {
                    Menu();
                }
            }
        }

    }
}
