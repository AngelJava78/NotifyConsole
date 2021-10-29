using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyConsole
{
	public class EventDto
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public NotificationType NotificationType { get; set; }
		public string Message { get; set; }
		public DateTime InsertedDate { get; set; }
		public DateTime SentDate { get; set; }
		public SentStatus StatusId { get; set; }
		public int CustomerId { get; set; }
		public int TemplateId {get;set;}
  

	}
}
