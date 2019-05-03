using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class SmartDoor : IAutomaticOptions
    {
        public string AutomaticClosing()
        {
            return "Zamykam zdalnie";
        }

        public string AutomaticOpening()
        {
            return "Otwieram zdalnie";
        }

        public string Close()
        {
            return "Zamykam ręcznie";
        }

        public int Glasses()
        {
            return 0;
        }

        public string Open()
        {
            return "Otwieram ręcznie";
        }
    }
}
