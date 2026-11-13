
using System;
using System.Collections.Generic;

namespace MunicipalServicesApplication
{
    public static class ServiceRequestRepository
    {
        private static readonly List<Issue> requests = new List<Issue>();

        private static int nextRequestNumber = 1;
        private static readonly ServiceRequestBST requestTree =

    new ServiceRequestBST();

        private static readonly ServiceRequestAVL avlTree =
    new ServiceRequestAVL();

        private static readonly ServiceRequestHeap requestHeap =
    new ServiceRequestHeap();

        private static readonly ServiceRequestRedBlackTree redBlackTree =
    new ServiceRequestRedBlackTree();

        private static readonly ServiceRequestGraph requestGraph =
    new ServiceRequestGraph();



        public static string AddRequest(Issue issue)
        {
            string requestID = "SR" + nextRequestNumber.ToString("D3");

            nextRequestNumber++;

            issue.RequestID = requestID;
            issue.Status = "Submitted";

            requests.Add(issue);
            requestTree.Insert(issue);
            avlTree.Insert(issue);
            redBlackTree.Insert(issue);
            requestHeap.Insert(issue);
            requestGraph.AddLocation(issue.Location);


            return requestID;
        }
        public static Issue GetRequestByID(string requestID)
        {
            return requestTree.Search(requestID);
        }
        

        public static List<Issue> GetAllRequests()
        {
            return new List<Issue>(requests);
        }

        public static Issue GetHighestPriorityRequest()
        {
            return requestHeap.ExtractHighestPriority();
        }

        public static void ConnectLocations(
    string location1, string location2, int weight)
        {
            requestGraph.AddConnection(location1, location2, weight);
        }

        public static List<string> GetLocationsBFS(string start)
        {
            return requestGraph.BreadthFirstSearch(start);
        }

        public static List<string> GetLocationsDFS(string start)
        {
            return requestGraph.DepthFirstSearch(start);
        }

        public static List<ServiceRequestGraph.Edge> GetMinimumSpanningTree(
            string start)
        {
            return requestGraph.MinimumSpanningTree(start);
        }
    }
}
