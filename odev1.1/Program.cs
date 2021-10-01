using System;

namespace odev1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.WriteLine("Pozitif Bir Sayı Giriniz : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(("{0} adet sayı giriniz" ,n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. Sayıyı giriniz: " , i+1);
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi %2==0)
                {
                    Console.WriteLine("çift" + sayi);
                }
            }
        }
    }
}
