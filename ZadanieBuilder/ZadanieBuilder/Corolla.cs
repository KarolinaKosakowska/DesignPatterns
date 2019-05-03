using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieBuilder
{
    public class Corolla : ICarBuildable
    {
        public string CarModel { get; set; } = "Corolla";      
        public List<string> CompletedParts { get => _completedParts; set => _completedParts = value; }
        private List<string> _completedParts = new List<string>();

        public string BuildChassis()
        {
            CompletedParts.Add("Podwozie");
            return "Podwozie";
        }
        public string BuildEngine()
        {
            CompletedParts.Add("Silnik");
            return "Silnik";
        }
        public string BuildBody()
        {
            CompletedParts.Add("Nadwozie");
            return "Nadwozie";
        }
    }
}
