using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    class TekYatak2 : TekYatak1
    {

        public TekYatak2(int OdaNo):base(OdaNo)
        {
            Manzara = 1;
        }

        /*public override void RezerveEkle(string rezerv)
        {
            base.RezerveEkle(rezerv);
        }*/


    }
}



