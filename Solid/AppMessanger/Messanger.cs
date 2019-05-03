using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMessanger
{
    class Messanger
    {
        public string SendMessages(List<ISend>messageType)
        {
            string result = $"Wysyłam wiadomosc za pomoca: ";
            messageType.ForEach (a => result += $"{a.Send()}; ") ;
            return result;
        }
    }
}
