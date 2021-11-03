using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsLib.Abstract
{
    public interface IVurulabilir
    {
        int VurusKatsayisi { get; }
        int Vur();
    }
}
