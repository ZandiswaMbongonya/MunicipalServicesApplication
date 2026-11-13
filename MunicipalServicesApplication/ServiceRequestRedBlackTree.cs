
using System;

namespace MunicipalServicesApplication
{
    public class ServiceRequestRedBlackTree
    {
        private enum NodeColor
        {
            Red,
            Black
        }

        private class Node
        {
            public Issue Data;
            public Node Left;
            public Node Right;
            public Node Parent;
            public NodeColor Color;

            public Node(Issue issue)
            {
                Data = issue;
                Color = NodeColor.Red;
            }
        }

        private Node root;

        public void Insert(Issue issue)
        {
            Node newNode = new Node(issue);
            Node parent = null;
            Node current = root;

            while (current != null)
            {
                parent = current;

                int comparison = string.Compare(
                    issue.RequestID,
                    current.Data.RequestID,
                    StringComparison.OrdinalIgnoreCase);

                if (comparison < 0)
                    current = current.Left;
                else if (comparison > 0)
                    current = current.Right;
                else
                    return;
            }

            newNode.Parent = parent;

            if (parent == null)
                root = newNode;
            else if (string.Compare(
                issue.RequestID,
                parent.Data.RequestID,
                StringComparison.OrdinalIgnoreCase) < 0)
                parent.Left = newNode;
            else
                parent.Right = newNode;

            FixInsert(newNode);
        }

        private void FixInsert(Node node)
        {
            while (node != root &&
                   node.Parent.Color == NodeColor.Red)
            {
                Node parent = node.Parent;
                Node grandparent = parent.Parent;

                if (parent == grandparent.Left)
                {
                    Node uncle = grandparent.Right;

                    if (uncle != null &&
                        uncle.Color == NodeColor.Red)
                    {
                        parent.Color = NodeColor.Black;
                        uncle.Color = NodeColor.Black;
                        grandparent.Color = NodeColor.Red;
                        node = grandparent;
                    }
                    else
                    {
                        if (node == parent.Right)
                        {
                            node = parent;
                            RotateLeft(node);
                            parent = node.Parent;
                            grandparent = parent.Parent;
                        }

                        parent.Color = NodeColor.Black;
                        grandparent.Color = NodeColor.Red;
                        RotateRight(grandparent);
                    }
                }
                else
                {
                    Node uncle = grandparent.Left;

                    if (uncle != null &&
                        uncle.Color == NodeColor.Red)
                    {
                        parent.Color = NodeColor.Black;
                        uncle.Color = NodeColor.Black;
                        grandparent.Color = NodeColor.Red;
                        node = grandparent;
                    }
                    else
                    {
                        if (node == parent.Left)
                        {
                            node = parent;
                            RotateRight(node);
                            parent = node.Parent;
                            grandparent = parent.Parent;
                        }

                        parent.Color = NodeColor.Black;
                        grandparent.Color = NodeColor.Red;
                        RotateLeft(grandparent);
                    }
                }
            }

            root.Color = NodeColor.Black;
        }

        private void RotateLeft(Node node)
        {
            Node rightChild = node.Right;

            node.Right = rightChild.Left;

            if (rightChild.Left != null)
                rightChild.Left.Parent = node;

            rightChild.Parent = node.Parent;

            if (node.Parent == null)
                root = rightChild;
            else if (node == node.Parent.Left)
                node.Parent.Left = rightChild;
            else
                node.Parent.Right = rightChild;

            rightChild.Left = node;
            node.Parent = rightChild;
        }

        private void RotateRight(Node node)
        {
            Node leftChild = node.Left;

            node.Left = leftChild.Right;

            if (leftChild.Right != null)
                leftChild.Right.Parent = node;

            leftChild.Parent = node.Parent;

            if (node.Parent == null)
                root = leftChild;
            else if (node == node.Parent.Right)
                node.Parent.Right = leftChild;
            else
                node.Parent.Left = leftChild;

            leftChild.Right = node;
            node.Parent = leftChild;
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
