namespace MyAttrib
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            heroListBox = new ListBox();
            skillListBox = new ListBox();
            SuspendLayout();
            // 
            // heroListBox
            // 
            heroListBox.FormattingEnabled = true;
            heroListBox.ItemHeight = 17;
            heroListBox.Location = new Point(27, 49);
            heroListBox.Name = "heroListBox";
            heroListBox.Size = new Size(265, 191);
            heroListBox.TabIndex = 0;
            heroListBox.SelectedIndexChanged += heroListBox_SelectedIndexChanged;
            // 
            // skillListBox
            // 
            skillListBox.FormattingEnabled = true;
            skillListBox.ItemHeight = 17;
            skillListBox.Location = new Point(335, 49);
            skillListBox.Name = "skillListBox";
            skillListBox.Size = new Size(265, 191);
            skillListBox.TabIndex = 0;
            skillListBox.DoubleClick += skillListBox_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(skillListBox);
            Controls.Add(heroListBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox heroListBox;
        private ListBox skillListBox;
    }
}
