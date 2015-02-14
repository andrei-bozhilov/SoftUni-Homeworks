using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using SoftUniHomework.Attributes;
using SoftUniHomework.Core;
using SoftUniHomework.Extensions;

namespace SoftUniHomework.Forms
{
    public partial class MainForm : Form
    {
        private ReflectionReader reader;
        private IEnumerable<string> nameSpaceFilter;
        private IEnumerable<string> methodNameExcluded;

        public MainForm()
        {
            InitializeComponent();
            this.descriptionTextBox.ScrollBars = ScrollBars.Vertical;

            foreach (Control control in this.Controls)
            {
                control.MouseEnter += control_MouseEnter;
            }

            nameSpaceFilter = new string[] { "SoftUniHomework.Curses" };
            methodNameExcluded = new string[] { "ToString", "GetHashCode", "Equals", "GetType" };

            reader = new ReflectionReader(nameSpaceFilter, methodNameExcluded);

            this.classComboBox.Items
                .AddRange(reader.AssemblyClassesMethodsNames.Keys
                .OrderBy(x => x)
                .Select(x => x.Name)
                .ToArray());
        }

        private void control_MouseEnter(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            if (control.CanFocus)
            {
                if (!control.Focused)
                {
                    control.Focus();
                    var textbox = control as TextBoxBase;

                    if (textbox != null)
                    {
                        textbox.DeselectAll();
                    }
                }
            }
        }


        private void classComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string currentClass = this.classComboBox.Text;
            var key =
                reader.AssemblyClassesMethodsNames.Keys.Where(x => x.Name == currentClass).First();
            this.methodComboBox.Items.Clear();
            this.methodComboBox.Items
                .AddRange(reader.AssemblyClassesMethodsNames[key].Select(x => x.Name).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var className = this.classComboBox.Text;
            var methodName = this.methodComboBox.Text;
            if (string.IsNullOrWhiteSpace(className) || string.IsNullOrWhiteSpace(methodName))
            {
                MessageBox.Show("Please select class and method.");
            }
            else
            {
                try
                {
                    var parameters =
                        this.inputRichTextBox.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    this.outputRichTextBox.Text = reader.ExcuteMethod(className, methodName, parameters);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + "\n" + ex.InnerException.Message);
                }

            }
        }

        private void methodComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var className = this.classComboBox.Text;
            var methodName = this.methodComboBox.Text;
            TaskDescriptionAttribute attributeInfo =
                this.reader.GetAttributeInfoForMethod(className, methodName);

            this.descriptionTextBox.Text = attributeInfo.TaskDescription;
            this.sourceCodeRichTextBox.ResetText();
            this.sourceCodeRichTextBox.AppendTextFormat(attributeInfo.SourceCode);
        }
    }
}
