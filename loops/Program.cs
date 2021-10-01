﻿using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
            Console.Write("Lütfen bir sayı giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if(i%2==1)
                    Console.WriteLine(i);
            }

            //1 ile 1000 arasında ki çift ve tek sayıların kendi içlerinde toplamlarını ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam += i;   //tekToplam = tekToplam +i;
                else
                    ciftToplam += i;  //ciftToplam = ciftToplam +i;
            }
            Console.WriteLine("Tek Toplam:" + tekToplam);
            Console.WriteLine("Çift Toplam" + ciftToplam);

            //break -- Eğer döngüyü sonlandırmak isterseniz
            //continue -- Şarta bağlı olarak atlama sağlar

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
