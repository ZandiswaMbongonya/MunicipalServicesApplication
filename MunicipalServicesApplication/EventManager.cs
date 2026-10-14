using System;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalServicesApplication
{
    public class EventManager
    {
        // 1. Sorted Dictionary
        // Organises events according to their dates.
        public SortedDictionary<DateTime, List<MunicipalEvent>> EventsByDate
            = new SortedDictionary<DateTime, List<MunicipalEvent>>();

        // 2. HashSet
        // Stores unique event categories.
        public HashSet<string> Categories
            = new HashSet<string>();

        // 3. Queue
        // Stores upcoming events in first-in, first-out order.
        public Queue<MunicipalEvent> UpcomingEvents
            = new Queue<MunicipalEvent>();

        // 4. Dictionary
        // Tracks how many times users search for each category.
        public Dictionary<string, int> SearchHistory
            = new Dictionary<string, int>();

        // Stores recent category searches, with the newest search on top.
        public Stack<string> RecentSearches = new Stack<string>();

        // 5. Custom Priority Queue
        // Events are grouped according to their priority.
        private SortedDictionary<int, Queue<MunicipalEvent>> priorityQueue
            = new SortedDictionary<int, Queue<MunicipalEvent>>();

        // Tracks events that have already been processed.
        public HashSet<int> ProcessedEventIds
            = new HashSet<int>();

        public EventManager()
        {
            LoadSampleEvents();
        }

        // Adds an event to all appropriate data structures.
        public void AddEvent(MunicipalEvent municipalEvent)
        {
            // Sorted Dictionary
            if (!EventsByDate.ContainsKey(municipalEvent.Date.Date))
            {
                EventsByDate[municipalEvent.Date.Date] =
                    new List<MunicipalEvent>();
            }

            EventsByDate[municipalEvent.Date.Date].Add(municipalEvent);

            // HashSet
            Categories.Add(municipalEvent.Category);

            // Queue
            UpcomingEvents.Enqueue(municipalEvent);

            // Priority Queue
            if (!priorityQueue.ContainsKey(municipalEvent.Priority))
            {
                priorityQueue[municipalEvent.Priority] =
                    new Queue<MunicipalEvent>();
            }

            priorityQueue[municipalEvent.Priority].Enqueue(municipalEvent);
        }

        // Records a user's category search.
        private DateTime? lastSearchDate;

        public void RecordSearch(string category, DateTime? date)
        {
            if (string.IsNullOrWhiteSpace(category))
                return;

            if (SearchHistory.ContainsKey(category))
            {
                SearchHistory[category]++;
            }
            else
            {
                SearchHistory.Add(category, 1);
            }

            lastSearchDate = date;
        }

        // Searches events by category and date.
        public List<MunicipalEvent> SearchEvents(
            string category,
            DateTime? date)
        {
            List<MunicipalEvent> results =
                new List<MunicipalEvent>();

            IEnumerable<MunicipalEvent> allEvents =
                EventsByDate
                .SelectMany(pair => pair.Value);

            if (!string.IsNullOrWhiteSpace(category) &&
                category != "All Categories")
            {
                allEvents = allEvents.Where(
                    e => e.Category.Equals(
                        category,
                        StringComparison.OrdinalIgnoreCase));
            }

            if (date.HasValue)
            {
                allEvents = allEvents.Where(
                    e => e.Date.Date == date.Value.Date);
            }

            results = allEvents
                .OrderBy(e => e.Date)
                .ThenBy(e => e.Priority)
                .ToList();

            return results;
        }

        // Returns recommendations based on the user's search history.
        // Generates recommendations by analysing the user's
        // previous search preferences.
        public List<MunicipalEvent> GetRecommendations()
        {
            if (SearchHistory.Count == 0)
                return new List<MunicipalEvent>();

            DateTime today = DateTime.Today;

            // Determine the user's preferred categories based
            // on how frequently each category has been searched.
            var preferredCategories = SearchHistory
                .OrderByDescending(pair => pair.Value)
                .ThenBy(pair => pair.Key)
                .ToList();

            // Retrieve all upcoming events.
            List<MunicipalEvent> upcomingEvents = EventsByDate
     .Where(pair => pair.Key >= today)
     .SelectMany(pair => pair.Value)
     .Where(e => !ProcessedEventIds.Contains(e.EventId))
     .ToList();

            // Score each event according to the user's
            // search preferences.
            var recommendations = upcomingEvents
                .Select(e =>
                {
                    int searchFrequency =
                        SearchHistory.ContainsKey(e.Category)
                            ? SearchHistory[e.Category]
                            : 0;

                    return new
                    {
                        Event = e,

                        // Higher search frequency means stronger
                        // user preference.
                        Score = (searchFrequency * 100)
                                + (10 - e.Priority)
                    };
                })
                .Where(x => x.Score > 0)
                .OrderByDescending(x => x.Score)
                .ThenBy(x => x.Event.Date)
                .Select(x => x.Event)
                .Take(3)
                .ToList();

            return recommendations;
        }

        // Returns the next event according to priority.

        public MunicipalEvent DequeueHighestPriority()
        {
            // Process events in priority order.
            // Lower priority numbers are processed first.
            foreach (KeyValuePair<int, Queue<MunicipalEvent>> pair
                in priorityQueue)
            {
                while (pair.Value.Count > 0)
                {
                    MunicipalEvent nextEvent = pair.Value.Dequeue();

                    // Ignore events whose dates have already passed.
                    if (nextEvent.Date.Date < DateTime.Today)
                    {
                        continue;
                    }

                    // Prevent the same event from being processed twice.
                    if (ProcessedEventIds.Contains(nextEvent.EventId))
                    {
                        continue;
                    }

                    ProcessedEventIds.Add(nextEvent.EventId);

                    // Remove the event from the upcoming-events queue.
                    Queue<MunicipalEvent> remainingEvents =
                        new Queue<MunicipalEvent>();

                    while (UpcomingEvents.Count > 0)
                    {
                        MunicipalEvent currentEvent =
                            UpcomingEvents.Dequeue();

                        if (currentEvent.EventId != nextEvent.EventId)
                        {
                            remainingEvents.Enqueue(currentEvent);
                        }
                    }

                    UpcomingEvents = remainingEvents;

                    return nextEvent;
                }
            }

            return null;
        }


        // Adds realistic sample municipal events.
        private void LoadSampleEvents()
        {
            AddEvent(new MunicipalEvent(
                1001,
                "Community Clean-Up Day",
                "Community",
                new DateTime(2026, 9, 25),
                "Soweto Community Hall",
                "Community members are invited to participate in a neighbourhood clean-up.",
                2));

            AddEvent(new MunicipalEvent(
                1002,
                "Local Soccer Tournament",
                "Sports",
                new DateTime(2026, 9, 28),
                "Orlando Community Grounds",
                "A community soccer tournament for local teams.",
                3));

            AddEvent(new MunicipalEvent(
                1003,
                "Free Health Screening",
                "Health",
                new DateTime(2026, 9, 30),
                "Soweto Health Centre",
                "Residents can receive basic health screening services.",
                2));

            AddEvent(new MunicipalEvent(
                1004,
                "Municipal Public Meeting",
                "Government",
                new DateTime(2026, 10, 2),
                "Municipal Civic Centre",
                "Residents can attend a public municipal information meeting.",
                1));

            AddEvent(new MunicipalEvent(
                1005,
                "Youth Athletics Day",
                "Sports",
                new DateTime(2026, 10, 5),
                "Soweto Sports Centre",
                "A community athletics event for young people.",
                3));

            AddEvent(new MunicipalEvent(
                1006,
                "Digital Skills Workshop",
                "Education",
                new DateTime(2026, 10, 7),
                "Community Learning Centre",
                "A workshop introducing residents to basic digital skills.",
                4));

            AddEvent(new MunicipalEvent(
                1007,
                "Community Basketball Day",
                "Sports",
                new DateTime(2026, 10, 8),
                "Orlando Community Centre",
                "A community basketball event open to local residents.",
                3));

            AddEvent(new MunicipalEvent(
                1008,
                "Blood Donation Drive",
                "Health",
                new DateTime(2026, 10, 10),
                "Soweto Community Hall",
                "Residents can donate blood and support local healthcare services.",
                2));

            AddEvent(new MunicipalEvent(
                1009,
                "Youth Career Day",
                "Education",
                new DateTime(2026, 10, 12),
                "Community Learning Centre",
                "Career guidance and information for young residents.",
                4));

            AddEvent(new MunicipalEvent(
                1010,
                "Ward Community Meeting",
                "Community",
                new DateTime(2026, 10, 15),
                "Ward Community Hall",
                "Residents can discuss local community matters.",
                2));
        }
    }
}