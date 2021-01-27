using System;

namespace Odev3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("müşteri Adı Giriniz");
            Musteri musteri1 = new Musteri();
            musteri1.Adi = Console.ReadLine();
            Console.WriteLine("Müşteri Soyadı giriniz");
            musteri1.Soyadi = Console.ReadLine();
            musteri1.Id = 12345;
            Console.WriteLine("---------------------------");



            Console.WriteLine("müşteri Adı Giriniz");
            Musteri musteri2 = new Musteri();
            musteri2.Adi = Console.ReadLine();
            Console.WriteLine("Müşteri Soyadı giriniz");
            musteri2.Soyadi = Console.ReadLine();
            musteri2.Id = 6789;
            Console.WriteLine("---------------------------");

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Id );

            }




        }
    }
}
