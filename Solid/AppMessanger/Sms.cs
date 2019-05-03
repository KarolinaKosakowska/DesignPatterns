using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMessanger
{
    class Sms:ISend
    {
        public string Send()
        {
            return "SMS";
        }
    }
}
