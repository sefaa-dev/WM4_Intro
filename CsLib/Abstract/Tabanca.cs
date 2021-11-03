using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsLib.Abstract
{
    public abstract class Tabanca : Silah, IAtesEdebilen, ISarjorlu
    {


        protected int _sarjorKapasitesi, _kalanFisek;
        public int SarjorKapasitesi => _sarjorKapasitesi;
        public int KalanFisek => _kalanFisek;


        public abstract void AtesEt();

        public abstract int YenidenDoldur();
        
    }
}
