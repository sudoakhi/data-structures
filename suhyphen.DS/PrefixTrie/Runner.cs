using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.DS.PrefixTrie
{
    internal class Runner
    {
        public static void Run()
        {
            string[] strings = {"the", "a", "there", "answer",
                        "any", "by", "bye", "their"};

            PrefixTrie trie = new PrefixTrie();
            foreach (string s in strings)
            {
                PrefixTrieHelper.Insert(trie, s);
            }

            //This should return true
            bool isStringPresent = PrefixTrieHelper.Search(trie, "there");
            Console.WriteLine(isStringPresent);

            //This should return false
            PrefixTrieHelper.Delete(trie, "there");
            isStringPresent = PrefixTrieHelper.Search(trie, "there");
            Console.WriteLine(isStringPresent);

            //This should return Algorithm
            isStringPresent = PrefixTrieHelper.Search(trie, "bya");
            Console.WriteLine(isStringPresent);

            //This should return true
            isStringPresent = PrefixTrieHelper.Search(trie, "by");
            Console.WriteLine(isStringPresent);

        }
    }
}
