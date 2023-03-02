
namespace Homework6_Soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Soru3

            //Kullanıcıdan iki kenar değerini alıp dikdörtgenin alanını yazdıran methodu ve çevresini hesaplayıp, sonucu dönen methodu yazın. (iki kenar değeri Main methodunda istenecek)
            //(İki tane method yazılacak. 1. Method alanını yazdıracak. 2. Method Çevresini hesaplayacak)

            int length_1, length_2;

            while (true)
            {
                Console.Write("\nenter first length of rectangular = ");
                bool length1_info = int.TryParse(Console.ReadLine(), out length_1);
                Console.Write("\nenter second length of rectangular = ");
                bool length2_info = int.TryParse(Console.ReadLine(), out length_2);

                if (length1_info && length2_info)
                    break;
                else Console.WriteLine("\nincorrect or incomplete entry!");
            }
            Console.Write($"\nRectangular Area = {Calculate_Area(length_1, length_2)}");
            Console.WriteLine($" || Rectangular Perimeter = {Calculate_Prmtr(length_1, length_2)}");

            #endregion
        }
        static int Calculate_Area(int length1, int length2)
        {
            return length1 * length2;
        }
        static int Calculate_Prmtr(int length1, int length2)
        {
            return (length1 + length2) * 2;
        }

    }
}