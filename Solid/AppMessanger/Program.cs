using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMessanger
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageOK = new Messanger();
            var message = new List<ISend>();
            message.Add(new MMS());
            message.Add(new Sms());
            message.Add(new Email());
            Console.WriteLine(messageOK.SendMessages(message));
            Console.ReadKey();




        }
    }
}
