using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.PrefixTrie
{
    internal static class Runner
    {
        public static void Run()
        {
            string[] strings = ["the", "a", "there", "answer",
                        "any", "by", "bye", "their"];

            var trie = new PrefixTrie();
            foreach (var s in strings)
            {
                PrefixTrieHelper.Insert(trie, s);
            }

            //This should return true
            var isStringPresent = PrefixTrieHelper.Search(trie, "there");
            Console.WriteLine(isStringPresent);

            //This should return false
            PrefixTrieHelper.Delete(trie, "there");
            isStringPresent = PrefixTrieHelper.Search(trie, "there");
            Console.WriteLine(isStringPresent);

            //This should return false
            isStringPresent = PrefixTrieHelper.Search(trie, "bya");
            Console.WriteLine(isStringPresent);

            //This should return true
            isStringPresent = PrefixTrieHelper.Search(trie, "by");
            Console.WriteLine(isStringPresent);

        }
    }
}
