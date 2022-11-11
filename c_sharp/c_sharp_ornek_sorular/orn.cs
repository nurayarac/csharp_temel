using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sınav_oncesi
{
    class Program_1
    {
        static void Main(string[] args)
        {
           /*  string ad = "mehmet";
              string renk = "kırmızı";
              ad = renk;
              renk = "turkey";
              Console.WriteLine(ad);
              Console.WriteLine(renk);    

              int A=8, B=10; A += B; B += A;
              Console.WriteLine(A);
              Console.WriteLine(B);
           */

            /*  • Klavyeden kullanicinin ad ve soyad bilgileri girilecek
              • Girildikten sonra Hosgeldiniz mesaji verilecek.
              • Sonrasinda kullanicinin 1.ve 2.not bilgileri girilecek. 
              • Notlarin toplami ekranda gosterilip sonrasinda % 50 olacak sekilde notlarin ortalamasi ekrana ad soyad bilgileriyle birlikte yazdirilacak
            */
            Console.WriteLine("Adiniz:");
            String ad2 = Console.ReadLine();
            Console.WriteLine("Soyadiniz");
            String soyad = Console.ReadLine();
            Console.WriteLine("Hosgeldiniz " + ad2 + " " + soyad);
            Console.WriteLine("1.notunuz:");
            int not1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2.notunuz:");
            int not2 = Convert.ToInt16(Console.ReadLine());
            int toplam = not1 + not2;
            Console.WriteLine("toplam:" + toplam);
            int ortalama = toplam / 2;
            Console.WriteLine("Sayin " + ad2 + " " + soyad + " " + "not ortalamaniz " + ortalama + "dir");

            //  •Girilen sayının pozitif mi negatif mi olduğunu bulan programı kodlayın.
            Console.WriteLine("Bir sayi giriniz:");
            int a = Convert.ToInt16(Console.ReadLine());
            if (a >= 0)
                Console.WriteLine("Girilen sayi pozitif");
            else
                Console.WriteLine("Girilen sayi negatif");
            

            
          // •Girilen sayının pozitif mi negatif mi olduğunu bulan programı kodlayın.
             Console.WriteLine("Bir sayi giriniz:");
             int a_1=Convert.ToInt16(Console.ReadLine());
             if (a >= 0)
                 Console.WriteLine("Girilen sayi pozitif");
             else
                 Console.WriteLine("Girilen sayi negatif");
            

            
           // • Klavyeden girilen iki sayının ortalaması 50 ve 50 ‘den büyükse «50’den den büyük» , değilse <<50’Den küçük>> yazdıran programı kodlayın.
             Console.WriteLine("1.sayi:");
             int a_2 = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("2.sayi:");
             int b = Convert.ToInt16(Console.ReadLine());
             int ortalama_2=(a+b)/2;
             if (ortalama_2>= 50)
                 Console.WriteLine("<<50'den büyük>>");
             else
                 Console.WriteLine("<<50'den küçük>>");


            // • Klavyeden girilen sayının çift mi tek mi olduğunu bulan programı kodlayın.
             Console.WriteLine("sayi giriniz:");
             int a_3= Convert.ToInt16(Console.ReadLine());
             if (a_3 % 2 == 0)
                 Console.WriteLine("sayi çifttir");
             else
                 Console.WriteLine("sayi tektir");

            /* • Bir kişinin Yaşı ve Cinsiyeti girilsin. Cinsiyet “e” ise ve Yaşı 20 ve 20 den 
            büyükse “Askere Gidebilir” değilse “Askere Gidemez” yazdıran programı kodlayın */
             Console.WriteLine("kişinin yasi:");
             int yas=Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("kisinin cinsiyeti");
             String cns=Console.ReadLine();
             if (cns == "e" && yas >= 20)
                 Console.WriteLine("Askere gidebilir.");
             else
                 Console.WriteLine("Askere gidemez");


           /*  • Kullanıcıdan kare veya dikdörtgen ifadelerinden birinin seçimi istenilecektir. Seçime göre Alan veya Çevre hesaplarından
               hangisinin yapılması gerektiği istenilecektir. Seçime göre kenar uzunlukları istenilecek ve işlemler gerçekleştirilecektir. */
             int a4, b2, cevre, alan;
             string secim1, secim2;
             Console.WriteLine("1-kare");
             Console.WriteLine("2-dikdörtgen");
             Console.WriteLine("secimiz:");
             secim1= Console.ReadLine();
             if (secim1 == "1")
             {
                 Console.WriteLine("1-Alan");
                 Console.WriteLine("2-Cevre");
                 Console.WriteLine("seciminiz:");
                 secim2= Console.ReadLine();
                 if(secim2 == "1")
                 {
                     Console.WriteLine("Kenari giriniz:");
                     a4=Convert.ToInt16(Console.ReadLine());
                     alan = a4 * a4;
                     Console.WriteLine("Karenin alani:"+alan);
                 }
                 if (secim2 == "2")
                 {
                     Console.WriteLine("Kenari giriniz:");
                     a4= Convert.ToInt16(Console.ReadLine());
                     cevre = a4* 4;
                     Console.WriteLine("Karenin cevresi:" + cevre);
                 }
             }
             if (secim1 == "2")
             {
                 Console.WriteLine("1-Alan");
                 Console.WriteLine("2-Cevre");
                 Console.WriteLine("seciminiz:");
                 secim2 = Console.ReadLine();
                 if (secim2 == "1")
                 {
                     Console.WriteLine("uzun kenari giriniz:");
                     a4 = Convert.ToInt16(Console.ReadLine());
                     Console.WriteLine("kisa kenari giriniz:");
                     b2 = Convert.ToInt16(Console.ReadLine());
                     alan = a4* b2 ;
                     Console.WriteLine("Dikdörtgenin alani:" + alan);
                 }
                 if (secim2 == "2")
                 {
                     Console.WriteLine("uzun kenari giriniz:");
                     a4 = Convert.ToInt16(Console.ReadLine());
                     Console.WriteLine("kisa kenari giriniz:");
                     b2 = Convert.ToInt16(Console.ReadLine());
                     cevre = 2*(a4+b2);
                     Console.WriteLine("Dikdörtgenin cevresi:" + cevre);
                 }
            }

        
           // •Klavyeden girilen iki sayıyı + ‘ya basınca toplayan , -basınca çıkaran , *basınca çarpan , / basınca bölen programı kodlayın.
             Console.WriteLine("1.sayi:");
             int a5=Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("2.sayi:");
             int b3 = Convert.ToInt16(Console.ReadLine());
             Console.WriteLine("+  *  -  /");
             Console.WriteLine("Secim yapiniz:");
             String secim=Console.ReadLine();
             int sonuc=0;
             if (secim == "+")
             {
                 sonuc = a5 + b3;
                 Console.WriteLine(sonuc);
             }
             else if(secim == "-")
             {
                 sonuc= a5 - b3;
                 Console.WriteLine(sonuc);
             }
             else if (secim == "*")
             {
                 sonuc = a5 * b3;
                 Console.WriteLine(sonuc);
             }
             else
             {
                 sonuc = a5 / b3;
                 Console.WriteLine(sonuc);
             }


            // •Trafik lambasının renklerine göre ne yapmamız gerektiğini söyleyen console uygulaması(switch case)
            Console.WriteLine("Trafik lambasının rengini giriniz:");
             Console.WriteLine("1-Kırmızı/2-Sari/3-Yesil");
             int secim_2=Convert.ToInt32(Console.ReadLine());
             switch (secim_2)
             {
                 case 1:
                     {
                         Console.WriteLine("Dur!");
                         break;
                     }
                 case 2:
                     {
                         Console.WriteLine("Hazır ol");
                         break;
                     }
                 case 3:
                     {
                         Console.WriteLine("Gec");
                         break;
                     }
                     default:
                     Console.WriteLine("yanlis girdiniz");
                     break;
             }



            // •şifreli bir sitemde giriş yapılmaya çalışılsın.3 kez yanlış girildiği durumda dışarı atılsın. Şifre = 123
            int[] dizi = {1,2,3,4,5,6,7,8,9,10 };
             for(int i = 0; i < dizi.Length; i++)
             {
                 Console.WriteLine(dizi[i]);
             }

             int sifre, sayac = 0;
             do
             {
                 Console.WriteLine("Sifreyi giriniz:");
                 sifre = Convert.ToInt32(Console.ReadLine());
                 if (sifre == 123)
                 {
                     Console.WriteLine("giris basarili");
                 }
                 else
                 {
                     sayac += 1;
                     Console.WriteLine("giris basarisiz");
                 }
              } while (sayac < 3);
        
               Console.ReadLine();
}

}
}
