using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterNew
{
    class EnCulture: SetCulture
    {
        public override void Set(CultureInfo context)
        {
            Resources.Culture = context;
        }
    }
}
