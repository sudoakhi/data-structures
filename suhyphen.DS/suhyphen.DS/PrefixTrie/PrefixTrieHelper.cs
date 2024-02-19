using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.DS.PrefixTrie
{
    internal class PrefixTrieHelper
    {
        public static PrefixTrieNode Prefix(PrefixTrie trie, string s)
        {
            PrefixTrieNode currentNode = trie.Root;
            PrefixTrieNode resultNode = currentNode;
            foreach (char c in s)
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
            PrefixTrieNode prefixNode = Prefix(trie, s);
            PrefixTrieNode currentNode = prefixNode;
            for (int i = currentNode.Depth; i < s.Length; i++)
            {
                PrefixTrieNode newNode = new PrefixTrieNode(s[i], currentNode.Depth + 1, currentNode);
                currentNode.Children.Add(newNode);
                currentNode = newNode;
            }

            currentNode.Children.Add(new PrefixTrieNode('$', currentNode.Depth + 1, currentNode));
        }

        public static void Delete(PrefixTrie trie, string s)
        {
            if (Search(trie, s))
            {
                PrefixTrieNode trieNode = Prefix(trie, s).FindChildNode('$'); ;
                while (trieNode.IsLeaf())
                {
                    PrefixTrieNode parent = trieNode.Parent;
                    parent.DeleteChildNode(trieNode.Value);
                    trieNode = parent;
                }
            }
        }

        public static bool Search(PrefixTrie trie, string s)
        {
            PrefixTrieNode prefixNode = Prefix(trie, s);
            if (prefixNode.Depth == s.Length && prefixNode.FindChildNode('$') != null)
            {
                return true;
            }

            return false;
        }
    }
}
