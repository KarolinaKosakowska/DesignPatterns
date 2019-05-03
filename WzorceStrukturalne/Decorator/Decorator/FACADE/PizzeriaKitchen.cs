using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.FACADE
{
    public class PizzeriaKitchen
    {
        public string GetPizzaDough()
        {
            PizzaDough pd = new PizzaDough();
            var result = $"{pd.AddWater()} {Environment.NewLine}" +
                $"{pd.AddFlour()} {Environment.NewLine}" +
                $"{pd.AddYeast()} {Environment.NewLine}";
      
            return result;
        }
        public string GetWegAddmixture()
        {
            Admixture ad = new Admixture();
            var result = $"{ad.AddOlive()} {Environment.NewLine}" +
                $"{ad.AddKetchup()} {Environment.NewLine}";
              
            return result;
        }
        public string Baking()
        {
           Bake ba = new Bake();
            var result = $"{ba.Baking()} {Environment.NewLine}";

            return result;
        }
        public string GetNoWegAddmixture()
        {
            Admixture ad = new Admixture();
            var result = $"{ad.AddSalami()} {Environment.NewLine}" +
                $"{ad.AddHam()} {Environment.NewLine}";

            return result;
        }
    }
}
