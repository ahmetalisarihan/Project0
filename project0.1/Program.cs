using System;

namespace project0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirme kampı";
            string kurs2 = "proramlamaya başlangıç için temel kurs";

            //array - dizi

            string[] kurslar = new string[] { "yazılım geliştirme kampı", "proramlamaya başlangıç için temel kurs", "Java","Python"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {

            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
