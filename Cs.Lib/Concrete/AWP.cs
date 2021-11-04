<<<<<<< HEAD
﻿using Cs.Lib.Abstracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cs.Lib.Concrete
{
    public sealed class AWP : Tufek
    {
        public AWP()
        {
            this._atisKatsayisi = 1500;
            this._sarjorKapasitesi = 10;
            this._kalanFisek = this._sarjorKapasitesi;
            this.Fiyat = 4750;
            this.Hasar = 120;
            this.SilahResim = new MemoryStream(Properties.Resources.AWP);
            this.Ulke = "İngiltere";
            this._atisSesi = Properties.Resources.AWP_Ates;
            this._bitikFisekSesi = Properties.Resources.Bitik_Mermi_Sesi;
            this._yenidenDoldurmaSesi = Properties.Resources.Ak47_Reload;
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
=======
﻿using Cs.Lib.Abstracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cs.Lib.Concrete
{
    public sealed class AWP : Tufek
    {
        public AWP()
        {
            this._atisKatsayisi = 1500;
            this._sarjorKapasitesi = 10;
            this._kalanFisek = this._sarjorKapasitesi;
            this.Fiyat = 4750;
            this.Hasar = 120;
            this.SilahResim = new MemoryStream(Properties.Resources.AWP);
            this.Ulke = "İngiltere";
            this._atisSesi = Properties.Resources.AWP_Ates;
            this._bitikFisekSesi = Properties.Resources.Bitik_Mermi_Sesi;
            this._yenidenDoldurmaSesi = Properties.Resources.Ak47_Reload;
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
>>>>>>> 819e6ebd19a74c2f222f20cba457480896a3705b
