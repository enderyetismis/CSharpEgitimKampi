using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            //Console.WriteLine("Lütfen şifreyi giriniz ? : ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{

            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, contry;

            //Console.WriteLine("Başkent: ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülke: ");
            //contry = Console.ReadLine();

            //if (capital == "Ankara" & contry == "Türkiye")
            //{
            //    Console.WriteLine("Bilgiler Doğru");
            //}
            //else 
            //{
            //    Console.WriteLine("Bilgiler Hatalı");
            //}


            //int exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.WriteLine("******************Sınav Not Hesaplayıcı*************");
            //Console.WriteLine();

            //Console.Write("1.Sınav Notu: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sınav Notu: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3.Sınav Notu: ");
            //exam3 = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav Ortalaması: " + average);

            //if (average > 0 & average < 49)
            //{
            //    result = "Kaldın ";
            //}
            //if (average >= 50 & average < 70)
            //{
            //    result = "Orta";
            //}
            //if (average >= 70 & average < 85)
            //{
            //    result = "İyi";
            //}
            //if (average >= 85 )
            //{
            //    result = "Çok İyi";
            //}

            //Console.WriteLine(result);

            //string username;

            //Console.Write("Kullanıcı adı giriniz: ");
            //username = Console.ReadLine();
            //Console.WriteLine();

            //if (username != "admin") 
            //{
            //    Console.WriteLine("Kullanıcı yetkisiz");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı Yetkisi Verildi");
            //    Console.WriteLine("Hoş Geldiniz..");
            //}

            //string clour;

            //Console.Write("İstediğiniz Boya Rengini Seçiniz: ");

            //clour = Console.ReadLine();

            //if (clour == "mavi" | clour == "sarı" | clour == "kırmızı" | clour == "mor")
            //{
            //    Console.WriteLine("Elimizde " + clour + " Rengi vardır.");
            //}
            //else
            //{
            //    Console.WriteLine("Elimizde " + clour + " Rengi Yoktur Başka Renk Seçiniz.");
            //}




            #endregion
            #region Mod İşlemleri

            //int sayi1 = 20 , sayi2 =8;

            //Console.WriteLine(sayi1% sayi2);

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //int number1, number2, result;

            //Console.Write("1.Sayi : ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sayi: ");
            //number2 = int.Parse(Console.ReadLine());

            //result = number1 % number2;
            //Console.WriteLine("1.Sayının 2.sayıya bölümünden kalan: " + result);

            //int number1;
            //Console.WriteLine("*******Bir sayının çift olup olmadığını bulma*******");
            //Console.WriteLine();
            //Console.Write("Sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //if (number1 % 2 == 0)
            //{
            //    Console.WriteLine("SAYI ÇİFTTİR.");
            //}
            //else
            //{
            //    Console.WriteLine("SAYI TEKTİR.");
            //}





            #endregion
            #region Char İşlemleri
            //char result;
            //Console.WriteLine("*********TAKIM SEÇME*********");
            //result = char.Parse(Console.ReadLine());
            //Console.WriteLine();

            //if (result == 'g' | result == 'G')
            //{
            //    Console.WriteLine("Takım Seçimi Galatasaray");
            //}
            //if (result == 'f' | result == 'F')
            //{
            //    Console.WriteLine("Takım Seçimi Fenerbahçe");
            //}
            //if (result == 'b' | result == 'B')
            //{
            //    Console.WriteLine("Takım Seçimi Beşiktaş");
            //}




            #endregion
            #region Örnek Proje

            //Console.WriteLine("********** C# RESTAURANT MENU **********");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Salatalar");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine("5-İçecekler");
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine();

            //int number;
            //Console.Write("Menü Numarası Seçimi: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 1) 
            //{
            //    Console.WriteLine("*****Ana Yemekler*****");
            //    Console.WriteLine("1-Tavuk Sote");
            //    Console.WriteLine("2-Et Haşlama");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Sebze Yemeği");

            //}
            //if (number == 2)
            //{
            //    Console.WriteLine("*****Çorbalar*****");
            //    Console.WriteLine("1-Tavuk");
            //    Console.WriteLine("2-Mercimek");
            //    Console.WriteLine("3-İşkembe");
            //    Console.WriteLine("4-Ezo Gelin");

            //}
            //if (number == 3)
            //{
            //    Console.WriteLine("*****Salatalar*****");
            //    Console.WriteLine("1-Mevsim");
            //    Console.WriteLine("2-Akdeniz");
            //    Console.WriteLine("3-Ton Balıklı");
            //    Console.WriteLine("4-Havuç");

            //}
            //if (number == 4)
            //{
            //    Console.WriteLine("*****Tatlılar*****");
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Puding");
            //    Console.WriteLine("3-Keşkül");
            //    Console.WriteLine("4-Baklava");

            //}
            //if (number == 5)
            //{
            //    Console.WriteLine("*****İçecekler*****");
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine("4-Fanta");

            //}


            #endregion
            #region Switch Case

            //Console.WriteLine("Ay numarasını giriniz: ");
            //int mountNumber = int.Parse(Console.ReadLine());

            //switch (mountNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break ;
            //    case 3: Console.WriteLine("Mart"); break ;
            //    case 4: Console.WriteLine("Nisan"); break ;
            //    case 5: Console.WriteLine("Mayıs"); break ;
            //    case 6: Console.WriteLine("Haziran"); break ;
            //    case 7: Console.WriteLine("Temmuz"); break ;
            //    case 8: Console.WriteLine("Ağustos"); break ;
            //    case 9: Console.WriteLine("Eylül"); break ;
            //    case 10: Console.WriteLine("Ekim"); break ;
            //    case 11: Console.WriteLine("Kasım"); break ;
            //    case 12: Console.WriteLine("Aralık"); break ;
            //    default: Console.WriteLine("Hatalı Giriş"); break;
            //}

            #endregion
            #region Switch Case Hesap Makinesi


            //int number1, number2, result;
            //char symbol;

            //Console.WriteLine("*****Hesap Makinesi*****");
            //Console.WriteLine();

            //Console.Write("1.Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("İşlem Seçiniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2; 
            //        Console.WriteLine("İşlem sonucu: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("İşlem sonucu: " + result);
            //        break ;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("İşlem sonucu: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("İşlem sonucu: " + result);
            //        break;
            //    default: Console.WriteLine("Hatalı İşlem Seçimi"); break;

            //}
            #endregion

            Console.Read();
        }
    }
}
