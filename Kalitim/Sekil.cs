using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public abstract class Sekil
    {
        public virtual double X { get; set; }
        public abstract double AlanHesapla();
        public virtual double CevreHesapla() {
            return 4 * X;
        }
        public virtual double KosegenHesapla()
        {
            return Math.Sqrt(2) * X;
        }
    }
}
