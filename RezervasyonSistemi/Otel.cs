using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    class Otel
    {
        
        TekYatak1[] Odalar = new TekYatak1[12];


        public Otel()//otel sınıfını çağırdığında odaları oluşturuyoruz
        {
            for (int i = 0; i < 2; i++)
            {
                Odalar[i] = new TekYatak1(11 + i);
                Odalar[i + 2] = new TekYatak2(13 + i);
                Odalar[i + 4] = new CiftYatak1(21 + i);
                Odalar[i + 6] = new CiftYatak2(23 + i);
                Odalar[i + 8] = new CiftKisilikYatak1(31 + i);
                Odalar[i + 10] = new CiftKisilikYatak2(33 + i);
            }
        }
        

        public void RezerveEt(string AdSoyad, string Tel, DateTime giris, DateTime cikis, int odaNo, int RezervasyonNo)//odaya rezervasyon ekliyoruz
        {
            if (odaNo == 11)
            {
                Odalar[0].RezerveEkle(AdSoyad, Tel, giris, cikis, odaNo,RezervasyonNo);
            }
            else if (odaNo == 12)
            {
                Odalar[1].RezerveEkle(AdSoyad, Tel, giris, cikis, odaNo, RezervasyonNo);
            }
            else if (odaNo == 13)
            {
                Odalar[2].RezerveEkle(AdSoyad, Tel, giris, cikis, odaNo, RezervasyonNo);
            }
            else if(odaNo == 14)
            {
                Odalar[3].RezerveEkle(AdSoyad, Tel, giris, cikis, odaNo, RezervasyonNo);
            }
            else if(odaNo == 21)
            {
                Odalar[4].RezerveEkle(AdSoyad, Tel, giris, cikis, odaNo, RezervasyonNo);
            }
            else if(odaNo == 22)
            {
                Odalar[5].RezerveEkle(AdSoyad, Tel, giris, cikis, odaNo, RezervasyonNo);
            }
            else if(odaNo == 23)
            {
                Odalar[6].RezerveEkle(AdSoyad, Tel, giris, cikis, odaNo, RezervasyonNo);
            }
            else if(odaNo == 24)
            {
                Odalar[7].RezerveEkle(AdSoyad, Tel, giris, cikis, odaNo, RezervasyonNo);
            }
            else if(odaNo == 31)
            {
                Odalar[8].RezerveEkle(AdSoyad, Tel, giris, cikis, odaNo, RezervasyonNo);
            }
            else if(odaNo == 32)
            {
                Odalar[9].RezerveEkle(AdSoyad, Tel, giris, cikis, odaNo, RezervasyonNo);
            }
            else if(odaNo == 33)
            {
                Odalar[10].RezerveEkle(AdSoyad, Tel, giris, cikis, odaNo, RezervasyonNo);
            }
            else if(odaNo == 34)
            {
                Odalar[11].RezerveEkle(AdSoyad, Tel, giris, cikis, odaNo, RezervasyonNo);
            }
        }

       

    }
}

