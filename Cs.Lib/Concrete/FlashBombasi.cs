using Cs.Lib.Abstracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Concrete
{
    public sealed class FlashBombasi : Firlatilan
    {
        public FlashBombasi()
        {
            this.Fiyat = 200;
            this.Hasar = 0;
            this.SilahResim = new MemoryStream(Properties.Resources.Flash);
            this.Ulke = "Almanya";
        }



        public override int Firlat()
        {
            throw new NotImplementedException();
        }
    }
}
