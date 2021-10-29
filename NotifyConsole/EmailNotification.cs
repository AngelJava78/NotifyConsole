using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NotifyConsole
{
    public class EmailNotification : ISendNotification
    {
        private readonly ILog log;
        public EmailNotification()
        {
            log = new ConsoleLog();
        }

        public void Send(EventDto eventDto, CustomerDto customer)
        {

            Console.WriteLine($"Event: {eventDto.Id}");
            Console.WriteLine($"Title: {eventDto.Title}");
            Console.WriteLine($"Message: {eventDto.Message}");
            Console.WriteLine($"Email: {customer.Email}");
            Console.WriteLine($"TemplateId: {eventDto.TemplateId}");

            log.Log("Sent message");
        }
    }
}
