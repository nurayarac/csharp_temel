using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
         //  0 ile 100 arasındaki sayıları ikişer ikişer yazdıran program
         for(int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(i);
            }


         //5 ile 100 arasındaki sayıları beşer beşer arttırarak yazdıran program 
         for (int i1 = 5; i1 < 100; i1=i1+5)
            {
                Console.WriteLine(i1);
            }


         //100 den 1 e kadar geriye doğru ekrana sayıları yazan program 
         for (int i2 = 100; i2 >1; i2--)
            {
                Console.WriteLine(i2);
            }


         //1-566 arası 2 ye bölünebilen sayıları ekrana yazdıran program (566 dahil olsun) 
         for (int i3 = 1; i3 <= 566; i3++)
            {
                if(i3 % 2==0)
                    Console.WriteLine(i3);
            }


         //1 ile 60 arasındaki çift sayıları toplayarak sonucu ekranda gösteren program (60 dahil olsun)
         int toplam = 0;
         for (int i4 = 1; i4 <= 60; i4++)
            {
                if (i4 % 2 == 0)
                {
                    toplam = toplam + i4;
                }
            }
         Console.WriteLine(toplam);



         //Girilen iki sayının arasındaki sayıların toplamını bulan program. 
         Console.WriteLine("1.sayiyi giriniz:");
         int a=Convert.ToInt16(Console.ReadLine());
         Console.WriteLine("2.sayiyi giriniz:");
         int b=Convert.ToInt16(Console.ReadLine());
            int toplam2 = 0;
            if (a > b)
            {
                a = a - 1;
                for (int i5 = a; i5 > b; i5--)
                {
                    toplam2 = toplam2 + i5;
                }
                Console.WriteLine(toplam2);
            }
            else if (a < b)
            {
                a = a + 1;
                for (int i5 = a; i5 < b; i5++)
                {
                    toplam2 = toplam2 + i5;
                }
                Console.WriteLine(toplam2);
            }
            else
                Console.WriteLine("Aynı 2 sayi girilemez.");


         //Ekrana 10 kere “isparta” yazdıran program
         int i6 = 1;
         while (i6<=10)
            {
                Console.WriteLine("isparta");
                i6++;
            }
         
         
         //0 ile 100 arasındaki tek sayıları toplayarak sonucu ekranda gösteren program
         int i7 = 0;
         int toplam3 = 0;
         while (i7 < 100)
            {
              if (i7 % 2 == 1)
                {
                    toplam3 = toplam3 + i7;
                }
              i7=i7 + 1;
            }
         Console.WriteLine(toplam3);



            //int dizi[] = { 5,6,7,8,78,45,0,30}; şekilde verilen bir tamsayı dizisinin elemanlarının toplamını
            //bulap ekrana yazan C# programını yazınız.
            int[] dizi = { 5, 6, 7, 8, 78, 45, 0, 30 };
            int toplam4 = 0;
            for (int i = 0; i < dizi.Length; i++)
                toplam4 += dizi[i];
            Console.WriteLine(toplam4);


            //Verilen bir string dizisini, ters sırada (sondan başa doğru) listeleyen C# programını yazınız.
            string[] strDizi = { "Merve", "Pelin", "Oya", "Pınar" };
            int son = strDizi.Length - 1;
            for(int i = son; i >= 0; i--)
            {
                Console.WriteLine(strDizi[i]);
            }


            //Tanımlanan sayılar dizisi içerisindeki çift sayıları ekrana yazdıran C# konsol uygulamasını yazınız.
            int[] sayilar = { 4, 5, -15, 22, -34, 3, 0, 7, 43 };
            foreach(int sayi in sayilar)
            {
                if(sayi%2==0)
                    Console.WriteLine(sayi);
            }



            //Tanımlanan sayılar dizisi içerisindeki sayıların negafit, pozitif ve işaretsiz olma durumlarını yanına yazdıran C# konsol uygulamasını yazınız.
            int[] sayilar2 = { 4, 5, -15, 22, -34, 3, 0, 7, 43 };
            foreach(int sayi in sayilar2)
            {
                if (sayi > 0)
                    Console.WriteLine(sayi + " Pozitif");
                else if (sayi < 0)
                    Console.WriteLine(sayi + " Negatif");
                else
                    Console.WriteLine(sayi + " İşaretsiz");
            }



            //10 elemanlı bir veri grubunda bulunan pozitif,sıfır ve negatif değerlerin sayısını bulup yazan programın C# konsol uygulamasını yazınız.
            int[] sayilar3 = {10,-3,5,0,33,-2,-60,0,-20,-30 };
            int sifirSay = 0, pozitifSay = 0, negatifSay = 0;
            for(int x=0; x < sayilar3.Count(); x++)
            {
                if (sayilar[x] < 0)
                    negatifSay++;
                else if (sayilar[x] > 0)
                    pozitifSay++;
                else
                    sifirSay++;
            }
            Console.WriteLine("Sıfırların sayısı: " + sifirSay);
            Console.WriteLine("Negatiflerin sayısı: " + negatifSay);
            Console.WriteLine("Pozitiflerin sayısı: " + pozitifSay);



            //Kullanıcıdan alınan metin içindeki sesli harf sayısını bulan C# console uygulamasını yazınız.
            char[] harfler = { 'a', 'e','ı', 'i', 'o', 'ö', 'u', 'ü' };
            string metin;
            int sayac = 0;
            Console.WriteLine("Metin giriniz:");
            metin=Console.ReadLine();
            for(int i=0; i<harfler.Length; i++)
            {
                for(int j=0;j<metin.Length; j++)
                {
                    if (metin[j] == harfler[i])
                    {
                        sayac++;
                    }
                }
            }
            Console.WriteLine(sayac);
            
            
            Console.ReadLine();
        }
    }
}
