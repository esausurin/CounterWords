using System;
using System.Collections.Generic;

namespace CounterWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Este es un texto de prueba, pero texto no quiero hacerlo, porque el texto me aburro!!!";

            string[] textSplited = text.Split(" ");
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (string word in textSplited)
            {
                string wordNormalized = normalizeWord(word);
                if (dictionary.ContainsKey(normalizeWord(wordNormalized)))
                {
                    int valueActs = dictionary[wordNormalized];
                    dictionary.Remove(wordNormalized);
                    dictionary.Add(wordNormalized,valueActs+1);
                }
                else
                {
                    dictionary.Add(word, 1);
                }                
            }

            foreach(string keys in dictionary.Keys)
            {
                Console.WriteLine("{0} : {1}", keys, dictionary[keys]);
            }
        }
        private static string normalizeWord(string data)
        {
            return data.Replace("/[.,!]/", "");
        }
    }
}
