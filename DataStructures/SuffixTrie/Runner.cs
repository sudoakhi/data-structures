using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SuffixTrie
{
    internal static class Runner
    {
        public static void Run()
        {
            var inputString = "babc";
            var trie = new SuffixTrie();
            SuffixTrieHelper.Insert(trie, inputString);

            //This should return true
            var isStringPresent = SuffixTrieHelper.Contains(trie, "abc");
            Console.WriteLine(isStringPresent);
        }
    }
}
