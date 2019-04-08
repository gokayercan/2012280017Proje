using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    public interface IOda
    {
        int OdaNo { get; set; }
        bool Klima { get; set; }
        bool Televizyon { get; set; }
        bool OdaServisi { get; set; }
        bool Wifi { get; set; }
        bool Telefon { get; set; }        
        string Rezerve { get; set; }
        bool Banyo { get; set; }
        int Manzara { get; set; }

        void RezerveEkle(string AdSoyad, string Tel, DateTime giris, DateTime cikis, int odaNo, int RezervasyonNo);

    }
}
