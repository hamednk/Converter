using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConvertCapitalCaseProperties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            var inputText = RchTxt_FromText.Text;
            var outputText = FormatTextPropertiy(inputText);
            RchTxt_ToText.Text = outputText;
        }

        private string FormatTextPropertiy(string data) //data: public string firstName { get; set; }
        {
            var rejectCase = new List<string> {
                "int", "string", "long", "decimal",
                "float", "char", "bool", "double",
                "byte", "int?", "string?", "long?",
                "decimal?", "float?", "char?", "bool?",
                "double?", "byte?", "public", "private",
                "{", "}\n", "}", "get;", "set;","class"
            };

            var words = data.Split(new[] { "_", " " }, StringSplitOptions.RemoveEmptyEntries);

            words = words
              .Select(word => !rejectCase.Contains(word) ? char.ToUpper(word[0]) + word.Substring(1) : word)
                  .ToArray();

            return string.Join(" ", words);// output: public string FirstName { get; set; }
    }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
