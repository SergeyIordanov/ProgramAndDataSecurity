using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataSecurity1.NotepadMethod.Properties;
using DataSecurity1.NotepadMethod.Support;

namespace DataSecurity1.NotepadMethod
{
    public partial class MainForm : Form
    {
        private const string AlphRus = "абвгдежзийклмнопрстуфхцчшыьэюящ ";
        private const string DefaultKeyRus = "окрошка";
        private const string AlphEng = "abcdefghijklmnopqrstuvwxyz .,!?'";
        private const string DefaultKeyEng = "steak";

        public MainForm()
        {
            InitializeComponent();
            alphComboBox.SelectedIndex = 0;
            methodComboBox.SelectedIndex = 0;

            keyTextBox.Text = DefaultKeyEng;
            alphTextBox.Text = AlphEng;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (keyTextBox.Text == string.Empty)
            {
                MessageBox.Show(
                    Resources.MainForm_EncryptButton_Click_Key_cannot_be_empty_, 
                    Resources.MainForm_EncryptButton_Click_Enter_key, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
            else
            {
                Encrypt(
                    alphComboBox.SelectedIndex == 0 ? AlphEng : AlphRus,
                    keyTextBox.Text,
                    methodComboBox.SelectedIndex == 1);
            }
        }

        private void Encrypt(string alph, string key, bool useXor = false)
        {
            string text = inputText.Text;
            var encryptor = new VerrnamEncryptor(alph);

            try
            {
                if (useXor)
                {
                    resultEncText.Text = encryptor.Crypt_XOR(text, key);
                    resultDecText.Text = encryptor.Crypt_XOR(resultEncText.Text, key);
                }
                else
                {
                    resultEncText.Text = encryptor.Crypt(text, key, false);
                    resultDecText.Text = encryptor.Crypt(resultEncText.Text, key, true);
                }
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show(
                    Resources.MainForm_Encrypt_Key_contains_wrong_letters,
                    Resources.MainForm_Encrypt_Wrong_key,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void alphComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (alphComboBox.SelectedIndex == 0)
            {
                keyTextBox.Text = DefaultKeyEng;
                alphTextBox.Text = AlphEng;
            }
            else
            {
                keyTextBox.Text = DefaultKeyRus;
                alphTextBox.Text = AlphRus;
            }
        }
    }
}