using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethod.Models.Payment.Models
{
    public enum MessagaStates : short  //public enum = numaralandırılmış liste
    {
        success = 999,
        fail = 111,
        pending = 666,

    }
}
