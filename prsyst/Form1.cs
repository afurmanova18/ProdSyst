using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prsyst
{
    public partial class Form1 : Form
    {
        public class Rule
        {
            public List<Fact> Conditions { get; private set; }
            public List<Fact> Consequences { get; private set; }

            public Rule(List<Fact> conditions, List<Fact> consequences)
            {
                Conditions = conditions;
                Consequences = consequences;
            }

            public bool IsApplicable(HashSet<Fact> facts)
            {
                foreach (Fact cond in Conditions)
                {

                    if (!facts.Contains(cond))
                        return false;
                }

                return true;
            }

            public override string ToString()
            {
                return FactsListToString(Conditions) + "->" + FactsListToString(Consequences);
            }

            private string FactsListToString(List<Fact> facts)
            {
                return string.Join(",", facts);
            }
        }
        public class Fact
        {
            public Fact(string id, string name)
            {
                Id = id;
                Name = name;
            }

            public string Id { get; }

            public string Name { get; }

            public override string ToString()
            {
                return Id;
            }

            public override int GetHashCode()
            {
                return Id.GetHashCode();
            }
            private bool Equals(Fact fact)
            {
                return this.Id == fact.Id;
            }
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                Fact other = (Fact)obj;
                return this.Id.Equals(other.Id);
            }
        }

        private List<Rule> rules;

        public Form1()
        {
            InitializeComponent();
            rules = LoadRulesFromFile("rules.txt", ParseFactsFromFile("facts.txt"));
        }

        public void Deduce(HashSet<Fact> startingFacts)
        {

            HashSet<Fact> currentFacts = new HashSet<Fact>(startingFacts);
            HashSet<Fact> newFacts = new HashSet<Fact>();
            bool changes;

            do
            {
                changes = false;

                foreach (var rule in rules)
                {
                    if (rule.IsApplicable(currentFacts))
                    {
                        foreach (var consequence in rule.Consequences)
                        {
                            if (!currentFacts.Contains(consequence))
                            {
                                newFacts.Add(consequence);
                                changes = true;

                                bool firstCondition = true;
                                foreach (var condition in rule.Conditions)
                                {
                                    if (!firstCondition)
                                    {
                                        textBox1.AppendText(", ");
                                    }
                                    textBox1.AppendText(condition.Name);
                                    firstCondition = false;
                                }
                                textBox1.AppendText(" -> " + consequence.Name + Environment.NewLine);
                            }
                        }
                    }
                }

                foreach (var fact in newFacts)
                {
                    currentFacts.Add(fact);
                }

                newFacts.Clear();

            } while (changes);

        }



        public List<Rule> LoadRulesFromFile(string filePath, HashSet<Fact> allFacts)
        {
            List<Rule> loadedRules = new List<Rule>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');

                    if (parts.Length == 2)
                    {
                        List<Fact> conditions = ParseFacts(parts[0], allFacts);
                        List<Fact> consequences = ParseFacts(parts[1], allFacts);

                        Rule rule = new Rule(conditions, consequences);
                        loadedRules.Add(rule);
                    }
                    else
                    {
                        MessageBox.Show("Некорректный формат правила: " + line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
            }

            return loadedRules;
        }

        private List<Fact> ParseFacts(string factString, HashSet<Fact> allFacts)
        {

            List<Fact> facts = new List<Fact>();

            string[] factIds = factString.Split(',');
            foreach (string factId in factIds)
            {
                string trimmedFactId = factId.Trim();
                if (!string.IsNullOrEmpty(trimmedFactId))
                {
                
                    Fact existingFact = allFacts.FirstOrDefault(f => f.Id == trimmedFactId);


                    if (existingFact != null)
                    {
                        Fact newFact = new Fact(trimmedFactId, existingFact.Name);
                        facts.Add(newFact);
                    }
                    else
                    {
                        Fact newFact = new Fact(trimmedFactId, string.Empty);
                        facts.Add(newFact);
                    }
                }
            }

            return facts;
        }

        public HashSet<Fact> ParseFactsFromFile(string filePath)
        {
            HashSet<Fact> factsHashSet = new HashSet<Fact>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');

                    if (parts.Length == 2)
                    {
                        string id = parts[0].Trim();
                        string name = parts[1].Trim();

                        Fact fact = new Fact(id, name);
                        factsHashSet.Add(fact);
                    }
                    else
                    {
                        MessageBox.Show("Некорректный формат строки факта: " + line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
            }

            return factsHashSet;
        }


        private void clear_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

        }

        private void direct_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            HashSet<Fact> selectedFacts = new HashSet<Fact>();


            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {

                if (checkedListBox1.GetItemChecked(i))
                {
                    string selectedItem = checkedListBox1.Items[i].ToString();


                    string[] parts = selectedItem.Split(';');

                    if (parts.Length == 2)
                    {
                        string id = parts[0];
                        string name = parts[1];

                        Fact selectedFact = new Fact(id, name);
                        selectedFacts.Add(selectedFact);
                    }
                }
            }
            Deduce(selectedFacts);


        }


        private void AddRulesToTextBox(List<Rule> rules)
        {
            foreach (Rule rule in rules)
            {
                foreach (var item in rule.Conditions )
                {
                    textBox2.Text += item.Name.ToString() + " ";
                }
                textBox2.Text += "-> ";

                foreach(var item in rule.Consequences)
                {
                    textBox2.Text += item.Name + Environment.NewLine;
                }
              
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            List<Rule> rules = LoadRulesFromFile("rules.txt", ParseFactsFromFile("facts.txt"));
            AddRulesToTextBox(rules);
        }
    }


}
