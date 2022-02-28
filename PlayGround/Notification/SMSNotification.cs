using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    public class SMSNotification : INotification
    {
        public void Send(string message, string recepent)
        {
            Console.WriteLine($"A SMS is sent to {recepent}, with message {message}");
        }
    }
}
