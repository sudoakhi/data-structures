using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.DS.PrefixTrie
{
    internal class PrefixTrieHelper
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
            for (var i = currentNode.Depth; i < s.Length; i++)
            {
                var newNode = new PrefixTrieNode(s[i], currentNode.Depth + 1, currentNode);
                currentNode.Children.Add(newNode);
                currentNode = newNode;
            }

            currentNode.Children.Add(new PrefixTrieNode('$', currentNode.Depth + 1, currentNode));
        }

        public static void Delete(PrefixTrie trie, string s)
        {
            if (Search(trie, s))
            {
                var trieNode = Prefix(trie, s).FindChildNode('$');
                while (trieNode.IsLeaf())
                {
                    var parent = trieNode.Parent;
                    parent.DeleteChildNode(trieNode.Value);
                    trieNode = parent;
                }
            }
        }

        public static bool Search(PrefixTrie trie, string s)
        {
            var prefixNode = Prefix(trie, s);
			return prefixNode.Depth == s.Length && prefixNode.FindChildNode('$') != null;
			}
		}
}
