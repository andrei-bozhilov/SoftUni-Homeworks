using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftUniHomework.Extensions
{
    public static class RichTextBoxExtensions
    {
        private static readonly string[] SpecialWords = 
        { "new", "class", "public", "return", "private", "static", "void", 
            "if", "break", "switch", "for", "int", "string", "long", "small",
            "bool", "byte", "uint", "ulong", "decimal", "float", "double", "var", "throw" , "else"
        };

        private static readonly string[] Bools = { "true", "false", "true;", "false;" };

        public static void AppendTextFormat(this RichTextBox box, string text)
        {
            string[] rowData = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            int rowNumber = 0;

            for (int k = 0; k < rowData.Length; k++)
            {
                box.SelectionStart = box.TextLength;
                box.SelectionColor = Color.Orange;

                box.AppendText(++rowNumber + ".   ");
                box.SelectionColor = box.ForeColor;


                string[] words =
                    rowData[k].Split();

                for (int i = 0; i < words.Length; i++)
                {
                    if (SpecialWords.Contains(words[i]))
                    {
                        box.SelectionStart = box.TextLength;
                        box.SelectionColor = Color.GreenYellow;

                        box.AppendText(words[i]);
                        box.AppendText(" ");
                        box.SelectionColor = box.ForeColor;
                    }
                    else if (Bools.Contains(words[i]))
                    {
                        box.SelectionStart = box.TextLength;
                        box.SelectionColor = Color.Red;
                        box.SelectionFont = new Font(box.Font.FontFamily, box.Font.Size, FontStyle.Italic);

                        box.AppendText(words[i]);
                        box.AppendText(" ");
                        box.SelectionFont = new Font(box.Font.FontFamily, box.Font.Size, FontStyle.Regular);
                        box.SelectionColor = box.ForeColor;

                    }
                    else
                    {
                        box.AppendText(words[i]);
                        box.AppendText(" ");
                    }

                    if (i == words.Length - 1)
                    {
                        box.AppendText("\r\n");
                    }
                }
            }
        }
    }
}
