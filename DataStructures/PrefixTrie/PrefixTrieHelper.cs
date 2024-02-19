using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.PrefixTrie
{
    internal static class PrefixTrieHelper
    {
        internal static PrefixTrieNode Prefix(PrefixTrie trie , string s)
        {
            var currentNode = trie._root;
            var resultNode = currentNode;
            foreach ( var c in s )
            {
                currentNode = FindChildNode(currentNode, c);
                if ( currentNode == null )
                {
                    break;
                }

                resultNode = currentNode;
            }

            return resultNode;
        }

        internal static void Insert(PrefixTrie trie , string s)
        {
            var prefixNode = Prefix(trie, s);
            var currentNode = prefixNode;
            for ( var i = currentNode._depth; i < s.Length; i++ )
            {
                var newNode = new PrefixTrieNode(s[i], currentNode._depth + 1, currentNode);
                currentNode._children.Add(newNode);
                currentNode = newNode;
            }

            currentNode._children.Add(new PrefixTrieNode('$' , currentNode._depth + 1 , currentNode));
        }

        internal static void Delete(PrefixTrie trie , string s)
        {
            if ( Search(trie , s) )
            {
                var trieNode = FindChildNode(Prefix(trie, s), '$');
                while ( IsLeaf(trieNode) )
                {
                    var parent = trieNode._parent;
                    DeleteChildNode(trieNode, trieNode._value);
                    trieNode = parent;
                }
            }
        }

        internal static bool Search(PrefixTrie trie , string s)
        {
            var prefixNode = Prefix(trie, s);
            return prefixNode._depth == s.Length && FindChildNode(prefixNode, '$') != null;
        }

        private static bool IsLeaf(PrefixTrieNode node)
        {
            return node._children.Count == 0;
        }

        private static PrefixTrieNode FindChildNode(PrefixTrieNode node , char c)
        {
            foreach (var trieNode in node._children)
            {
                if ( trieNode._value == c )
                {
                    return trieNode;
                }
            }

            return null;
        }

        private static void DeleteChildNode(PrefixTrieNode node, char c)
        {
            for ( var i = 0; i < node._children.Count; i++ )
            {
                if ( node._children [ i ]._value == c )
                {
                    node._children.RemoveAt(i);
                }
            }
        }
    }
}
