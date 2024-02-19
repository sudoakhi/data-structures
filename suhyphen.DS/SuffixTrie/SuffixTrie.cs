using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.DS.SuffixTrie
{
    public class SuffixTrie
    {
        internal SuffixTrieNode _root;
        internal char _endSymbol = '*';

        public SuffixTrie()
        {
            _root = new SuffixTrieNode();
        }
    }
}
