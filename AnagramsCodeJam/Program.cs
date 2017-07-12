using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Codejam
{
    class Anagrams
    {
        int GetMaximumSubset(string[] words)
        {
            ArrayList finalWords = new ArrayList();
            for (int i = 0; i < words.Length; i++)
            {
                finalWords.Add(words[i]);
            }
            for (int i = 0; i < finalWords.Count; i++)
            {
                for (int j = i + 1; j < finalWords.Count; j++)
                {
                    if (AreAnagrams((string)finalWords[i], (string)finalWords[j]))
                    {
                        finalWords.RemoveAt(j);
                        j--;
                    }
                }
            }
            return finalWords.Count;
        }

        bool AreAnagrams(string str1, string str2)
        {
            return AreEqualMapping(CharacterMap(str1), CharacterMap(str2));
        }

        bool AreEqualMapping(Dictionary<char, int> charMap1, Dictionary<char, int> charMap2)
        {
            if (charMap1.Count != charMap2.Count) return false;
            foreach (KeyValuePair<char, int> entry in charMap1)
            {
                if (!charMap2.ContainsKey(entry.Key)) return false;
                if (charMap2[entry.Key] != entry.Value) return false;
            }
            return true;
        }

        Dictionary<char, int> CharacterMap(string str)
        {
            Dictionary<char, int> charMap = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (!charMap.ContainsKey(str[i]))
                {
                    charMap.Add(str[i], 1);
                }
                else
                {
                    charMap[str[i]] += 1;
                }
            }
            return charMap;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            Anagrams anagramSolver = new Anagrams();
            do
            {
                string[] words = input.Split(',');
                Console.WriteLine(anagramSolver.GetMaximumSubset(words));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}

