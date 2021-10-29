using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyConsole
{
    public interface ISendNotification
    {
        void Send(EventDto eventDto, CustomerDto customer);
    }
}
