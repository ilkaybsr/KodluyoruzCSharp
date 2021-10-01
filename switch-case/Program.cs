using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)  //Expression (kontrol etmek istenen koşul ) 
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız!");
                    break;
                case2:
                    Console.WriteLine("Şubat ayındasınız!");
                    break;
                case4:
                    Console.WriteLine("Nisan ayındasınız!");
                    break;
                case3:
                    Console.WriteLine("Mart ayındasınız!");
                    break;

                default:             //Hiçbir keys uymadığı  taktirme yapılacak olan işlem
                    Console.WriteLine("Yanlış veri girişi!");
                break;              //hiçbir şey yapmak istenmiyorsa direk çıkılır

            }


            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış ayındasınız!");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar ayındasınız!");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz ayındasınız!");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Yaz ayındasınız!");
                    break;
                default:
                    break;
            }
        }
    }
}
