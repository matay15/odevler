using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3_3
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Sisteme Eklendi" + musteri.Adi + musteri.Soyadi + musteri.Id);
        }

        public void  Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Sistemden Silindi");
        }


    }
         
    
    }

