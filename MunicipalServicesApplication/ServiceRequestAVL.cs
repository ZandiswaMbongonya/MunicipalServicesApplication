
using System;

namespace MunicipalServicesApplication
{
    public class ServiceRequestAVL
    {
        private class Node
        {
            public Issue Data;
            public Node Left;
            public Node Right;
            public int Height;

            public Node(Issue issue)
            {
                Data = issue;
                Height = 1;
            }
        }

        private Node root;

        private int GetHeight(Node node)
        {
            return node == null ? 0 : node.Height;
        }

        private int GetBalance(Node node)
        {
            return node == null
                ? 0
                : GetHeight(node.Left) - GetHeight(node.Right);
        }

        private void UpdateHeight(Node node)
        {
            node.Height = 1 + Math.Max(
                GetHeight(node.Left),
                GetHeight(node.Right));
        }

        private Node RotateRight(Node y)
        {
            Node x = y.Left;
            Node temporary = x.Right;

            x.Right = y;
            y.Left = temporary;

            UpdateHeight(y);
            UpdateHeight(x);

            return x;
        }

        private Node RotateLeft(Node x)
        {
            Node y = x.Right;
            Node temporary = y.Left;

            y.Left = x;
            x.Right = temporary;

            UpdateHeight(x);
            UpdateHeight(y);

            return y;
        }

        public void Insert(Issue issue)
        {
            root = InsertNode(root, issue);
        }

        private Node InsertNode(Node node, Issue issue)
        {
            if (node == null)
                return new Node(issue);

            int comparison = string.Compare(
                issue.RequestID,
                node.Data.RequestID,
                StringComparison.OrdinalIgnoreCase);

            if (comparison < 0)
                node.Left = InsertNode(node.Left, issue);
            else if (comparison > 0)
                node.Right = InsertNode(node.Right, issue);
            else
                return node;

            UpdateHeight(node);

            int balance = GetBalance(node);

            // Left-Left case
            if (balance > 1 &&
                string.Compare(issue.RequestID, node.Left.Data.RequestID,
                    StringComparison.OrdinalIgnoreCase) < 0)
                return RotateRight(node);

            // Right-Right case
            if (balance < -1 &&
                string.Compare(issue.RequestID, node.Right.Data.RequestID,
                    StringComparison.OrdinalIgnoreCase) > 0)
                return RotateLeft(node);

            // Left-Right case
            if (balance > 1 &&
                string.Compare(issue.RequestID, node.Left.Data.RequestID,
                    StringComparison.OrdinalIgnoreCase) > 0)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            // Right-Left case
            if (balance < -1 &&
                string.Compare(issue.RequestID, node.Right.Data.RequestID,
                    StringComparison.OrdinalIgnoreCase) < 0)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
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
                    return current.Data;

                current = comparison < 0
                    ? current.Left
                    : current.Right;
            }

            return null;
        }
    }
}
