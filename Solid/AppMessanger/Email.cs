using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMessanger
{
    class Email : ISend
    {
        public string Send()
        {
            return "E-mail";
        }
    }
}
