using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsLib.Abstract
{
    public abstract class Tufek : Silah, ISarjorlu, IAtesEdebilen, ISeriAtabilir
    {
        protected int _sarjorKapasitesi, _kalanFisek, _atisKatsayisi;

        public int AtisKatsayisi => _atisKatsayisi;
        public int SarjorKapasitesi => _sarjorKapasitesi; //redonly prop
        public int KalanFisek => _kalanFisek;

        public abstract int AtesEt();

        public abstract int YenidenDoldur();




    }
}
