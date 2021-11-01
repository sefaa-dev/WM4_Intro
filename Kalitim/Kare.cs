using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim   
{

    public class Kare : Sekil 
    {    
            public Kare(double x)
            {
                this.X = x;
            }

            public Kare()
            {

            }

        public override double AlanHesapla()
        {
            return X * X;
        }
    }

    }

