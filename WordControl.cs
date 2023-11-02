using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UkrWordsRulesFinder
{
    public partial class WordControl : UserControl
    {
        private Dictionary<string, Tuple<string, List<Tuple<string, string>>>> m_rulesList = null;
        private Dictionary<string, Tuple<Dictionary<string, SuffixGroup>, string>> m_affixes = null;
        private string m_word;
        private int m_index;
        private ToolTip m_addRulesTooltips = new ToolTip();
        private bool m_progrSel = false;

        public event WordUpdatedEventHandler WordUpdatedEvent;
        public event KeyEventHandler KeyPressCheckEvent;
        public WordControl(string word, int index, bool wordFound, Dictionary<string, Tuple<Dictionary<string, SuffixGroup>, string>> affixes, Dictionary<string, Tuple<string, List<Tuple<string, string>>>> rulesList)
        {
            m_word = word;
            m_index = index;
            m_affixes = affixes;
            m_rulesList = rulesList;
            InitializeComponent();

            lblStatusInfo.Text = wordFound ? "Знайдено" : "Не знайдено";
            lblStatusInfo.ForeColor = wordFound ? Color.FromArgb(0, 192, 0) : Color.FromArgb(192, 0, 0);
            foreach (var rule in rulesList)
            {
                comboMainRule.Items.Add(rule.Key);
            }
        }
        public void SelectGender(int index)
        {
            if (index >= 0 && index < 4)
                tabGenders.SelectedIndex = index;
        }
        public void SelectRules(string mainRule, HashSet<string> additionalRules)
        {
            m_progrSel = true;
            comboMainRule.SelectedItem = mainRule;
            if (comboMainRule.SelectedIndex == -1)
            {
                comboMainRule.SelectedIndex = 0;
            }
            m_progrSel = false;
            foreach (var controlRule in flowAddRules.Controls)
            {
                CheckBox cbRule = (CheckBox)controlRule;
                cbRule.Checked = additionalRules != null && additionalRules.Contains(cbRule.Text);
            }
            UpdateWord();
        }

        public void UpdateWord()
        {
            string mainRule = (string)comboMainRule.SelectedItem;
            List<string> affixRules = new List<string>();
            affixRules.Add(mainRule);

            List<string> crrWordTags = new List<string>();
            crrWordTags.Add(mainRule);

            foreach (var controlRule in flowAddRules.Controls)
            {
                CheckBox cbRule = (CheckBox)controlRule;
                if (cbRule.Checked)
                {
                    affixRules.Add($"{mainRule}.{cbRule.Text}");
                    crrWordTags.Add(cbRule.Text);
                }
            }
            Dictionary<string, List<(string gender, string rule, Suffix suffix)>> vidms = new Dictionary<string, List<(string, string, Suffix)>>();
            vidms["v_naz"] = new List<(string, string, Suffix)>();
            vidms["v_rod"] = new List<(string, string, Suffix)>();
            vidms["v_dav"] = new List<(string, string, Suffix)>();
            vidms["v_zna"] = new List<(string, string, Suffix)>();
            vidms["v_zn1"] = new List<(string, string, Suffix)>();
            vidms["v_zn2"] = new List<(string, string, Suffix)>();
            vidms["v_oru"] = new List<(string, string, Suffix)>();
            vidms["v_mis"] = new List<(string, string, Suffix)>();
            vidms["v_kly"] = new List<(string, string, Suffix)>();

            bool has_m = false, has_f = false, has_n = false;

            foreach (var affixRule in affixRules)
            {
                Tuple<Dictionary<string, SuffixGroup>, string> affixDict;
                if (m_affixes.TryGetValue(affixRule, out affixDict))
                {
                    foreach (var affVar in affixDict.Item1)
                    {
                        if (affVar.Value.Matches(m_word))
                        {
                            List<Suffix> suffixes = affVar.Value.GetAffixes();
                            foreach (var suff in suffixes)
                            {
                                string tags = suff.GetTags();
                                int idx = tags.IndexOf(':');
                                if (idx >= 0)
                                {
                                    tags = tags.Remove(0, idx + 1);
                                }
                                string[] vid = tags.Split(new string[] { "//" }, StringSplitOptions.RemoveEmptyEntries);
                                foreach (var varVid in vid)
                                {
                                    string[] parts = varVid.Split(':');
                                    if (parts.Length > 1)
                                    {
                                        string rid = parts[0];
                                        switch (rid)
                                        {
                                            case "m":
                                                has_m = true;
                                                break;
                                            case "f":
                                                has_f = true;
                                                break;
                                            case "n":
                                                has_n = true;
                                                break;
                                        }
                                        string[] arr_vs = parts[1].Split('/');
                                        if (arr_vs.Length == 1)
                                        {
                                            vidms[arr_vs[0]].Insert(0, new ValueTuple<string, string, Suffix>(rid, affixRule, suff));
                                        }
                                        else
                                        {
                                            foreach (var v in arr_vs)
                                            {
                                                if (vidms.ContainsKey(v))
                                                {
                                                    vidms[v].Add(new ValueTuple<string, string, Suffix>(rid, affixRule, suff));
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            listMusculine.Items.Clear();
            listFeminine.Items.Clear();
            listNeuter.Items.Clear();
            listPlural.Items.Clear();

            if (has_m)
                FillListView(listMusculine, vidms, "m");
            if (has_f)
                FillListView(listFeminine, vidms, "f");
            if (has_n)
                FillListView(listNeuter, vidms, "n");
            FillListView(listPlural, vidms, "p");

            pageMasculine.ImageIndex = has_m ? 0 : 1;
            pageFeminine.ImageIndex = has_f ? 0 : 1;
            pageNeuter.ImageIndex = has_n ? 0 : 1;
            pagePlural.ImageIndex = 0;

            if (WordUpdatedEvent != null)
            {
                WordUpdatedEventArgs e = new WordUpdatedEventArgs();
                e.Index = m_index;
                e.Word = m_word;
                e.Tags = crrWordTags;
                string g;
                switch (tabGenders.SelectedIndex)
                {
                    case 0: // Tab Masculine
                        e.Gender = WordUpdatedEventArgs.GenderType.gtM;
                        g = "m";
                        break;
                    case 1: // Tab Feminine
                        e.Gender = WordUpdatedEventArgs.GenderType.gtF;
                        g = "f";
                        break;
                    case 2: // Tab Neuter
                        e.Gender = WordUpdatedEventArgs.GenderType.gtN;
                        g = "n";
                        break;
                    default: // Default Tab Plural
                        e.Gender = WordUpdatedEventArgs.GenderType.gtP;
                        g = "p";
                        break;
                }
                e.ModifiedWord = m_word;
                foreach (var s in vidms["v_naz"])
                {
                    if (s.gender == g)
                    {
                        e.ModifiedWord = s.suffix.Apply(m_word);
                        break;
                    }
                }
                WordUpdatedEvent.Invoke(this, e);
            }
        }

        private void FillListView(ListView listView, Dictionary<string, List<(string gender, string rule, Suffix suffix)>> vidms, string gen)
        {
            string v_naz_def = m_word;
            foreach (var v in vidms["v_naz"])
            {
                if (v.Item1 == gen)
                {
                    v_naz_def = v.suffix.Apply(m_word);
                    break;
                }
            }
            AddListViewItem(listView, vidms["v_naz"], gen, v_naz_def, "Називний", "Є (хто? що?)");
            AddListViewItem(listView, vidms["v_rod"], gen, v_naz_def, "Родовий", "Немає (кого? чого?)");
            AddListViewItem(listView, vidms["v_dav"], gen, v_naz_def, "Давальний", "Даю (кому? чому?)");
            AddListViewItem(listView, vidms["v_zna"], gen, v_naz_def, "Знахідний", "Бачу (кого? що?)");
            /*AddListViewItem(listView, vidms["v_zn1"], gen, v_naz_def, "Знахідний", "Бачу (кого? що?)");
            AddListViewItem(listView, vidms["v_zn2"], gen, v_naz_def, "Знахідний", "Бачу (кого? що?)");*/
            AddListViewItem(listView, vidms["v_oru"], gen, v_naz_def, "Орудний", "Пишаюся (ким? чим?)");
            AddListViewItem(listView, vidms["v_mis"], gen, v_naz_def, "Місцевий", "Стою (на кому/чому?)");
            AddListViewItem(listView, vidms["v_kly"], gen, v_naz_def, "Кличний", "Ей");
        }
        private void AddListViewItem(ListView listView, List<(string gender, string rule, Suffix suffix)> suffixes, string gen, string def_value, string vidm_text, string quest_text)
        {
            ListViewItem item = listView.Items.Add(vidm_text);
            item.SubItems.Add(quest_text);

            bool found_gen = false;
            if (suffixes.Count > 0)
            {
                foreach (var suffix in suffixes)
                {
                    if (suffix.gender == gen)
                    {
                        item.SubItems.Add(suffix.suffix.Apply(m_word));
                        item.SubItems.Add(suffix.rule);
                        found_gen = true;
                    }
                }
            }
            if (!found_gen)
            {
                item.SubItems.Add(def_value);
                item.SubItems.Add("<Нема>");
            }
        }

        private void checkBoxAdditionalRule_Clicked(object sender, EventArgs e)
        {
            UpdateWord();
        }

        private void comboMainRule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_rulesList != null)
            {
                string mainRule = (string)comboMainRule.SelectedItem;
                Tuple<string, List<Tuple<string, string>>> subRules;
                if (m_rulesList.TryGetValue(mainRule, out subRules))
                {
                    lblMainRuleHint.Text = subRules.Item1;
                    flowAddRules.Controls.Clear();
                    m_addRulesTooltips.RemoveAll();
                    foreach (var subRule in subRules.Item2)
                    {
                        CheckBox cbAddRule = new CheckBox();
                        cbAddRule.AutoSize = true;
                        cbAddRule.Text = subRule.Item1;
                        cbAddRule.Click += checkBoxAdditionalRule_Clicked;
                        cbAddRule.KeyDown += keyPressChecker_KeyDown;
                        m_addRulesTooltips.SetToolTip(cbAddRule, subRule.Item2);
                        flowAddRules.Controls.Add(cbAddRule);
                    }
                }
                if (!m_progrSel)
                    UpdateWord();
            }
        }

        private void tabGenders_Selected(object sender, TabControlEventArgs e)
        {
            if (WordUpdatedEvent != null)
            {
                string mainRule = (string)comboMainRule.SelectedItem;
                List<string> affixRules = new List<string>();
                affixRules.Add(mainRule);

                List<string> crrWordTags = new List<string>();
                crrWordTags.Add(mainRule);

                foreach (var controlRule in flowAddRules.Controls)
                {
                    CheckBox cbRule = (CheckBox)controlRule;
                    if (cbRule.Checked)
                    {
                        affixRules.Add($"{mainRule}.{cbRule.Text}");
                        crrWordTags.Add(cbRule.Text);
                    }
                }

                string g;
                WordUpdatedEventArgs evt = new WordUpdatedEventArgs();
                evt.Index = m_index;
                evt.Word = m_word;
                evt.Tags = crrWordTags;
                switch (tabGenders.SelectedIndex)
                {
                    case 0: // Tab Masculine
                        evt.Gender = WordUpdatedEventArgs.GenderType.gtM;
                        g = "m";
                        break;
                    case 1: // Tab Feminine
                        evt.Gender = WordUpdatedEventArgs.GenderType.gtF;
                        g = "f";
                        break;
                    case 2: // Tab Neuter
                        evt.Gender = WordUpdatedEventArgs.GenderType.gtN;
                        g = "n";
                        break;
                    default: // Default Tab Plural
                        evt.Gender = WordUpdatedEventArgs.GenderType.gtP;
                        g = "p";
                        break;
                }

                // Знаходимо правило для відмінювання слова в називному відмінку для заданого роду або множини
                string new_word = m_word;
                bool found_rule = false;
                foreach (var affixRule in affixRules)
                {
                    Tuple<Dictionary<string, SuffixGroup>, string> affixDict;
                    if (m_affixes.TryGetValue(affixRule, out affixDict))
                    {
                        foreach (var affVar in affixDict.Item1)
                        {
                            if (affVar.Value.Matches(m_word))
                            {
                                List<Suffix> suffixes = affVar.Value.GetAffixes();
                                foreach (var suff in suffixes)
                                {
                                    string tags = suff.GetTags();
                                    int idx = tags.IndexOf(':');
                                    if (idx >= 0)
                                    {
                                        tags = tags.Remove(0, idx + 1);
                                    }
                                    string[] vid = tags.Split(new string[] { "//" }, StringSplitOptions.RemoveEmptyEntries);
                                    foreach (var varVid in vid)
                                    {
                                        string[] parts = varVid.Split(':');
                                        if (parts.Length > 1)
                                        {
                                            string rid = parts[0];
                                            if (rid == g)
                                            {
                                                string[] arr_vs = parts[1].Split('/');
                                                foreach (var v in arr_vs)
                                                {
                                                    if (v == "v_naz")
                                                    {
                                                        new_word = suff.Apply(m_word);
                                                        found_rule = true;
                                                        break;
                                                    }
                                                }
                                                if (found_rule)
                                                    break;
                                            }
                                        }
                                    }
                                    if (found_rule)
                                        break;
                                }
                                if (found_rule)
                                    break;
                            }
                        }
                        if (found_rule)
                            break;
                    }
                }
                evt.ModifiedWord = new_word;

                WordUpdatedEvent.Invoke(this, evt);
            }
        }

        private void keyPressChecker_KeyDown(object sender, KeyEventArgs e)
        {
            KeyPressCheckEvent?.Invoke(sender, e);
        }
    }
    public class WordUpdatedEventArgs : EventArgs
    {
        public enum GenderType { gtM, gtF, gtN, gtP }
        public int Index { get; set; }
        public string Word { get; set; }
        public string ModifiedWord { get; set; }
        public List<string> Tags { get; set; }
        public GenderType Gender { get; set; }
    }
    public delegate void WordUpdatedEventHandler(object sender, WordUpdatedEventArgs e);
}
