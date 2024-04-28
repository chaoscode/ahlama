namespace ahlama
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
            OutputBox = new RichTextBox();
            InputBox = new RichTextBox();
            SendButton = new Button();
            ModelListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            configToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // OutputBox
            // 
            OutputBox.Location = new Point(12, 67);
            OutputBox.Name = "OutputBox";
            OutputBox.Size = new Size(1405, 879);
            OutputBox.TabIndex = 0;
            OutputBox.Text = "";
            // 
            // InputBox
            // 
            InputBox.Location = new Point(12, 948);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(1807, 40);
            InputBox.TabIndex = 1;
            InputBox.Text = "";
            InputBox.KeyDown += InputBox_KeyDown;
            InputBox.KeyPress += InputBox_KeyPress;
            // 
            // SendButton
            // 
            SendButton.Location = new Point(12, 994);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(112, 34);
            SendButton.TabIndex = 2;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // ModelListBox
            // 
            ModelListBox.FormattingEnabled = true;
            ModelListBox.ItemHeight = 25;
            ModelListBox.Location = new Point(1412, 67);
            ModelListBox.Name = "ModelListBox";
            ModelListBox.Size = new Size(407, 879);
            ModelListBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 40);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 4;
            label1.Text = "Chat Bot Output";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1425, 39);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 5;
            label2.Text = "Installed Models";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, configToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1966, 33);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 34);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // configToolStripMenuItem
            // 
            configToolStripMenuItem.Name = "configToolStripMenuItem";
            configToolStripMenuItem.Size = new Size(81, 29);
            configToolStripMenuItem.Text = "Config";
            configToolStripMenuItem.Click += configToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1966, 1081);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ModelListBox);
            Controls.Add(SendButton);
            Controls.Add(InputBox);
            Controls.Add(OutputBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "ahlama";
            Activated += Form1_Activated;
            Load += Form1_Load;
            Shown += Form1_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox OutputBox;
        private RichTextBox InputBox;
        private Button SendButton;
        private ListBox ModelListBox;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem configToolStripMenuItem;
    }
}
