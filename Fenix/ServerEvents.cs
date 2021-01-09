using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Fenix
{
    class ServerEvents : Events
    {
        public override void Invoke(HttpListenerResponse config,HttpListenerRequest request)
        {
            string text = request.RawUrl != "/" ? request.RawUrl?.Replace("/","") : "HI";
            var x = Encoding.UTF8.GetBytes($"<H1>{text}</H1>");
            config.OutputStream.Write(x, 0, x.Length);
            config.OutputStream.Dispose();
        }
    }
}
