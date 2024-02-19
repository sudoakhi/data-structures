// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.MinHeap
{
    internal static class Runner
    {
        public static void Run()
        {
            var heap = new Heap();
            HeapHelper.Insert(heap , 1);
            HeapHelper.Insert(heap , 3);
            HeapHelper.Insert(heap , 6);
            HeapHelper.Insert(heap , 5);
            HeapHelper.Insert(heap , 9);
            HeapHelper.Insert(heap , 8);

            //This should output 1, 3, 6, 5, 9, 8
            foreach(var element in heap._elements)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            //This should return 1
            Console.WriteLine("Current Minimum: " + HeapHelper.GetCurrentMinimum(heap));

            HeapHelper.Delete(heap);
            //This should output 3, 5, 6, 8, 9
            foreach ( var element in heap._elements )
            {
                Console.Write(element + " ");
            }
            Console.WriteLine( );

            //This should return 3
            Console.WriteLine("Current Minimum: " + HeapHelper.GetCurrentMinimum(heap));

            HeapHelper.Delete(heap);
            //This should output 5, 8, 6, 9
            foreach ( var element in heap._elements )
            {
                Console.Write(element + " ");
            }
            Console.WriteLine( );

            //This should return 5
            Console.WriteLine("Current Minimum: " + HeapHelper.GetCurrentMinimum(heap));

            HeapHelper.Delete(heap);
            //This should output 6, 8, 9
            foreach ( var element in heap._elements )
            {
                Console.Write(element + " ");
            }
            Console.WriteLine( );

            //This should return 6
            Console.WriteLine("Current Minimum: " + HeapHelper.GetCurrentMinimum(heap));

            HeapHelper.Delete(heap);
            //This should output 8, 9
            foreach ( var element in heap._elements )
            {
                Console.Write(element + " ");
            }
            Console.WriteLine( );

            //This should return 8
            Console.WriteLine("Current Minimum: " + HeapHelper.GetCurrentMinimum(heap));

            HeapHelper.Delete(heap);
            //This should output 9
            foreach ( var element in heap._elements )
            {
                Console.Write(element + " ");
            }
            Console.WriteLine( );

            //This should return 9
            Console.WriteLine("Current Minimum: " + HeapHelper.GetCurrentMinimum(heap));
        }
    }
}
