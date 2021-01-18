using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();

            kurs1.kursAdi = "c#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();

            kurs1.kursAdi = "java";
            kurs1.Egitmen = "ömer";
            kurs1.IzlenmeOrani = 26;


            Kurs kurs3 = new Kurs();

            kurs1.kursAdi = "phyton";
            kurs1.Egitmen = "ahmet";
            kurs1.IzlenmeOrani = 80;

            Console.WriteLine(kurs1.kursAdi + " : " + kurs1.Egitmen);

        }
    }


    class Kurs
    {
        public string kursAdi { get; set; }

        public String Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }


}