using System;

namespace Notification
{
    public interface INotification
    {
        void Send(string message, string recepent);
    }
}
