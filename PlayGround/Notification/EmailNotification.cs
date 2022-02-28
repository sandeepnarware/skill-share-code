using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    public class EmailNotification : INotification
    {
        public void Send(string message, string recepent)
        {
            Console.WriteLine($"A Email is sent to {recepent}, with message {message}");
        }
    }
}
