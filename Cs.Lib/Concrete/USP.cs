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
    public sealed class USP : Tabanca
    {
        public USP()
        {
            this.Fiyat = 200;
            this.Ulke = "Almanya";
            this._sarjorKapasitesi = 12;
            this._kalanFisek = this._sarjorKapasitesi;
            this.SilahResim = new MemoryStream(Properties.Resources.USP);
            this.Hasar = 35;
            this._atisSesi = Properties.Resources.USP_Ates;
            this._bitikFisekSesi = Properties.Resources.Bitik_Mermi_Sesi;
            this._yenidenDoldurmaSesi = Properties.Resources.USP_Reload;
        }

        public override int AtesEt()
        {         
            if (KalanFisek != 0)
            {
                Thread.Sleep(250);
                this._kalanFisek--;
            }
            else
            {          
                Thread.Sleep(100);
            }
            return this._kalanFisek;
        }

        public override int YenidenDoldur()
        {
        
            Thread.Sleep(1125);
            this._kalanFisek = this.SarjorKapasitesi;
            return KalanFisek;
        }
    }
}
