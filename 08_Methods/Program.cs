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

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Mehmet Çınar");
            //    Console.WriteLine("Hakan Öztürk");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerNamer)
            //{
            //    Console.WriteLine(customerNamer);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("Mehmet", "YILDIZ");
            //CustomerCard("Ayşegül", "KAYA");


            #endregion

            #region Geriye Değer Döndürmeyen INT Parametreli Metotlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string customerName()
            //{
            //    return "Buse Yıldız";
            //}

            //customerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " / Başkent : " + capital + " / Bayrak Rengi: " + flagColor;

            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));




            #endregion

            #region Örnel Uygulama

            //string ExamResult(string student, int exam1, int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if(result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti " + " ortalama: " + result;

            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı geçemedi " + " ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Ali", 25, 41, 55));
            //Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));

            #endregion



            Console.Read();
        }
    }
}
