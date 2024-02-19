using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.DS.SuffixTrie
{
    internal class Runner
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
