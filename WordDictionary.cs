using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace UkrWordsRulesFinder
{
    class WordRules
    {
        public string mainRule;
        public List<string> addRules;
    }
    class WordDictionary
    {
        private Dictionary<string, WordRules> dictionary = new Dictionary<string, WordRules>();

        public WordDictionary(string filePath)
        {
            LoadDictionary(filePath);
        }
        private void LoadDictionary(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    WordRules wordRules = null;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.StartsWith(" +cs="))
                        {
                            string word = line.Substring(5);
                            dictionary[word] = wordRules;
                        }
                        else
                        {
                            wordRules = null;
                            string word;
                            var idx = line.IndexOf(' ');
                            if (idx >= 0)
                            {
                                string tags;
                                word = line.Substring(0, idx);
                                while ((idx + 1) < line.Length && line[++idx] == ' ') ;
                                if (idx < line.Length)
                                {
                                    var idx2 = line.IndexOf(' ', idx);
                                    if (idx2 >= 0)
                                        tags = line.Substring(idx, idx2 - idx);
                                    else
                                        tags = line.Substring(idx);
                                    tags = tags.Remove(0, 1);

                                    string[] rules = tags.Split('.');
                                    if (rules.Length > 0)
                                    {
                                        wordRules = new WordRules();
                                        wordRules.mainRule = rules[0];
                                        wordRules.addRules = new List<string>();
                                        for (var i = 1; i < rules.Length; i++)
                                            wordRules.addRules.Add(rules[i]);
                                    }
                                }
                            }
                            else
                                word = line;
                            // Додати слово та теги до словника
                            if (!dictionary.ContainsKey(word))
                                dictionary[word] = wordRules;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка при зчитуванні словника: " + ex.Message);
            }
        }

        public bool IsWordInDictionary(string word, out WordRules rules)
        {
            if (dictionary.TryGetValue(word, out rules))
            {
                return true;
            }
            rules = null;
            return false;
        }
    }
}
