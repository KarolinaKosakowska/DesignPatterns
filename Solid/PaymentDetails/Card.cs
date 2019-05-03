using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDetails
{
    class Card: IPay
    {
        public string Pay(decimal amount)
        {
            return $"Płatnośc kartą - {amount}";
        }
    }
}
