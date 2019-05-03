using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            IPay pay = new Card();
            Console.WriteLine(pay.Pay(10));
            Console.Read();
        }
    }
}
