# C# Data Structures

This repository contains a collection of commonly used data structures implemented in C#. These data structures are essential for building efficient and scalable software applications.

## Table of Contents

1. [Introduction](#introduction)
2. [Data Structures Implemented](#data-structures-implemented)
3. [Usage](#usage)
4. [Contributing](#contributing)
5. [License](#license)

## Introduction

Data structures are fundamental building blocks used in software development to store and organize data efficiently. Understanding data structures and their implementations is crucial for writing optimized algorithms and creating high-performance applications.

This repository aims to provide clear and concise implementations of various data structures in C#. Each data structure is accompanied by explanations, usage examples, and performance analysis where applicable.

## Data Structures Implemented

The following data structures are currently implemented in this repository:

- **Linked List**: A linear data structure where elements are linked using pointers.
- **Stack**: A Last In First Out (LIFO) collection of elements.
- **Queue**: A First In First Out (FIFO) collection of elements.
- **Binary Tree**: A hierarchical data structure where each node has at most two children.
- **Binary Search Tree**: A binary tree in which the left child contains only nodes with values less than the parent node, and the right child contains only nodes with values greater than the parent node.
- **Hash Table**: A data structure that implements an associative array abstract data type, mapping keys to values.
- **Heap**: A specialized tree-based data structure that satisfies the heap property.
- **Graph**: A collection of nodes (vertices) and edges that connect pairs of nodes.

## Usage

Each data structure is implemented in its own C# class file within the `DataStructures` directory. To use a particular data structure, simply include the corresponding file in your C# project.

Below is an example of how to use the LinkedList class:

```csharp
using System;
using DataStructures;

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> list = new LinkedList<int>();

        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}

## Contributing

Contributions to this repository are welcome! If you would like to contribute to the project by adding new data structures, improving existing implementations, or fixing bugs, please feel free to submit a pull request. Make sure to follow the existing code style and include appropriate documentation and tests for your changes.

## License

This project is licensed under the MIT License.
