using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoin.Utils
{
    public static class BinanceHelper
    {
        public static DateTime DataConverter(long tick)
        {
            var epoch = new DateTime(1978, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            return epoch.AddMilliseconds(tick).ToLocalTime();
        }
    }
}
