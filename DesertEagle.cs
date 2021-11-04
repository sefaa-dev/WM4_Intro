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
    public sealed class DesertEagle : Tabanca
    {
        public DesertEagle()
        {
            this.Fiyat = 700;
            this._sarjorKapasitesi = 7;
            this.Hasar = 80;
            this.Ulke = "İsrail";
            this.SilahResim = new MemoryStream(Properties.Resources.Deagle);
            this._kalanFisek = this._sarjorKapasitesi;
            this._atisSesi = Properties.Resources.Deagle_Ates;
            this._bitikFisekSesi = Properties.Resources.Bitik_Mermi_Sesi;
            this._yenidenDoldurmaSesi = Properties.Resources.Deagle_Reload;
        }
        public override int AtesEt()
        {         
            if (KalanFisek != 0)
            {          
                Thread.Sleep(600);
                this._kalanFisek--;
            }
            else
            {              
                Thread.Sleep(250);
            }
            return this._kalanFisek;
        }

        public override int YenidenDoldur()
        {
            
            Thread.Sleep(1250);
            this._kalanFisek = this.SarjorKapasitesi;
            return KalanFisek;
        }
    }
}
