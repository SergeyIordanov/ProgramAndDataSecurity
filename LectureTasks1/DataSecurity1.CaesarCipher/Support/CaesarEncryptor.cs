using System.Collections.Generic;
using System.Text;

namespace DataSecurity1.CaesarCipher.Support
{
    public class CaesarEncryptor
    {
        private readonly Dictionary<char, int> _originalAlph = new Dictionary<char, int>();
        private readonly Dictionary<int, char> _originalAlphR = new Dictionary<int, char>();


        private readonly Dictionary<char, int> _encryptedAlph = new Dictionary<char, int>();
        private readonly Dictionary<int, char> _encryptedAlphR = new Dictionary<int, char>();
        public CaesarEncryptor(string alph, int shift)
        {
            var i = 0;
            foreach (char c in alph)
            {
                _originalAlph.Add(c, i);
                _originalAlphR.Add(i, c);

                _encryptedAlph.Add(alph[(i + shift) % alph.Length], i);
                _encryptedAlphR.Add(i, alph[(i + shift) % alph.Length]);

                i++;
            }
        }

        public string Encrypt(string text)
        {
            var sb = new StringBuilder();

            foreach (char ch in text)
            {
                int idx;
                if (_originalAlph.TryGetValue(ch, out idx))
                {
                    sb.Append(_encryptedAlphR[idx]);
                }
                else
                {
                    throw new KeyNotFoundException();
                }
            }

            return sb.ToString();
        }

        public string Decrypt(string text)
        {
            var sb = new StringBuilder();

            foreach (char ch in text)
            {
                int idx;
                if (_encryptedAlph.TryGetValue(ch, out idx))
                {
                    sb.Append(_originalAlphR[idx]);
                }
                else
                {
                    throw new KeyNotFoundException();
                }
            }

            return sb.ToString();
        }

        public static string GetEncryptedAlph(string alph, int shift)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < alph.Length; i++)
            {
                sb.Append(alph[(i + shift) % alph.Length]);
            }

            return sb.ToString();
        }
    }
}