using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.DS.SuffixTrie
{
    internal class Runner
    {
        public static void Run()
        {
            string inputString = "babc";
            SuffixTrie trie = new SuffixTrie();
            SuffixTrieHelper.Insert(trie, inputString);

            //This should return true
            bool isStringPresent = SuffixTrieHelper.Contains(trie, "abc");
            Console.WriteLine(isStringPresent);
        }
    }
}
