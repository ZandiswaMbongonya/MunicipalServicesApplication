
using System;
using System.Collections.Generic;

namespace MunicipalServicesApplication
{
    public class ServiceRequestHeap
    {
        private readonly List<Issue> heap = new List<Issue>();


        private int GetPriority(Issue issue)
        {
            if (issue == null)
                return 0;

            if (string.Equals(issue.Priority, "High",
                StringComparison.OrdinalIgnoreCase))
                return 3;

            if (string.Equals(issue.Priority, "Medium",
                StringComparison.OrdinalIgnoreCase))
                return 2;

            return 1;
        }


        public void Insert(Issue issue)
        {
            heap.Add(issue);

            int current = heap.Count - 1;

            while (current > 0)
            {
                int parent = (current - 1) / 2;

                if (GetPriority(heap[current]) <=
                    GetPriority(heap[parent]))
                    break;

                Swap(current, parent);
                current = parent;
            }
        }

        public Issue ExtractHighestPriority()
        {
            if (heap.Count == 0)
                return null;

            Issue highest = heap[0];
            Issue last = heap[heap.Count - 1];

            heap.RemoveAt(heap.Count - 1);

            if (heap.Count > 0)
            {
                heap[0] = last;
                HeapifyDown(0);
            }

            return highest;
        }

        private void HeapifyDown(int index)
        {
            int largest = index;

            int left = (2 * index) + 1;
            int right = (2 * index) + 2;

            if (left < heap.Count &&
                GetPriority(heap[left]) >
                GetPriority(heap[largest]))
            {
                largest = left;
            }

            if (right < heap.Count &&
                GetPriority(heap[right]) >
                GetPriority(heap[largest]))
            {
                largest = right;
            }

            if (largest != index)
            {
                Swap(index, largest);
                HeapifyDown(largest);
            }
        }

        private void Swap(int first, int second)
        {
            Issue temporary = heap[first];
            heap[first] = heap[second];
            heap[second] = temporary;
        }

        public int Count
        {
            get { return heap.Count; }
        }
    }
}
