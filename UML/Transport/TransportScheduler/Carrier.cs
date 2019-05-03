using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.TransportScheduler
{
    public class Carrier
    {
        public DateTime ShipmentDate { get; set; }
        public List<string> Messages = new List<string>();
        public string NextStep()
        {
            if (ShipmentDate <= DateTime.Today)
            {
                return "Transport anulowany";
            }
            else
            {
                Messages.Add("Samochod z towarem wyjechał");
            }
            Messages.Add("Koniec procesu");
            return string.Join(" ", Messages);
        
            
                
        }
    }
}
