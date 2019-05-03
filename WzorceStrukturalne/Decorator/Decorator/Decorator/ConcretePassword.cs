using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcretePassword : PasswordDecorator
    {
        public ConcretePassword(PasswordWriter toDecorate) : base(toDecorate)
        {
        }
        public override string Save(string password)
        {
            return $"konkretne {base.Save(password)}";
        }
    }
}
