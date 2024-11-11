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

            string username;

            Console.Write("Kullanıcı adı giriniz: ");
            username = Console.ReadLine();
            Console.WriteLine();

            if (username != "admin") 
            {
                Console.WriteLine("Kullanıcı yetkisiz");
            }
            else
            {
                Console.WriteLine("Kullanıcı Yetkisi Verildi");
                Console.WriteLine("Hoş Geldiniz..");
            }




            #endregion

            Console.Read();
        }
    }
}
