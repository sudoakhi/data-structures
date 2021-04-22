using System;

namespace suhyphen.DS.SingleLinkedList
{
    internal class SingleLinkedListHelper
    {
        internal void InsertFront(SingleLinkedList singleLinkedList, int newData)
        {
            Node newNode = new Node(newData)
            {
                Next = singleLinkedList.Head
            };
            singleLinkedList.Head = newNode;
        }

        internal void InsertLast(SingleLinkedList singleLinkedList, int newData)
        {
            Node newNode = new Node(newData);
            Node temp = singleLinkedList.Head;
            if (temp == null)
            {
                singleLinkedList.Head = newNode;
                return;
            }

            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
        }

        internal void DeleteNodeByKey(SingleLinkedList singleLinkedList, int key)
        {
            Node temp = singleLinkedList.Head;
            Node previousNode = null;

            if (temp != null && temp.Data == key)
            {
                singleLinkedList.Head = temp.Next;
                return;
            }

            while (temp != null && temp.Data != key)
            {
                previousNode = temp;
                temp = temp.Next;
            }

            previousNode.Next = temp.Next;
        }

        internal void Traverse(SingleLinkedList singleLinkedList)
        {
            Node temp = singleLinkedList.Head;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }

            Console.WriteLine();
        }
    }
}
