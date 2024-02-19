using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.DS.SuffixTrie
{
    public class SuffixTrieNode
    {
		public Dictionary<char,SuffixTrieNode> Children { get; } = [];
	}
}
