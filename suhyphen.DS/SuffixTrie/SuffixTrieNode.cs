using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.DS.SuffixTrie
{
    public class SuffixTrieNode
    {
        public Dictionary<char, SuffixTrieNode> Children = new Dictionary<char, SuffixTrieNode>();
    }
}
