using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizpandawinform
{
    public partial class quizpanda : Form
    {
        public quizpanda()
        {
            InitializeComponent();
        }
        public static char caesar(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }
            char c = 'A';
            return (char)(((ch + key - c) % 26) + c);
        }
        public static string encaesar(string input, string first, string second)
        {
            int key = (second[0] < first[0] ? second[0] - first[0] + 26 : second[0] - first[0]);
            string output = "";
            foreach (char ch in input)
            {
                output += caesar(ch, key);
            }
            return output;
        }

        private void buttonkonversi_Click(object sender, EventArgs e)
        {
            labeloutput.Text = encaesar(textBoxkalimat.Text.ToUpper(), textBoxfirst.Text.ToUpper(), textBoxsecond.Text.ToUpper());
        }
    }
}
