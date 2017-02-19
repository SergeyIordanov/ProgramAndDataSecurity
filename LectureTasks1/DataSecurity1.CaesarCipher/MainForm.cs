using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataSecurity1.CaesarCipher.Properties;
using DataSecurity1.CaesarCipher.Support;

namespace DataSecurity1.CaesarCipher
{
    public partial class MainForm : Form
    {
        private const string AlphRus = "абвгдежзийклмнопрстуфхцчшыьэюящ .,!?'";
        private const int DefaultShift = 1;
        private const string AlphEng = "abcdefghijklmnopqrstuvwxyz .,!?'";

        public MainForm()
        {
            InitializeComponent();
            alphComboBox.SelectedIndex = 0;
            shiftNumericUpDown.Value = DefaultShift;

            alphTextBox.Text = AlphEng;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            Encrypt(
                alphComboBox.SelectedIndex == 0 ? AlphEng : AlphRus,
                (int)shiftNumericUpDown.Value);
        }

        private void Encrypt(string alph, int shift)
        {
            string text = inputText.Text;
            var encryptor = new CaesarEncryptor(alph, shift);

            try
            {
                resultEncText.Text = encryptor.Encrypt(text);
                resultDecText.Text = encryptor.Decrypt(resultEncText.Text);
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show(
                    Resources.MainForm_Encrypt_Some_letters_aren_t_from_the_current_alphabet,
                    Resources.MainForm_Encrypt_Wrong_text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void alphComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alphTextBox.Text = alphComboBox.SelectedIndex == 0 ? AlphEng : AlphRus;
            enAlphTextBox.Text = CaesarEncryptor.GetEncryptedAlph(alphTextBox.Text, (int)shiftNumericUpDown.Value);
        }

        private void shiftNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            enAlphTextBox.Text = CaesarEncryptor.GetEncryptedAlph(alphTextBox.Text, (int)shiftNumericUpDown.Value);
        }
    }
}