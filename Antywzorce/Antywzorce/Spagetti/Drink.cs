using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antywzorce.Spagetti
{
    public class Drink
    {
        IDrink drink;   
        public Drink(IDrink drink)
        {
            this.drink = drink;
        }
        
        public void CreateDrink()
        {
            drink.SelectSize();

        }
    }       
}
