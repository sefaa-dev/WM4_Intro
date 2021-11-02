﻿using PaymentMethod.Models.Payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethod.Models.Payment.Abstracts
{
    public interface IPayable
    {
        void Pay(decimal amount);
        MessagaStates State { get; set; }

    }
}
