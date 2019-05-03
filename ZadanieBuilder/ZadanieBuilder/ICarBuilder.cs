using System.Collections.Generic;

namespace ZadanieBuilder
{
    public interface ICarBuildable
    {
        string BuildBody();
        string BuildChassis();
        string BuildEngine();
        string CarModel { get; set; }
        List<string> CompletedParts { get; set; }
        

    }
}