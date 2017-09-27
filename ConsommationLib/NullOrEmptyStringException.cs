using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumptionLib
{
    public class NullOrEmptyStringException : Exception
    {
        public NullOrEmptyStringException() : base()
        {

        }

        public NullOrEmptyStringException(String m) : base (m)
        {

        }
    }
}
