using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.FACADE
{
    public class NoWegPizza
    {
        public string GetNoWegPizza()
        {
            PizzeriaKitchen pizzeria = new PizzeriaKitchen();
            var result = $"{pizzeria.GetPizzaDough()} {Environment.NewLine}" +
                $"{pizzeria.Baking()} {Environment.NewLine}" +
                $"{pizzeria.GetNoWegAddmixture()} {Environment.NewLine}";

            return result;
        }
    }




}

