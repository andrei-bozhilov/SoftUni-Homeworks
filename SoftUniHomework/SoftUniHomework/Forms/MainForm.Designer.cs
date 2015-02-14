namespace SoftUniHomework.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.taskDescriptionLabel = new System.Windows.Forms.Label();
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.executeMethodBtn = new System.Windows.Forms.Button();
            this.sourceCodeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sourceCodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // classComboBox
            // 
            this.classComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(22, 12);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(354, 28);
            this.classComboBox.TabIndex = 0;
            this.classComboBox.SelectedValueChanged += new System.EventHandler(this.classComboBox_SelectedValueChanged);
            // 
            // methodComboBox
            // 
            this.methodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.Location = new System.Drawing.Point(396, 12);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(354, 28);
            this.methodComboBox.TabIndex = 1;
            this.methodComboBox.SelectedValueChanged += new System.EventHandler(this.methodComboBox_SelectedValueChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.AllowDrop = true;
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.HideSelection = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(22, 73);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(728, 94);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // taskDescriptionLabel
            // 
            this.taskDescriptionLabel.AutoSize = true;
            this.taskDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskDescriptionLabel.Location = new System.Drawing.Point(18, 50);
            this.taskDescriptionLabel.Name = "taskDescriptionLabel";
            this.taskDescriptionLabel.Size = new System.Drawing.Size(127, 20);
            this.taskDescriptionLabel.TabIndex = 3;
            this.taskDescriptionLabel.Text = "Task Description";
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputRichTextBox.Location = new System.Drawing.Point(22, 195);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.Size = new System.Drawing.Size(354, 104);
            this.inputRichTextBox.TabIndex = 4;
            this.inputRichTextBox.Text = "";
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.outputRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputRichTextBox.Location = new System.Drawing.Point(22, 325);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.Size = new System.Drawing.Size(354, 151);
            this.outputRichTextBox.TabIndex = 5;
            this.outputRichTextBox.Text = "";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLabel.Location = new System.Drawing.Point(18, 170);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(46, 20);
            this.inputLabel.TabIndex = 6;
            this.inputLabel.Text = "Input";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputLabel.Location = new System.Drawing.Point(18, 302);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(58, 20);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.Text = "Output";
            // 
            // executeMethodBtn
            // 
            this.executeMethodBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.executeMethodBtn.Location = new System.Drawing.Point(396, 44);
            this.executeMethodBtn.Name = "executeMethodBtn";
            this.executeMethodBtn.Size = new System.Drawing.Size(84, 26);
            this.executeMethodBtn.TabIndex = 8;
            this.executeMethodBtn.Text = "Execute";
            this.executeMethodBtn.UseVisualStyleBackColor = true;
            this.executeMethodBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // sourceCodeRichTextBox
            // 
            this.sourceCodeRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceCodeRichTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.sourceCodeRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sourceCodeRichTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.sourceCodeRichTextBox.Location = new System.Drawing.Point(382, 195);
            this.sourceCodeRichTextBox.Name = "sourceCodeRichTextBox";
            this.sourceCodeRichTextBox.Size = new System.Drawing.Size(369, 281);
            this.sourceCodeRichTextBox.TabIndex = 9;
            this.sourceCodeRichTextBox.Text = "";
            // 
            // sourceCodeLabel
            // 
            this.sourceCodeLabel.AutoSize = true;
            this.sourceCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sourceCodeLabel.Location = new System.Drawing.Point(378, 172);
            this.sourceCodeLabel.Name = "sourceCodeLabel";
            this.sourceCodeLabel.Size = new System.Drawing.Size(102, 20);
            this.sourceCodeLabel.TabIndex = 10;
            this.sourceCodeLabel.Text = "Source Code";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(763, 488);
            this.Controls.Add(this.sourceCodeLabel);
            this.Controls.Add(this.sourceCodeRichTextBox);
            this.Controls.Add(this.executeMethodBtn);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.inputRichTextBox);
            this.Controls.Add(this.taskDescriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.methodComboBox);
            this.Controls.Add(this.classComboBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.ComboBox methodComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label taskDescriptionLabel;
        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button executeMethodBtn;
        private System.Windows.Forms.RichTextBox sourceCodeRichTextBox;
        private System.Windows.Forms.Label sourceCodeLabel;
    }
}