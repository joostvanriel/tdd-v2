using System;
using System.Collections.Generic;

namespace StubsMocks
{
    public class Notifier
    {
        private readonly IList<IResponseHandler> responseHandlers = new List<IResponseHandler>();

        public void Add(IResponseHandler handler)
        {
            responseHandlers.Add(handler);
        }

        public void Publish(string message)
        {
            foreach (var handler in responseHandlers)
            {
                Console.WriteLine($"Notifying {handler.Name} with message: {message}");
                handler.Receive(message);
            }
        }
    }
}
