using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemoo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri m)
        {
            Console.WriteLine("musteri eklendi: " + m);
        }

        public void MusteriSilme(Musteri m)
        {
            Console.WriteLine("musteri silindi");
        }

        public void MusteriListeleme(Musteri[] m)
        {

            foreach (var musteri in m)
            {

                Console.WriteLine(musteri);
            }

        }
    }
}
