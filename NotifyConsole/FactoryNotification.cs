using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyConsole
{
    public class FactoryNotification
    {
        private readonly Dictionary<NotificationType, ISendNotification> strategy;
        public FactoryNotification()
        {
            strategy = new Dictionary<NotificationType, ISendNotification>
            {
                {
                    NotificationType.Email , 
                    new EmailNotification() 
                },
                {
                    NotificationType.Sms ,
                    new SmsNotification()
                },
                {
                    NotificationType.Push ,
                    new PushNotification()
                }
            };
        }
        public ISendNotification GetNotificationObject(NotificationType type)
        {
            return strategy[type];
        }
    }
}
