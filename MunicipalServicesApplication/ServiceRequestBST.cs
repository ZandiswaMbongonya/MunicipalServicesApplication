
using System;

namespace MunicipalServicesApplication
{
    public class ServiceRequestBST
    {
        private class Node
        {
            public Issue Data;
            public Node Left;
            public Node Right;

            public Node(Issue issue)
            {
                Data = issue;
            }
        }

        private Node root;

        public void Insert(Issue issue)
        {
            root = InsertNode(root, issue);
        }

        private Node InsertNode(Node current, Issue issue)
        {
            if (current == null)
            {
                return new Node(issue);
            }

            int comparison = string.Compare(
                issue.RequestID,
                current.Data.RequestID,
                StringComparison.OrdinalIgnoreCase);

            if (comparison < 0)
            {
                current.Left = InsertNode(current.Left, issue);
            }
            else if (comparison > 0)
            {
                current.Right = InsertNode(current.Right, issue);
            }

            return current;
        }

        public Issue Search(string requestID)
        {
            Node current = root;

            while (current != null)
            {
                int comparison = string.Compare(
                    requestID,
                    current.Data.RequestID,
                    StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                {
                    return current.Data;
                }

                current = comparison < 0
                    ? current.Left
                    : current.Right;
            }

            return null;
        }
    }
}
