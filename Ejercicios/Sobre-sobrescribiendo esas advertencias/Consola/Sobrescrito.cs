using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Sobrescrito
    {
        public override string ToString()
        {
            return $"Este es mi metodo ToString sobrescrito!";
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
