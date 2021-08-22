using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Hakkı";
            int yas = 22;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Hakkı Dere";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Hellim Peyniri";
            kurs2.IzlenmeOrani = 60;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "İmge Şimal";
            kurs3.IzlenmeOrani = 72;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Yasin Dere";
            kurs4.IzlenmeOrani = 86;


            Kurs[] kurslar = new Kurs[]
            {
                kurs1,kurs2,kurs3,kurs4
            };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen +" "+ kurs.IzlenmeOrani);
            }
            
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }

    }
}
