using Cs.Lib.Abstracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cs.Lib.Concrete
{
    public sealed class M4A1S : Tufek
    {
        public M4A1S()
        {
            this._atisKatsayisi = 200;
            this._sarjorKapasitesi = 20;
            this._kalanFisek = this._sarjorKapasitesi;
            this.Fiyat = 3100;
            this.Hasar = 43;
            this.SilahResim = new MemoryStream(Properties.Resources.M4A1S);
            this.Ulke = "Amerika";
            this._atisSesi = Properties.Resources.M4A1_Ates;
            this._bitikFisekSesi = Properties.Resources.Bitik_Mermi_Sesi;
            this._yenidenDoldurmaSesi = Properties.Resources.M4A1_Reload;
        }

        public override int AtesEt()
        {
            if (KalanFisek != 0)
            {
                this._kalanFisek--;
            }
            return this._kalanFisek;
        }

        public override int YenidenDoldur()
        {
            this._kalanFisek = this.SarjorKapasitesi;
            Thread.Sleep(1200);
            return KalanFisek;
        }
    }
}
