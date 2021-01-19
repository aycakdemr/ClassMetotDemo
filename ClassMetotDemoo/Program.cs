using System;

namespace ClassMetotDemoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            Musteri m2 = new Musteri();
            Musteri m3 = new Musteri();
            Musteri m4 = new Musteri();
            Musteri m5 = new Musteri();

            Musteri[] müsteriler = { m1, m2, m3, m4, m5 };

            MusteriManager manager = new MusteriManager();

            manager.MusteriEkleme(m1);
            manager.MusteriEkleme(m2);
            manager.MusteriEkleme(m3);
            manager.MusteriEkleme(m4);
            manager.MusteriEkleme(m5);

            Console.WriteLine("******************************");
            manager.MusteriSilme(m1);

            Console.WriteLine("*******************************");
            manager.MusteriListeleme(müsteriler);
        }
    }
}
