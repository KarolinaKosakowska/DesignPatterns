using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDetails
{
    class Payment : IPay
    {   
        public string Pay(decimal amount)
        {
            return $"Płatnośc  {amount}";
        }
       
       
        
    }
}
