using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace Fenix
{
   abstract class Creator
    {
        public abstract void Start(out HttpListener listener);
    }
}
