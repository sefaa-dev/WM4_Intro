using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoin.Services
{   
        public interface IBinanceReq<T> where T : class
        {
            string BaseUrl { get; set; }
            T Result(string param);
        }
    }

