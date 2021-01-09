using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

namespace Fenix
{
    abstract class Events
    {
        public abstract void Invoke(HttpListenerResponse config,HttpListenerRequest request);
    }
}
