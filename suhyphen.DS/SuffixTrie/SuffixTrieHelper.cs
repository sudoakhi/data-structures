using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.DS.SuffixTrie
{
    internal class SuffixTrieHelper
    {
        public static void Insert(SuffixTrie trie, string str)
        {
            for (var i = 0; i < str.Length; i++)
            {
                InsertHelper(trie, i, str);
            }
        }

        public static bool Contains(SuffixTrie trie, string str)
        {
            var endSymbol = trie._endSymbol;
            var currentNode = trie._root;
            for (var i = 0; i < str.Length; i++)
            {
                var character = str[i];
                if (!currentNode.Children.TryGetValue(character, out var value))
                {
                    return false;
                }

                currentNode = value;
            }

            return currentNode.Children.ContainsKey(endSymbol);
        }

        public static void InsertHelper(SuffixTrie trie, int i, string str)
        {
            var currentNode = trie._root;
            var endSymbol = trie._endSymbol;
            for (var j = i; j < str.Length; j++)
            {
                var character = str[j];
                if (!currentNode.Children.TryGetValue(character, out var value))
                {
                    var newNode = new SuffixTrieNode();
					value = newNode;
					currentNode.Children.Add(character, value );
                }

                currentNode = value;
            }

            currentNode.Children[endSymbol] = null;
        }
    }
}
