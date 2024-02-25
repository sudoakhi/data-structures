using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SuffixTrie
{
    internal sealed class SuffixTrieNode
    {
		internal Dictionary<char, SuffixTrieNode> _children;

		public SuffixTrieNode()
		{
			_children = [];
		}
	}
}
