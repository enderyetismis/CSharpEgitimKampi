using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleDeğişkenler

            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;

            //applePrice = 4.79;
            //orangePrice = 5.50;
            //strawberryPrice = 35.75;
            //patatoPrice = 3.75;
            //tomatoPrice = 2.50;

            //Console.WriteLine("******Sebze Ve Meyve Fiyat Listesi******");
            //Console.WriteLine();
            //Console.WriteLine("--Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("--Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("--Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("--Patates Birim Fiyatı: " + patatoPrice + " TL");
            //Console.WriteLine("--Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;

            //appleGram = 2.350;
            //orangeGram = 2.650;
            //strawberryGram = 3.125;
            //patatoGram = 20.500;
            //tomatoGram = 5.480;

            //double appleCount, orangeCount, strawberryCount, patatoCount, tomatoCount;

            //appleCount = applePrice * appleGram;
            //orangeCount = orangePrice * orangeGram;
            //strawberryCount = strawberryPrice * strawberryGram;
            //patatoCount = patatoPrice * patatoGram; 
            //tomatoCount = tomatoPrice * tomatoGram;

            //double totalPrice = appleCount + orangeCount + strawberryCount + patatoCount + tomatoCount;

            //Console.WriteLine();
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("******Ödenecek Hesap Tutarı******");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Elma Birimi: " + appleGram + " Gram" + " Fiyatı: " + appleCount + " TL");
            //Console.WriteLine("Alınan Portakal Birimi: " + orangeGram + " Gram" + " Fiyatı: " + orangeCount + " TL");
            //Console.WriteLine("Alınan Çilek Birimi: " + strawberryGram + " Gram" + " Fiyatı: " + strawberryCount + " TL");
            //Console.WriteLine("Alınan Patates Birimi: " + patatoGram + " Gram" + " Fiyatı: " + patatoCount + " TL");
            //Console.WriteLine("Alınan Domates Birimi: " + tomatoGram + " Gram" + " Fiyatı: " + tomatoCount + " TL");
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");



            #endregion
            #region CharDeğişkenler

            //char symbol;
            //symbol = 'A';
            //Console.WriteLine(symbol);

            #endregion
            #region Klavyeden Veri Girişleri String Değişkenler

            //string passengerName, passengerSurname, passengerAge, passengerDistrict, passengerCity, passengerIdentityNumber;

            //Console.WriteLine("**HAVA YOLLARI**");
            //Console.WriteLine();

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("İl: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("TC No: ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.Write("Yolcu Bilgileri:  "+ passengerIdentityNumber + " - " + passengerName + " " + passengerSurname + " - " + passengerDistrict + "/" + passengerCity + " - " + passengerAge);


            #endregion
            #region Klavyeden Veri Girişleri İnt Değişkenler


            //int shoesPrice, computerPrice, chairPrice, tvPrice;


            //shoesPrice =5 00;
            //computerPrice = 20000;
            //chairPrice = 350;
            //tvPrice = 80000;

            //int shoesCost, computerCost, chairCost, tvCost;
            //Console.WriteLine("********KASA********");
            //Console.WriteLine();

            //Console.Write("Alınan Ayakkabı Sayısını Giriniz: ");
            //shoesCost = int.Parse(Console.ReadLine());

            //Console.Write("Alınan Bilgisayar Sayısını Giriniz: ");
            //computerCost = int.Parse(Console.ReadLine());

            //Console.Write("Alınan Sandalye Sayısını Giriniz: ");
            //chairCost = int.Parse(Console.ReadLine());

            //Console.Write("Alınan TV Sayısını Giriniz: ");
            //tvCost = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //int totalPrice;
            //totalPrice = shoesCost * shoesPrice + computerCost * computerPrice + chairCost * chairPrice + tvCost * tvPrice;

            //Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice);
            #endregion
            #region Klavyeden Veri Girişleri Double Değişkenler

            //double exam1, exam2, exam3;
            //Console.WriteLine("**********Not Ortalaması**********");
            //Console.WriteLine();
            //Console.Write("Lütfen 1. Sınav Notunu Giriniz?: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Giriniz?: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunu Giriniz?: ");
            //exam3 = double.Parse(Console.ReadLine());

            //double total = (exam1 + exam2 + exam3) / 3 ;

            //Console.WriteLine("Sınav Ortalamanız = " + total);





            #endregion
            #region Klavyeden Veri Girişleri Char Değişkenler

            //Console.WriteLine("******Cinsiyet Seçimi E/K*********");
            //Console.WriteLine();
            //char gender;
            //Console.Write("Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Cinsiyetiniz = "+ gender);



            #endregion


            Console.Read();
        }
    }
}
