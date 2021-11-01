using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Dikdortgen : Sekil
    {
        public Dikdortgen(double x, double y)
        {
            this.X = x;
            this.Y = y;

        }
        public Dikdortgen()
        {

        }

        public double Y { get; set; }

        public override double AlanHesapla()
        {
            return X * Y;
        }

        public override double CevreHesapla()
        {
            return 2 * (X + Y);
        }

        public override double KosegenHesapla()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }



    }
    }

