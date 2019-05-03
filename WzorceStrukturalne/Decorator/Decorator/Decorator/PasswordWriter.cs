using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class PasswordWriter
    {
        public abstract string Save(string password);
    }
    public class MyPasswordWriter : PasswordWriter
    {
        public override string Save(string password)
        {
            return $"hasło: {password}";
        }
    }
}
