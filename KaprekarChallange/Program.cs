using System;

namespace Kaprekar
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = Int32.Parse(Console.ReadLine());

            int q = int.Parse(Console.ReadLine());

            bool VarMi = false;

            for (int i = p; i <= q; i++)
            {
                if (VarMi == false)
                    VarMi = KaprekarMi(i);
                if (KaprekarMi(i))
                    Console.Write(i + " ");
            }

            if (VarMi == false)
                Console.WriteLine("INVALID RANGE");

            Console.ReadKey();
        }

        static bool KaprekarMi(int sayi)
        {
            double karesi = Math.Pow(sayi,2);
            int n = sayi.ToString().Length;

            string kareString = karesi.ToString(); //2025

            string sagdan = kareString.Substring(kareString.Length - n);
            string soldan = kareString.Substring(0, kareString.Length - n);

            int toplam = Int32.Parse(sagdan) + int.Parse(soldan == "" ? "0" : soldan);

            return sayi == toplam;
        }
    }
}
