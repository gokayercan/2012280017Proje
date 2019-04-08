using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    public class TekYatak1:IOda//oda interfaceinden tek yatak 1 kalıtıyoruz
    {
        private int odaNo;
        private bool klima;
        private bool televizyon;
        private bool odaServisi;
        private bool wifi;
        private bool telefon;
        private bool banyo;
        private int manzara;
        private string rezerve;

        public int OdaNo//private olan odanoya dışardan erişebilmek için get set kullanıyoruz
        {
            get
            {
                return odaNo;
            }
            set
            {
                odaNo = value;
            }
        }

        public string Rezerve
        {
            get
            {
                return rezerve;
            }
            set
            {
                rezerve = value;
            }
        }

        public bool Klima
        {
            get
            {
                return klima;
            }
            set
            {
                klima = value;
            }

        }

        public bool Televizyon
        {
            get
            {
                return televizyon;
            }
            set
            {
                televizyon = value;
            }

        }

        public bool OdaServisi
        {
            get
            {
                return odaServisi;
            }
            set
            {
                odaServisi = value;
            }

        }

        public bool Wifi
        {
            get
            {
                return wifi;
            }
            set
            {
                wifi = value;
            }

        }

        public bool Telefon
        {
            get
            {
                return telefon;
            }
            set
            {
                telefon = value;
            }

        }

       public bool Banyo
        {
            get
            {
                return banyo;
            }
            set
            {
                banyo = value;
            }

        }

        public int Manzara
        {
            get
            {
                return manzara;
            }
            set
            {
                manzara = value;
            }

        }      

        public TekYatak1(int OdaNo)
        {
            this.OdaNo = OdaNo;
            Klima = true;
            Televizyon = true;
            OdaServisi = true;
            Wifi = true;
            Telefon = true;
            Banyo = true;
            Manzara = 0;
        }

        public void RezerveEkle(string AdSoyad, string Tel, DateTime giris, DateTime cikis, int odaNo,int RezervasyonNo)//gelen rezervasyon bilgilerini kaydediyoruz
        {
            Rezerve += AdSoyad + Tel + giris + cikis + odaNo + RezervasyonNo + "/r/n";
        }

        


    }
}
