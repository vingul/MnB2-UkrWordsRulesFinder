using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace UkrWordsRulesFinder
{
    public partial class frmMain : Form
    {
        private Dictionary<string, Tuple<Dictionary<string, SuffixGroup>, string>> m_affixes = null;
        private Dictionary<string, Tuple<string, List<Tuple<string, string>>>> m_rulesList = null;
        private WordDictionary dict = null;
        private List<(string word, string tags, string gender)> m_words = new List<(string word, string tags, string gender)>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {

            var dir = new DirectoryInfo("affixes");
            if (!dir.Exists)
            {
                MessageBox.Show("Немає папки з правилами! Папка з іменем 'affixes' має містити файли з розширенням AFF та розміщуватися в папці з програмою!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Affix affix = new Affix();
                m_affixes = affix.LoadAffixes("affixes");

                m_rulesList = new Dictionary<string, Tuple<string, List<Tuple<string, string>>>>();
                foreach (var kvp in m_affixes)
                {
                    string[] rules = kvp.Key.Split('.');
                    Tuple<string, List<Tuple<string, string>>> subRules;
                    if (rules.Length > 1)
                    {
                        if (!m_rulesList.TryGetValue(rules[0], out subRules))
                        {
                            subRules = new Tuple<string, List<Tuple<string, string>>>("", new List<Tuple<string, string>>());
                            m_rulesList[rules[0]] = subRules;
                        }
                        for (var i = 1; i < rules.Length; i++)
                            subRules.Item2.Add(new Tuple<string, string>(rules[i], kvp.Value.Item2));
                    }
                    else
                    {
                        if (!m_rulesList.TryGetValue(kvp.Key, out subRules))
                        {
                            m_rulesList[kvp.Key] = new Tuple<string, List<Tuple<string, string>>>(kvp.Value.Item2, new List<Tuple<string, string>>());
                        }
                    }
                }
            }
        }
        private void ProcessWords()
        {
            if (dict == null)
            {
                string dictName = "dict\\base.lst";
                FileInfo fi = new FileInfo(dictName);
                if (!fi.Exists)
                {
                    MessageBox.Show("Немає файлу-словника! Папка з іменем 'dict' має містити файл-словник з іменем 'base.lst' та розміщуватися в папці з програмою!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dict = new WordDictionary(dictName);
                }
            }

            string[] words = textWords.Text.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            tabWords.TabPages.Clear();
            string defMainRule = m_rulesList.ContainsKey("adj") ? "adj" : m_rulesList.Keys.First();
            WordRules rules;
            m_words.Clear();

            foreach (var word in words)
                m_words.Add((word, "", ""));
            int index = 0;
            foreach (var word in words)
            {
                rules = null;
                bool wordFound = false;
                if (dict != null)
                {
                    wordFound = dict.IsWordInDictionary(word.ToLower(), out rules);
                }
                string mainRule = wordFound ? rules.mainRule : defMainRule;
                HashSet<string> additionalRules = rules?.addRules.ToHashSet();
                WordControl wordControl = new WordControl(word, index++, wordFound, m_affixes, m_rulesList);
                wordControl.WordUpdatedEvent += WordControl_WordUpdatedEvent;
                wordControl.SelectRules(mainRule, additionalRules);
                TabPage tp = new TabPage();
                tp.Text = word;
                tp.ImageIndex = wordFound ? 0 : 1;
                tp.Controls.Add(wordControl);
                tabWords.TabPages.Add(tp);
                tp.PerformLayout();
                wordControl.Size = tp.ClientSize;
                wordControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                wordControl.KeyPressCheckEvent += hotkeyChecker;
            }
        }
        private void btnWords_Click(object sender, EventArgs e)
        {
            ProcessWords();
        }

        private void WordControl_WordUpdatedEvent(object sender, WordUpdatedEventArgs e)
        {
            WordControl wc = (WordControl)sender;
            foreach(var obj in tabWords.TabPages)
            {
                TabPage tp = (TabPage)obj;
                if (tp.Controls.Count == 1 && tp.Controls[0] == wc)
                {
                    tp.Text = e.ModifiedWord;
                    break;
                }
                
            }
            string gender;
            switch (e.Gender)
            {
                case WordUpdatedEventArgs.GenderType.gtM:
                    gender = "m";
                    break;
                case WordUpdatedEventArgs.GenderType.gtF:
                    gender = "f";
                    break;
                case WordUpdatedEventArgs.GenderType.gtN:
                    gender = "n";
                    break;
                default:// case WordUpdatedEventArgs.GenderType.gtP:
                    gender = "p";
                    break;
            }
            if (e.Index >= 0 && e.Index < m_words.Count)
            {
                m_words[e.Index] = (e.Word, string.Join("_", e.Tags), gender);
                string s = "";
                foreach (var w in m_words)
                    s += $"{{.{w.gender}}}{w.word}{{.R_{w.tags}}} ";

                textWordsProcessed.Text = s.Trim();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textWordsProcessed.Text);
        }

        private void textWords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ProcessWords();
            else
            {
                hotkeyChecker(sender, e);
            }
        }

        private void hotkeyChecker(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                
                int gender = -1;
                switch (e.KeyCode)
                {
                    case Keys.D1:
                        gender = 0;
                        break;
                    case Keys.D2:
                        gender = 1;
                        break;
                    case Keys.D3:
                        gender = 2;
                        break;
                    case Keys.D4:
                        gender = 3;
                        break;
                    case Keys.C:
                        if (e.Alt)
                            Clipboard.SetText(textWordsProcessed.Text);
                        break;
                    case Keys.V:
                        if (e.Alt)
                            textWords.Text = Clipboard.GetText();
                        break;
                    case Keys.Q:
                        if (tabWords.SelectedIndex > 0)
                            tabWords.SelectedIndex = tabWords.SelectedIndex - 1;
                        break;
                    case Keys.E:
                        if (tabWords.SelectedIndex < (tabWords.TabPages.Count - 1))
                            tabWords.SelectedIndex = tabWords.SelectedIndex + 1;
                        break;
                }
                if (gender != -1 &&
                    tabWords.SelectedTab != null &&
                    tabWords.SelectedTab.Controls != null &&
                    tabWords.SelectedTab.Controls.Count > 0)
                {
                    WordControl wcCrr = (WordControl)tabWords.SelectedTab.Controls[0];
                    wcCrr.SelectGender(gender);
                }
            }
        }
    }
}
