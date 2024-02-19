using System;

namespace DataStructures.SingleLinkedList
{
    internal static class SingleLinkedListHelper
    {
        internal static void InsertFront(SingleLinkedList singleLinkedList, int newData)
        {
            var newNode = new SingleLinkedListNode(newData)
            {
                _next = singleLinkedList._head
            };
            singleLinkedList._head = newNode;
        }

        internal static void InsertLast(SingleLinkedList singleLinkedList, int newData)
        {
            var newNode = new SingleLinkedListNode(newData);
            var temp = singleLinkedList._head;
            if (temp == null)
            {
                singleLinkedList._head = newNode;
                return;
            }

            while (temp._next != null)
            {
                temp = temp._next;
            }

            temp._next = newNode;
        }

        internal static void DeleteNodeByKey(SingleLinkedList singleLinkedList, int key)
        {
            var temp = singleLinkedList._head;
            SingleLinkedListNode previousNode = null;

            if (temp != null && temp._data == key)
            {
                singleLinkedList._head = temp._next;
                return;
            }

            while (temp != null && temp._data != key)
            {
                previousNode = temp;
                temp = temp._next;
            }

            previousNode._next = temp._next;
        }

        internal static void Traverse(SingleLinkedList singleLinkedList)
        {
            var temp = singleLinkedList._head;
            while (temp != null)
            {
                Console.Write(temp._data + " ");
                temp = temp._next;
            }

            Console.WriteLine();
        }
    }
}
