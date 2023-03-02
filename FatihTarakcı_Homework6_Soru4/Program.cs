namespace Homework6_Soru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Soru4

            //Bir string array alıp elemanlarını tek bir string yapıp döndüren methodu yazınız.
            
            string[] sarki = { "Oynama", "şıkıdım", "şıkıdım!" };

            Convert(sarki);

            #endregion
        }
        static string Convert(string[] get)
        {
            string array_cnvrt = "";
            for (int i = 0; i < get.Length; i++)
            {
                array_cnvrt += get[i];
            }
            return array_cnvrt;
        }
    }
}