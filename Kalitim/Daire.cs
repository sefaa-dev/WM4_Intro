using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Daire
    {
        public Daire()
        {

        }
        public Daire(double r)
        {
            this.R = r;
        }
        
        public double R { get; set; }

        public double AlanHesapla() {
            return Math.Pow(R, 2) * Math.PI;
        }
        public double CevreHesapla()
        {
            return 2 * Math.PI * R;
        }

        public double KosegenHesapla()
        {
            return 2 * R;
        }
    }
}
