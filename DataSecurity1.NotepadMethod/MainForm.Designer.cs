namespace DataSecurity1.NotepadMethod
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
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.resultEncText = new System.Windows.Forms.RichTextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.alphComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.alphTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resultDecText = new System.Windows.Forms.RichTextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(16, 25);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(378, 74);
            this.inputText.TabIndex = 0;
            this.inputText.Text = "";
            // 
            // resultEncText
            // 
            this.resultEncText.Location = new System.Drawing.Point(16, 120);
            this.resultEncText.Name = "resultEncText";
            this.resultEncText.ReadOnly = true;
            this.resultEncText.Size = new System.Drawing.Size(184, 106);
            this.resultEncText.TabIndex = 1;
            this.resultEncText.Text = "";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(403, 188);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(218, 38);
            this.EncryptButton.TabIndex = 2;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Encrypted";
            // 
            // alphComboBox
            // 
            this.alphComboBox.FormattingEnabled = true;
            this.alphComboBox.Items.AddRange(new object[] {
            "English alphabet",
            "Russian alphabet"});
            this.alphComboBox.Location = new System.Drawing.Point(484, 25);
            this.alphComboBox.Name = "alphComboBox";
            this.alphComboBox.Size = new System.Drawing.Size(134, 21);
            this.alphComboBox.TabIndex = 6;
            this.alphComboBox.SelectedIndexChanged += new System.EventHandler(this.alphComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select alphabet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select method";
            // 
            // methodComboBox
            // 
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.Items.AddRange(new object[] {
            "No XOR",
            "Use XOR"});
            this.methodComboBox.Location = new System.Drawing.Point(484, 52);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(134, 21);
            this.methodComboBox.TabIndex = 9;
            // 
            // alphTextBox
            // 
            this.alphTextBox.Location = new System.Drawing.Point(403, 136);
            this.alphTextBox.Name = "alphTextBox";
            this.alphTextBox.ReadOnly = true;
            this.alphTextBox.Size = new System.Drawing.Size(218, 46);
            this.alphTextBox.TabIndex = 11;
            this.alphTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Alphabet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Decrypted";
            // 
            // resultDecText
            // 
            this.resultDecText.Location = new System.Drawing.Point(210, 120);
            this.resultDecText.Name = "resultDecText";
            this.resultDecText.ReadOnly = true;
            this.resultDecText.Size = new System.Drawing.Size(184, 106);
            this.resultDecText.TabIndex = 13;
            this.resultDecText.Text = "";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(434, 79);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(184, 20);
            this.keyTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Key:";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(628, 237);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultDecText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.alphTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.methodComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alphComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.resultEncText);
            this.Controls.Add(this.inputText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputText;
        private System.Windows.Forms.RichTextBox resultEncText;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox alphComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox methodComboBox;
        private System.Windows.Forms.RichTextBox alphTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox resultDecText;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label7;
    }
}

