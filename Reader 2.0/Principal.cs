using CustomTextReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reader_2._0
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        BusinessRule businessRule = new BusinessRule();
        private int typeOriginalText = 1;
        private string concatenatedStrings = "";
        private int TypeOriginalText { get => typeOriginalText; set => typeOriginalText = value; }
        private string ConcatenatedStrings { get => concatenatedStrings; set => concatenatedStrings = value; }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Rules.Text = businessRule.EditRules(TypeOriginalText);
            ConcatenatedStrings = TypeOriginalText == 0 ? businessRule.SepareteSentencesSpanish(richTextBox1.Text) :
                                  TypeOriginalText == 1 ? businessRule.SepareteSentencesNormal(richTextBox1.Text) :
                                  businessRule.SepareteSentencesGermany(richTextBox1.Text);
            DataTable table = businessRule.CarregaView(ConcatenatedStrings, null, checkBox1.Checked);
            dataGridView1.DataSource = table;

            Average.Text = "Average Characters: " + businessRule.MediaCaracteres(table).ToString();
        }

        private void SpanishLg_Click(object sender, EventArgs e)
        {
            TypeOriginalText = 0;
            Rules.Text = businessRule.EditRules(TypeOriginalText);
            ConcatenatedStrings = businessRule.SepareteSentencesSpanish(richTextBox1.Text);
            DataTable table = businessRule.CarregaView(ConcatenatedStrings, null, checkBox1.Checked);
            dataGridView1.DataSource = table;
        }

        private void NormalLg_Click(object sender, EventArgs e)
        {
            TypeOriginalText = 1;
            Rules.Text = businessRule.EditRules(TypeOriginalText);
            ConcatenatedStrings = businessRule.SepareteSentencesNormal(richTextBox1.Text);
            DataTable table = businessRule.CarregaView(ConcatenatedStrings,null, checkBox1.Checked);
            dataGridView1.DataSource = table;
        }

        private void GermanyLg_Click(object sender, EventArgs e)
        {
            TypeOriginalText = 2;
            Rules.Text = businessRule.EditRules(TypeOriginalText);
            ConcatenatedStrings = businessRule.SepareteSentencesGermany(richTextBox1.Text);
            DataTable table = businessRule.CarregaView(ConcatenatedStrings, null, checkBox1.Checked);
            dataGridView1.DataSource = table;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string word = textBox1.Text;

            Rules.Text = businessRule.EditRules(TypeOriginalText);
            ConcatenatedStrings = TypeOriginalText == 0 ? businessRule.SepareteSentencesSpanish(richTextBox1.Text) :
                                  TypeOriginalText == 1 ? businessRule.SepareteSentencesNormal(richTextBox1.Text) :
                                  businessRule.SepareteSentencesGermany(richTextBox1.Text);
            
            string[] Sentences = ConcatenatedStrings.Split('*');
            string listSentenceWithWord = "";

            foreach(string sentence in Sentences)
            {
                if (sentence.Contains(word))
                {
                    listSentenceWithWord += "*" + sentence;
                }
            }
         
            DataTable table = businessRule.CarregaView(ConcatenatedStrings, listSentenceWithWord.Split('*'), checkBox1.Checked);
            dataGridView1.DataSource = table;

            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    dataGridView1.Rows[i].Cells[1].Value.
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1_TextChanged(sender, e);
        }
    }
}