using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //for (x;y;z;)
            //x; başlangıç
            //y; btiş
            //z;artış-azalış

            //for (int i = 1; i <= 10; i++) 
            //{ 
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i<= 50; i++)
            //{
            //    Console.WriteLine("Şampiyon");
            //}

            //for (int i = 5; i < 113; i += 5) 
            //{
            //    Console.WriteLine(i);
            //}

            //int number;
            //Console.Write("Ekrana Kaç Adet Yazılmasını İstediğiniz Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++) 
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}


            #endregion
            #region For Döngüsü İle Karar Yapıları

            //for (int i = 1; i <=100; i++)
            //{
            //    if(i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int totalValue = 0;

            //for (int i = 0; i <=10; i++)
            //{
            //    totalValue += i;

            //}
            //Console.WriteLine(totalValue);


            //int totalValue = 0;

            //for (int i = 0;i <=100; i++)
            //{
            //    if (i% 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //} 
            //Console.WriteLine("--------------------------");
            //Console.WriteLine(totalValue);

            //int count = 0;

            //for (int i = 1; i <=50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bacterium = 1;
            //for (int i = 1; i <=24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".saatte " + bacterium);

            //}

            #endregion
            #region While

            //int i = 0;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 0;
            //while(i <= 50)
            //{
            //    if(i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while(i <= 20)
            //{
            //    sum += i;
            //    i++;

            //}
            //Console.WriteLine(sum);

            #endregion
            #region ödev sorusu
            //Kullanıcı tarafından girilen 3 baamaklı sayının rakamları toplamını bulma

            //int one, ten, hundred;
            //int total;

            //Console.WriteLine("Rakamaları toplamını bulmak istediğiniz sayıyı yazınız: ");
            //int number = int.Parse(Console.ReadLine());

            //one = number / 100;
            //ten = (number % 100)/10;
            //hundred = number % 10;

            //total = one + ten + hundred;
            //Console.WriteLine();
            //Console.WriteLine("Toplamı: " + total);

            #endregion


            Console.Read();

        }
    }
}
