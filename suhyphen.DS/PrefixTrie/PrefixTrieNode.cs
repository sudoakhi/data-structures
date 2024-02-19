using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.DS.PrefixTrie
{
    public class PrefixTrieNode
    {
        internal char Value;
        internal List<PrefixTrieNode> Children;
        internal int Depth;
        internal PrefixTrieNode Parent;

        public PrefixTrieNode(char value, int depth, PrefixTrieNode parent)
        {
            Value = value;
            Children = new List<PrefixTrieNode>();
            Depth = depth;
            Parent = parent;
        }

        public bool IsLeaf()
        {
            return Children.Count == 0;
        }

        public PrefixTrieNode FindChildNode(char c)
        {
            foreach (var trieNode in Children)
            {
                if (trieNode.Value == c)
                {
                    return trieNode;
                }
            }

            return null;
        }

        public void DeleteChildNode(char c)
        {
            for(var i=0; i< Children.Count; i++)
            {
                if (Children[i].Value == c)
                {
                    Children.RemoveAt(i);
                }
            }
        }
    }
}
