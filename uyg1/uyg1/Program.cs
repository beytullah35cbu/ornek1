using System;

namespace ArabaProgrami
{
    class araba
    {
        public string marka;
        public short model;
        public string renk;
    }

    class Program
    {
        static void Main(string[] args)
        {
            araba benimArabam = new araba();
            benimArabam.marka = "Toyota";
            benimArabam.model = 2022;
            benimArabam.renk = "Kırmızı";

            Console.WriteLine("Marka: " + benimArabam.marka);
            Console.WriteLine("Model: " + benimArabam.model);
            Console.WriteLine("Renk: " + benimArabam.renk);

            Console.ReadKey();
        }
    }
}
