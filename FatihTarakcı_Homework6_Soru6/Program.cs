namespace Homework6_Soru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Soru6

            //Bir int arrayi alıp eleman değerlerini toplayıp, toplamı dönen methodu yazınız.

            int[] sayilar = { 4, 45, 32, 85, 25, 89, 65, 102, 43 };

            int result = Sum(sayilar);

            Console.WriteLine(result);

            #endregion
        }

        static int Sum(int[] number)
        {
            int sum_array = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum_array += number[i];
            }
            return sum_array;
        }
    }
}