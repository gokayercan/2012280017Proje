using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    class CiftYatak1:TekYatak2
    {
        private bool miniBar;

        public bool MiniBar
        {
            get
            {
                return miniBar;
            }
            set
            {
                miniBar = value;
            }

        }
        public CiftYatak1(int OdaNo) : base(OdaNo)
        {
            MiniBar = true;
        }
    }
}
