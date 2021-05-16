using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioRiachuello.Models
{
    public class CustomMessageException : Exception
    {
        public CustomMessageException(string msg):base(msg)
        {

        }
    }
}
