namespace Homework6_Soru1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Soru1

            //Kullanıcıdan isim, soyisim ve yaş biglsini alıp yanyana yazdıran methodu yazınız.
            //(Yaş int olacak) (isim, soyisim, yaş bilgileri Main methodunda istenecek )
            string name, surname;
            int age;
            while (true)
            {
                Console.Write("\nenter your name = ");
                name = Console.ReadLine();
                Console.Write("\nenter your surname = ");
                surname = Console.ReadLine();
                Console.Write("\nenter your age = ");
                bool age_info = int.TryParse(Console.ReadLine(), out age);
                if (name is not "" && surname is not "" && age_info)
                    break;
                else Console.WriteLine("\nincorrect or incomplete entry!");
            }
            Console.WriteLine($"\nPerson info = {Person(name, surname, age)} ");
            #endregion
        }

        static string Person(string name, string surname, int age)
        {
            return name.ToUpper() + " " + surname.ToUpper() + ", " + age;
        }
    }
}