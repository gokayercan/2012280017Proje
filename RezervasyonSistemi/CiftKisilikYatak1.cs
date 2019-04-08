using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    class CiftKisilikYatak1:CiftYatak1//çift yatak1den çiftkişilikyatak1 sınıfını türettik kalıtım içinde kalıtım
    {
        private bool kuvet;

        public bool Kuvet
        {
            get
            {
                return kuvet;
            }
            set
            {
                kuvet = value;
            }

        }

        public CiftKisilikYatak1(int OdaNo) : base(OdaNo)//ciftyatak1 sınıfını temel alıyor
        {
            Kuvet = true;
        }

    }
}
