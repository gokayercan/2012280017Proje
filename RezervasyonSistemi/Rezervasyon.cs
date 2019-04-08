using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    class Rezervasyon
    {
        Otel otel = new Otel();
        public int RezervasyonNo, sayac=0;


        public void RezervasyonOlustur(string AdSoyad, string Tel,DateTime giris, DateTime cikis, int odaNo)
        {
            RezervasyonNo = 100 + sayac;
            otel.RezerveEt(AdSoyad, Tel, giris, cikis, odaNo,RezervasyonNo);//otel sınıfına rezervasyonu eklemek için verileri gönderiyoruz
            sayac++;
        }

    }
}
