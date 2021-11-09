﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm_Form.Models
{
    public class Kisi
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Falan { get; set; }

        public override string ToString() => $"{Ad} {SoyAd}";
       
    }
}
