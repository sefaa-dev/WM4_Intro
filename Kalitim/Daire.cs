﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Daire : Sekil
    {
        //public Daire()
        //{

        //}
        public Daire(double x) :base(x)
        {
          
        }

        public override double AlanHesapla()
        {
            return Math.Pow(X, 2) * Math.PI;
        }

        public override double CevreHesapla()
        {
            return 2 * Math.PI * X;
        }

        public override double KosegenHesapla()
        {
            return 2 * X;
        }

    }
}
