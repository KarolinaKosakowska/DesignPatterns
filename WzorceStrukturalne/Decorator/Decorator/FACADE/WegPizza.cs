using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.FACADE
{
    class WegPizza
    {
        
        public string GetWegPizza()
        {
           PizzeriaKitchen pizzeria = new PizzeriaKitchen();
            var result = $"{pizzeria.GetPizzaDough()} {Environment.NewLine}" +
                $"{pizzeria.Baking()} {Environment.NewLine}" +
                $"{pizzeria.GetWegAddmixture()} {Environment.NewLine}";

            return result;
        }
    }
}
