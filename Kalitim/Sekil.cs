using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Sekil
    {
        public double X { get; set; }
        public double AlanHesapla() {
            return X * X;
        }
        public double CevreHesapla() {
            return 4 * X;
        }
        public double KosegenHesapla()
        {
            return Math.Sqrt(2) * X;
        }
    }
}
