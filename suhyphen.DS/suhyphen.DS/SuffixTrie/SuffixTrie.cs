using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.DS.SuffixTrie
{
    public class SuffixTrie
    {
        internal SuffixTrieNode Root;
        internal char EndSymbol = '*';

        public SuffixTrie()
        {
            Root = new SuffixTrieNode();
        }
    }
}
