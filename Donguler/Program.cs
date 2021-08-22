using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi
            string[] kurslar = new string[] 
                {"Yazılım geliştirici yetiştirme",
                "programlamaya başlangıç",
                "java","Python","C++","C#" };
            

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for finished");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
