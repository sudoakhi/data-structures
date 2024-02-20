// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.MaxHeap
{
    internal static class HeapHelper
    {
        internal static void Insert(Heap heap , int element)
        {
            heap._elements.Add(element);
            HeapifyInsert(heap);
        }

        internal static void Delete(Heap heap)
        {
            if ( heap._elements.Count == 0 )
            {
                throw new InvalidOperationException();
            }

            heap._elements[0] = heap._elements[^1];
            heap._elements.RemoveAt(heap._elements.Count - 1);
            HeapifyDelete(heap);
        }

        private static void HeapifyInsert(Heap heap)
        {
            var currentIndex = heap._elements.Count-1;

            while(!IsRoot(currentIndex) && heap._elements[currentIndex] > GetParent(heap, currentIndex))
            {
                var parentIndex = GetParentIndex(currentIndex);
                (heap._elements[currentIndex], heap._elements[parentIndex]) = (heap._elements[parentIndex], heap._elements[currentIndex]);
                currentIndex = parentIndex;
            }
        }

        private static void HeapifyDelete(Heap heap)
        {
            var currentIndex = 0;
            while(HasLeftChild(heap, currentIndex))
            {
                var greaterIndex = GetLeftChildIndex(currentIndex);
                if(HasRightChild(heap, greaterIndex) && GetRightChild(heap, currentIndex) > GetLeftChild(heap, currentIndex))
                {
                    greaterIndex = GetRightChildIndex(currentIndex);
                }

                if(heap._elements[greaterIndex] <= heap._elements[currentIndex] )
                {
                    break;
                }

                (heap._elements[currentIndex], heap._elements[greaterIndex]) = (heap._elements[greaterIndex], heap._elements[currentIndex]);
                currentIndex = greaterIndex;
            }
        }

        internal static int GetCurrentMaximum(Heap heap)
        {
            return heap._elements.Count == 0 ? throw new InvalidOperationException() : heap._elements[0];
        }

        private static bool IsRoot(int elementIndex)
        {
            return elementIndex == 0;
        }

        private static int GetParentIndex(int elementIndex)
        {
            return (elementIndex - 1) / 2;
        }

        private static int GetLeftChildIndex(int elementIndex)
        {
            return (elementIndex * 2) + 1;
        }

        private static int GetRightChildIndex(int elementIndex)
        {
            return (elementIndex * 2) + 2;
        }

        private static bool HasLeftChild(Heap heap , int elementIndex)
        {
            return (elementIndex * 2) + 1 <= heap._elements.Count - 1;
        }

        private static bool HasRightChild(Heap heap , int elementIndex)
        {
            return (elementIndex * 2) + 2 <= heap._elements.Count - 1;
        }

        private static int GetLeftChild(Heap heap , int elementIndex)
        {
            return heap._elements[GetLeftChildIndex(elementIndex)];
        }

        private static int GetRightChild(Heap heap , int elementIndex)
        {
            return heap._elements[GetRightChildIndex(elementIndex)];
        }

        private static int GetParent(Heap heap , int elementIndex)
        {
            return heap._elements[GetParentIndex(elementIndex)];
        }
    }
}
