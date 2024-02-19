using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.PrefixTrie
{
    internal sealed class PrefixTrieNode
    {
        internal char _value;
        internal List<PrefixTrieNode> _children;
        internal int _depth;
        internal PrefixTrieNode _parent;

        public PrefixTrieNode(char value, int depth, PrefixTrieNode parent)
        {
            _value = value;
            _children = [];
            _depth = depth;
            _parent = parent;
        }

        public bool IsLeaf()
        {
            return _children.Count == 0;
        }

        public PrefixTrieNode FindChildNode(char c)
        {
            foreach (var trieNode in _children)
            {
                if (trieNode._value == c)
                {
                    return trieNode;
                }
            }

            return null;
        }

        public void DeleteChildNode(char c)
        {
            for(var i=0; i< _children.Count; i++)
            {
                if (_children[i]._value == c)
                {
                    _children.RemoveAt(i);
                }
            }
        }
    }
}
