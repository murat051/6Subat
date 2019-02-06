using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student ogrenci = new Student();  // Obje yaratır. 
            Object obj = new Student(); // Neden? Çünkü C# da en temel sınıf object tir. Ondan türer.
            ogrenci.Name = "Mustafa";
            ogrenci.Note = 1;
            ogrenci.Address = "Bakırköy";

            Console.WriteLine("StudentName = " + ogrenci.Name);
            Console.WriteLine("StudentNote = " + ogrenci.Note);
            Console.WriteLine("StudentAddress = " + ogrenci.Address);

            Student tembelOgrenci = new Student();
            tembelOgrenci = ogrenci;
            Console.WriteLine("------------------------");
            Console.WriteLine(tembelOgrenci.Name);

            tembelOgrenci.Name = "Tembel";
            Console.WriteLine("----------------------");
            Console.WriteLine(ogrenci.Name);

        }
    }


    class Student
    {
        //adi
        //not
        //adres
        //Okula Gider
        //Kız arkadaş
        //yemek
        //Ders
        //oyun
        //ne zaman login olmuş
        //kimleri takip ediyor
        //neleri sever

        // Struct lar da class gibidir. Ama struct ta stackte tutulur veriler. Class ta heap te tutulur. C de class yok struct var. C#, python, java da class vardır.

//************************************************************************************************************
            //Fields

        public string Name;  // public demek class dışında da erişilebilir demek.
        public int Note;

        //Properties

        public string _address;

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }

        }
        
        // Methods tanımlanabilir class içinde. 

        public void DoHomeWork()
        {

        }

        public void Print()
        {

        }


    }
}
