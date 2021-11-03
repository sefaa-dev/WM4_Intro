using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsLib.Abstract
{
    public interface ISarjorlu
    {
        int SarjorKapasitesi { get; }
        int KalanFisek { get; }
        int YenidenDoldur();
    }
}
