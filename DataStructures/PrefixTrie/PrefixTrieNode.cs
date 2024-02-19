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
    }
}
