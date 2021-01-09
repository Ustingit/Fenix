using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Fenix
{
    class ServerCreator : Creator
    {
        public override void Start(out HttpListener listener)
        {
            listener = new HttpListener();
        }
    }
}
