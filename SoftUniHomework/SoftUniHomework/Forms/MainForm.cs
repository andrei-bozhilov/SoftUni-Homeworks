using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftUniHomework.Core;

namespace SoftUniHomework.Forms
{
    public partial class MainForm : Form
    {
        private ReflectionReader reader;

        public MainForm()
        {
            InitializeComponent();
            reader = new ReflectionReader();

            this.classComboBox.Items.AddRange(reader.GetAllClassesNames().ToArray());
        }

        private void classComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string currentClass = this.classComboBox.Text;
            this.methodComboBox.Items.Clear();
            this.methodComboBox.Items                
                .AddRange(reader.GetAllMethodsNames(currentClass)
                .ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var className = this.classComboBox.Text;
            var methodName = this.methodComboBox.Text;
            this.descriptionTextBox.Text = reader.ExcuteMethod(className, methodName);
        }
    }
}
