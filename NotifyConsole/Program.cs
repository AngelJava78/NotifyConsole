using System;
using System.Net.Http;
using System.Linq;
using System.Collections.Generic;

namespace NotifyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HttpClient client = new HttpClient();
            var factory = new FactoryNotification();
            //var response = client.PostAsync();  <---Get all active events
            var eventList = new List<EventDto>
            {
                new EventDto
                {
                    Id = 1,
                    Title = "Hello",
                    Message ="Welcome",
                    CustomerId = 1,
                    InsertedDate = DateTime.Now,
                    StatusId = SentStatus.New,
                    SentDate =DateTime.Now,
                    NotificationType = NotificationType.Email,
                    TemplateId = 10
                },
            };
            var customerList = new List<CustomerDto>
            {
                new CustomerDto
                {
                    Id = 1,
                    Name = "Angel",
                    LastName="Javier",
                    Email="angel.javier@edenred.com",
                    PhoneNumber="5552178532"
                },
                                new CustomerDto
                {
                    Id = 2,
                    Name = "Zulidany",
                    LastName="Hernandez",
                    Email="angel_java@hotmail.com",
                    PhoneNumber="5552178532"
                },
            };
            foreach(var item in eventList)
            {
                var customer = customerList.FirstOrDefault(c => c.Id == item.CustomerId);
                var notification = factory.GetNotificationObject(item.NotificationType);
                notification.Send(item, customer);
                    
            }
            





        }
    }
}
