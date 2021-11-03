using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsLib.Abstract
{
    public abstract class Silah
    {
        public string Ulke { get; protected set; }
        public decimal Fiyat { get; protected set; }
        public int Hasar { get; protected set; }
        public Stream SilahResim { get; protected set; }

        
    }
    public enum Silahlar : byte
    {
        Bıçak,
        USP,
        Glock,
        DesertEagle,
        AK47,
        M4A1S,
        AWP,
        ElBombası,
        FlashBombası
    }
}
