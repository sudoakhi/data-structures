using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.DS.SuffixTrie
{
    internal class SuffixTrieHelper
    {
        public static void Insert(SuffixTrie trie, string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                InsertHelper(trie, i, str);
            }
        }

        public static bool Contains(SuffixTrie trie, string str)
        {
            char endSymbol = trie.EndSymbol;
            SuffixTrieNode currentNode = trie.Root;
            for (int i = 0; i < str.Length; i++)
            {
                char character = str[i];
                if (!currentNode.Children.ContainsKey(character))
                {
                    return false;
                }

                currentNode = currentNode.Children[character];
            }

            return currentNode.Children.ContainsKey(endSymbol);
        }

        public static void InsertHelper(SuffixTrie trie, int i, string str)
        {
            SuffixTrieNode currentNode = trie.Root;
            char endSymbol = trie.EndSymbol;
            for (int j = i; j < str.Length; j++)
            {
                char character = str[j];
                if (!currentNode.Children.ContainsKey(character))
                {
                    SuffixTrieNode newNode = new SuffixTrieNode();
                    currentNode.Children.Add(character, newNode);
                }

                currentNode = currentNode.Children[character];
            }

            currentNode.Children[endSymbol] = null;
        }
    }
}
