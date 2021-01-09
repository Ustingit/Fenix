using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Collections;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Fenix
{
    class Server
    {
        public void Stop()
        {
            if (http.IsListening) http.Stop();
        }
        public void Start()
        {
            http.Start();
            while (true)
            {
                var context = http.GetContext();
                if (!http.IsListening) break;
                foreach (var item in context.Request.Headers.AllKeys)
                {
                  Console.WriteLine(item+":"+ context.Request.Headers.Get(item));
                    
                }
                Task.Run(()=>events.Invoke(context.Response,context.Request));
            }
        }
        HttpListener http;
        Events events;
        public Server(Configurator config,Creator creator, Events events)
        {
            creator.Start(out http);
            config.Start(ref http);
            this.events = events;
        }
    }
}
