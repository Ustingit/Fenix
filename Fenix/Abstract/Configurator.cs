using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace Fenix
{
    abstract class Configurator
    {
        public abstract void Start(ref HttpListener listener);
    }
}
