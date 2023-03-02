namespace Homework6_Soru5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Soru5

            //Bir int array'i alıp eleman değerlerinin ortalamasını ekrana yazan metodu yazınız.

            int[] sayilar = { 4, 45, 32, 85, 25, 89, 65, 102, 43 };

            avg_array(sayilar);

            #endregion
        }

        static void avg_array(int[] array)
        {
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Average of array = {sum / array.Length}");
        }
    }
}