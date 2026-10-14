using System;

namespace MunicipalServicesApplication
{
    public class MunicipalEvent
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }

        public MunicipalEvent(
            int eventId,
            string name,
            string category,
            DateTime date,
            string location,
            string description,
            int priority)
        {
            EventId = eventId;
            Name = name;
            Category = category;
            Date = date;
            Location = location;
            Description = description;
            Priority = priority;
        }
    }
}