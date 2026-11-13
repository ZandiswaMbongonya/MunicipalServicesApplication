
using System;
using System.Collections.Generic;

namespace MunicipalServicesApplication
{
    public class ServiceRequestGraph
    {
        private Dictionary<string, List<Edge>> adjacencyList =
            new Dictionary<string, List<Edge>>(
                StringComparer.OrdinalIgnoreCase);

        public class Edge
        {
            public string Destination { get; set; }
            public int Weight { get; set; }

            public Edge(string destination, int weight)
            {
                Destination = destination;
                Weight = weight;
            }
        }

        public void AddLocation(string location)
        {
            if (!adjacencyList.ContainsKey(location))
            {
                adjacencyList[location] = new List<Edge>();
            }
        }

        public void AddConnection(
            string location1, string location2, int weight)
        {
            if (weight < 0)
                throw new ArgumentException("Weight cannot be negative.");

            AddLocation(location1);
            AddLocation(location2);

            adjacencyList[location1].Add(
                new Edge(location2, weight));

            adjacencyList[location2].Add(
                new Edge(location1, weight));
        }

        public List<string> BreadthFirstSearch(string start)
        {
            List<string> result = new List<string>();

            if (!adjacencyList.ContainsKey(start))
                return result;

            HashSet<string> visited =
                new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            Queue<string> queue = new Queue<string>();

            visited.Add(start);
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                string current = queue.Dequeue();
                result.Add(current);

                foreach (Edge edge in adjacencyList[current])
                {
                    if (visited.Add(edge.Destination))
                    {
                        queue.Enqueue(edge.Destination);
                    }
                }
            }

            return result;
        }

        public List<string> DepthFirstSearch(string start)
        {
            List<string> result = new List<string>();

            if (!adjacencyList.ContainsKey(start))
                return result;

            HashSet<string> visited =
                new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            DFSHelper(start, visited, result);

            return result;
        }

        private void DFSHelper(
            string current,
            HashSet<string> visited,
            List<string> result)
        {
            visited.Add(current);
            result.Add(current);

            foreach (Edge edge in adjacencyList[current])
            {
                if (!visited.Contains(edge.Destination))
                {
                    DFSHelper(edge.Destination, visited, result);
                }
            }
        }

        public List<Edge> MinimumSpanningTree(string start)
        {
            List<Edge> mst = new List<Edge>();

            if (!adjacencyList.ContainsKey(start))
                return mst;

            HashSet<string> visited =
                new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            List<string> locations = new List<string>();

            visited.Add(start);
            locations.Add(start);

            while (visited.Count < adjacencyList.Count)
            {
                string nextLocation = null;
                string fromLocation = null;
                int minimumWeight = int.MaxValue;

                foreach (string location in locations)
                {
                    foreach (Edge edge in adjacencyList[location])
                    {
                        if (!visited.Contains(edge.Destination) &&
                            edge.Weight < minimumWeight)
                        {
                            minimumWeight = edge.Weight;
                            nextLocation = edge.Destination;
                            fromLocation = location;
                        }
                    }
                }

                if (nextLocation == null)
                    break;

                visited.Add(nextLocation);
                locations.Add(nextLocation);

                mst.Add(new Edge(
                    fromLocation + " - " + nextLocation,
                    minimumWeight));
            }

            return mst;
        }
    }
}
