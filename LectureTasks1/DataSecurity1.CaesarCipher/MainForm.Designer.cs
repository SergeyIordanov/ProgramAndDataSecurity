namespace DataSecurity1.CaesarCipher
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
            this.alphTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resultDecText = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.shiftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.enAlphTextBox = new System.Windows.Forms.RichTextBox();
            this.cryptanalysisButton = new System.Windows.Forms.Button();
            this.cryptanalysisResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hideLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.shiftNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(16, 25);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(378, 122);
            this.inputText.TabIndex = 0;
            this.inputText.Text = "";
            // 
            // resultEncText
            // 
            this.resultEncText.Location = new System.Drawing.Point(16, 170);
            this.resultEncText.Name = "resultEncText";
            this.resultEncText.ReadOnly = true;
            this.resultEncText.Size = new System.Drawing.Size(184, 55);
            this.resultEncText.TabIndex = 1;
            this.resultEncText.Text = "";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(400, 222);
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
            this.label1.Location = new System.Drawing.Point(13, 154);
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
            // alphTextBox
            // 
            this.alphTextBox.Location = new System.Drawing.Point(400, 101);
            this.alphTextBox.Name = "alphTextBox";
            this.alphTextBox.ReadOnly = true;
            this.alphTextBox.Size = new System.Drawing.Size(218, 46);
            this.alphTextBox.TabIndex = 11;
            this.alphTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Alphabet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Decrypted";
            // 
            // resultDecText
            // 
            this.resultDecText.Location = new System.Drawing.Point(210, 170);
            this.resultDecText.Name = "resultDecText";
            this.resultDecText.ReadOnly = true;
            this.resultDecText.Size = new System.Drawing.Size(184, 90);
            this.resultDecText.TabIndex = 13;
            this.resultDecText.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Shift (1 - 20):";
            // 
            // shiftNumericUpDown
            // 
            this.shiftNumericUpDown.Location = new System.Drawing.Point(484, 52);
            this.shiftNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.shiftNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shiftNumericUpDown.Name = "shiftNumericUpDown";
            this.shiftNumericUpDown.Size = new System.Drawing.Size(134, 20);
            this.shiftNumericUpDown.TabIndex = 17;
            this.shiftNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shiftNumericUpDown.ValueChanged += new System.EventHandler(this.shiftNumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Encrypted alphabet";
            // 
            // enAlphTextBox
            // 
            this.enAlphTextBox.Location = new System.Drawing.Point(400, 170);
            this.enAlphTextBox.Name = "enAlphTextBox";
            this.enAlphTextBox.ReadOnly = true;
            this.enAlphTextBox.Size = new System.Drawing.Size(218, 46);
            this.enAlphTextBox.TabIndex = 18;
            this.enAlphTextBox.Text = "";
            // 
            // cryptanalysisButton
            // 
            this.cryptanalysisButton.Location = new System.Drawing.Point(16, 231);
            this.cryptanalysisButton.Name = "cryptanalysisButton";
            this.cryptanalysisButton.Size = new System.Drawing.Size(184, 29);
            this.cryptanalysisButton.TabIndex = 20;
            this.cryptanalysisButton.Text = "Cryptanalysis";
            this.cryptanalysisButton.UseVisualStyleBackColor = true;
            this.cryptanalysisButton.Click += new System.EventHandler(this.cryptanalysisButton_Click);
            // 
            // cryptanalysisResultRichTextBox
            // 
            this.cryptanalysisResultRichTextBox.Location = new System.Drawing.Point(145, 289);
            this.cryptanalysisResultRichTextBox.Name = "cryptanalysisResultRichTextBox";
            this.cryptanalysisResultRichTextBox.ReadOnly = true;
            this.cryptanalysisResultRichTextBox.Size = new System.Drawing.Size(333, 115);
            this.cryptanalysisResultRichTextBox.TabIndex = 21;
            this.cryptanalysisResultRichTextBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Cryptanalysis result";
            // 
            // hideLinkLabel
            // 
            this.hideLinkLabel.AutoSize = true;
            this.hideLinkLabel.Location = new System.Drawing.Point(354, 268);
            this.hideLinkLabel.Name = "hideLinkLabel";
            this.hideLinkLabel.Size = new System.Drawing.Size(27, 13);
            this.hideLinkLabel.TabIndex = 23;
            this.hideLinkLabel.TabStop = true;
            this.hideLinkLabel.Text = "hide";
            this.hideLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hideLinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(628, 269);
            this.Controls.Add(this.hideLinkLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cryptanalysisResultRichTextBox);
            this.Controls.Add(this.cryptanalysisButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enAlphTextBox);
            this.Controls.Add(this.shiftNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultDecText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.alphTextBox);
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
            this.Text = "Caesar encryptor";
            ((System.ComponentModel.ISupportInitialize)(this.shiftNumericUpDown)).EndInit();
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
        private System.Windows.Forms.RichTextBox alphTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox resultDecText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown shiftNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox enAlphTextBox;
        private System.Windows.Forms.Button cryptanalysisButton;
        private System.Windows.Forms.RichTextBox cryptanalysisResultRichTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel hideLinkLabel;
    }
}

