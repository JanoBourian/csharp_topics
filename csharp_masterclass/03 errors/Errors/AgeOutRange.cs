using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors
{
    class AgeOutRange : ApplicationException
    {
        public AgeOutRange() : base("You inserted a invalid value (out of range)")
        {

        }

        public AgeOutRange(string message): base(message)
        {

        }

        public AgeOutRange(string message, Exception es): base(message, es)
        {

        }
    }
}
