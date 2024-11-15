using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Özellikleri

            //string[] sample = new string[5];
            //sample[0] = "a";
            //sample[1] = "b";
            //sample[2] = "c";
            //sample[3] = "d";
            //sample[4] = "e";

            //Console.WriteLine(sample[4]);


            //string[] colors = new string[4];
            //colors[0] = "blue";
            //colors[1] = "red";
            //colors[2] = "black";
            //colors[3] = "yellow";

            //Console.WriteLine(colors[3]+ " " + colors[0]);

            //int[] numbers = new int[14];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[4] = 5;
            //numbers[5] = 6;

            //Console.WriteLine(numbers[8]);

            //string[] cities = { "Ankara", "İstanbul", "Bodrum", "Antalya"};

            //Console.WriteLine(cities[0]);

            #endregion
            #region Dizideki Tüm Elemanları Yazdırma

            //string[] colors = { "Mavi", "Sarı", "Kırmızı", "Beyaz", "Mor"};

            //for (int i = 0;i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 3, 78, 86, 95, 105, 118, 79, 60, 556, 1000 };
            //for(int i = 0; i <numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] symbol = { 'a', 'b', '+', '*', '6'};
            //for(int i = 0; i < symbol.Length; i++)
            //{
            //    Console.WriteLine(symbol[i]);
            //}

            //int[] myArray = { 50, 569, 450, 40, 13, 28, 568, 456, 593, 457, 1525 };
            //int maxArray = myArray[0];

            //for ( int i = 0; i < myArray.Length; i++ )
            //{
            //    if ( myArray[i] > maxArray)
            //    {
            //        maxArray = myArray[i];
            //    }

            //}

            //Console.WriteLine(maxArray);

            //int[] myArray = { 50, 569, 450, 40, 13, 28, 568, 456, 593, 457, 1525 };
            //Array.Sort(myArray);
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}


            //int[] myArray = { 50, 569, 450, 40, 13, 28, 568, 456, 593, 457, 1525 };
            //Array.Reverse(myArray);
            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}


            #endregion
            #region Dizi Metotlar

            //string[] customer = { "Ali","mehmet","ayşe","fatma","buse"};
            //int index = Array.IndexOf(customer, "ayşe");
            //Console.WriteLine(index);


            //int[] myArray = { 50, 569, 450, 40, 13, 28, 568, 456, 593, 457, 1525 };
            //Console.WriteLine("Max: " + myArray.Max() + " Min: " + myArray.Min());

            #endregion
            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}.şehir ismini giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //for(int i = 0;i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] myArray = { 50, 569, 450, 40, 13, 28, 568, 456, 593, 457, 1525 };
            //int sum = 0;
            //for (int i = 0; i< myArray.Length; i++) { sum += myArray[i]; }
            //Console.WriteLine($"Toplam Sonuç: {sum}");


            //int[] myArray = { 50, 569, 450, 40, 13, 28, 568, 456, 593, 457, 1525 };

            //Console.WriteLine("*********Çift Sayılar******");
            //Console.WriteLine();
            //for (int i = 0; i < myArray.Length; i++)
            //{   
            //    if(myArray[i] %2 == 0)
            //    {
                    
            //        Console.WriteLine(myArray[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("*********Tek Sayılar******");
            //Console.WriteLine();
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] % 2 == 1)
            //    {

            //        Console.WriteLine(myArray[i]);
            //    }
            //}


            #endregion






            Console.Read();


            

        }
    }
}
