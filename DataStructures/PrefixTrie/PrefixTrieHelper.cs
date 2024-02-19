using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.PrefixTrie
{
    internal static class PrefixTrieHelper
    {
        public static PrefixTrieNode Prefix(PrefixTrie trie, string s)
        {
            var currentNode = trie._root;
            var resultNode = currentNode;
            foreach (var c in s)
            {
                currentNode = currentNode.FindChildNode(c);
                if (currentNode == null)
                {
                    break;
                }

                resultNode = currentNode;
            }

            return resultNode;
        }

        public static void Insert(PrefixTrie trie, string s)
        {
            var prefixNode = Prefix(trie, s);
            var currentNode = prefixNode;
            for (var i = currentNode._depth; i < s.Length; i++)
            {
                var newNode = new PrefixTrieNode(s[i], currentNode._depth + 1, currentNode);
                currentNode._children.Add(newNode);
                currentNode = newNode;
            }

            currentNode._children.Add(new PrefixTrieNode('$', currentNode._depth + 1, currentNode));
        }

        public static void Delete(PrefixTrie trie, string s)
        {
            if (Search(trie, s))
            {
                var trieNode = Prefix(trie, s).FindChildNode('$');
                while (trieNode.IsLeaf())
                {
                    var parent = trieNode._parent;
                    parent.DeleteChildNode(trieNode._value);
                    trieNode = parent;
                }
            }
        }

        public static bool Search(PrefixTrie trie, string s)
        {
            var prefixNode = Prefix(trie, s);
			return prefixNode._depth == s.Length && prefixNode.FindChildNode('$') != null;
			}
		}
}
