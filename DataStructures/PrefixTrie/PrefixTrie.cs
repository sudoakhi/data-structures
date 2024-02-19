using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace DataStructures.PrefixTrie
{
    internal sealed class PrefixTrie
    {
        internal PrefixTrieNode _root;

        public PrefixTrie()
        {
            _root = new PrefixTrieNode('^', 0, null);
        }
    }
}
