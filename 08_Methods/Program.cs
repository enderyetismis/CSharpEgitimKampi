using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar


            //void cities()
            //{
            //    Console.WriteLine("Ankara");
            //    Console.WriteLine("Antalya");
            //    Console.WriteLine("İzmir");
            //    Console.WriteLine("İstanbul");
            //}

            //cities();
            //cities();
            //cities();
            //cities();

            //void sum() 
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z =  x + y;
            //    Console.WriteLine(z);

            //}

            //sum();

            #endregion
            #region Geriye Değer Döndürmeyen String Paremetreli Metotlar


            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //writeMethod("Ali Yıldız");

            //void customerCard(string name, string surname)
            //{
            //    Console.WriteLine($"Müşteri: {name} {surname}");
            //}

            //customerCard("Ali", "Yıldız");
            #endregion
            #region #region Geriye Değer Döndürmeyen Int Paremetreli Metotlar

            //void sum(int number1, int number2, int number3)
            //{
            //    int total = number1 + number2 + number3;
            //    Console.WriteLine(total);
            //}

            //sum(5,10,15);


            #endregion
            #region Geriye Değer Döndüren Metotlar

            //string customerName()
            //{
            //    return "Ali Yıldız";
            //}
            //customerName();

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yıldız";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(studentCard());
            #endregion
            #region Geriye Döndüren String Paremetreli Metotlar

            //string countryCard(string country, string capital, string flagClour)
            //{
            //    string cardInfo = "Ülke: " + country + " Başkent: " + capital + " Bayrak Rengi: " + flagClour;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Başkent Adını Giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Barak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(countryCard(x,y,z));



            #endregion
            #region Geriye Döndüren Int Paremetreli Metotlar

            //int sum(int number1, int number2, int number3) 
            //{
            //    int result = number1 + number2 + number3;
            //    return result;

            //}

            //Console.WriteLine(sum(5,20,15));

            #endregion
            #region Örnek Uygulama
            //string ExamResult(string student, int exam1, int exam2, int exam3) 
            //{

            //    int total = (exam1 + exam2 + exam3) / 3;
            //    if (total >= 50)
            //    {
            //        return student + " Adlı Öğrenci Sınavı Geçti. Ortalama: " + total;
            //    }

            //    else 
            //    {
            //        return student + " Adlı Öğrenci Sınavı Geçemedi. Ortalama: " + total;
            //    }

            //}



            //Console.WriteLine(ExamResult("Ali", 40, 70, 50));

            
            #endregion
            Console.Read();

        }
    }
}
