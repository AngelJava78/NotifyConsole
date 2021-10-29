using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyConsole
{
    public class PushNotification : ISendNotification
    {
        private readonly ILog log;
        public PushNotification()
        {
            log = new ConsoleLog();
        }
        public void Send(EventDto eventDto, CustomerDto customer)
        {
            throw new NotImplementedException();
            log.Log("Sent message");
        }
    }
}
