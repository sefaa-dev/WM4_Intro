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
    public sealed class Bicak : YakinSaldiri
    {
        public Bicak()
        {
            this.Fiyat = 50;
            this.Hasar = 45;
            this.SilahResim = new MemoryStream(Properties.Resources.Bicak);
            this.Ulke = "Türkiye";
            this._vurusKatsayisi = 350;
            
        }

      
           





        public override int Vur()
        {
          
            Thread.Sleep(VurusKatsayisi);
            return Hasar;
        }
    }
}
