using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Fenix
{
    class ServerConfigurator : Configurator
    {
        public override void Start(ref HttpListener listener)
        {
            listener.Prefixes.Add("http://*/");
        }
    }
}
