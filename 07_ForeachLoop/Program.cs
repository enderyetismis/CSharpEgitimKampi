using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            // foreach(1,2,3,4)
            //1 Değişken Türü
            //2 Değişken Adı
            //3 in
            //4 İçerik


            //string[] cities = { "ankara", "istanbul", "izmir", "muğla", "antalya" };
            //foreach(string citie in cities)
            //{
            //    Console.WriteLine(citie);

            //}



            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };
            //foreach (int number in numbers) 
            //{ 
            //    Console.WriteLine(number);
            //};


            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };
            //int total = 0;
            //foreach (int number in numbers) 
            //{
            //    total += number;


            //};
            //Console.WriteLine(total);


            //List<int> number = new List<int>()
            //{
            //    1,2,3,4,5
            //};

            //foreach (int i in number)
            //{
            //    Console.WriteLine(i);
            //};

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}






            #endregion
            #region Öğrenci Not Sistemi

            //Console.WriteLine("****** C# ÖĞRENCİ SINAV SİSTEMİ ******");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------------");
            //Console.Write("Lütfen Sınıftaki Öğrenci Sayısını Giriniz: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("-------------------------------------------------------");

            //string[] studentName = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}.Öğrencinin Adını Giriniz: ");
            //    studentName[i] = Console.ReadLine();
            //    Console.WriteLine();

            //    double totalExam = 0;

            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentName[i]} Adlı Öğrencinin {j+1}. Notunu Giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExam += value;
                    
            //    }
            //    studentExamAvg[i] = totalExam / 3;
            //    Console.WriteLine();


            //}
            //for(int i = 0;i < studentCount;i++)
            //{
            //    Console.WriteLine($"{studentName[i]} Adlı Öğrencinin Not Ortalaması: {studentExamAvg[i]}");

            //    if (studentExamAvg[i ]<50)
            //    {
            //        Console.WriteLine("Öğrenci Dersten Kalmıştır.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Öğrenci Dersten Geçmiştir");
            //    }
            //    Console.WriteLine("-------------------------------------");
            //}







            #endregion




            Console.Read();
        }
    }
}
