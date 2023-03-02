namespace Homework6_Soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Soru2

            //10 tane random sayıyı ekrana yazan methodu yazınız.

            Write_Random();

            #endregion
        }

        static void Write_Random()
        {
            Random rd = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}. number = {rd.Next()}");
            }
        }
    }
}