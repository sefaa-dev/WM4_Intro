using CsLib.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsLib.Concrete
{
    public sealed class Glock : Tabanca
    {
        public Glock()
        {
            this._sarjorKapasitesi = 20;
            this.Ulke = "Avusturya";
            this.Hasar = 24;
            this.Fiyat = 200m;
            this._kalanFisek = this._sarjorKapasitesi;
        }

        public override int AtesEt()
        {
            throw new NotImplementedException();
        }

        public override int YenidenDoldur()
        {
            throw new NotImplementedException();
        }
    }
}
