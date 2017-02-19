using System.Collections.Generic;
using System.Text;

namespace DataSecurity1.NotepadMethod.Support
{
    public class VerrnamEncryptor
    {
        private readonly Dictionary<char, int> _alph = new Dictionary<char, int>();
        private readonly Dictionary<int, char> _alphR = new Dictionary<int, char>();

        public VerrnamEncryptor(string alph)
        {
            var i = 0;
            foreach (char c in alph)
            {
                _alph.Add(c, i);
                _alphR.Add(i++, c);
            }
        }

        public string Crypt(string text, string key, bool crypt)
        {
            var sb = new StringBuilder();

            for (var i = 0; i < text.Length; i++)
            {
                int idx;
                if (_alph.TryGetValue(text[i], out idx))
                {
                    int r = _alph.Count + idx;
                    r += (crypt ? 1 : -1) * _alph[key[i % key.Length]];
                    sb.Append(_alphR[r % _alph.Count]);
                }
            }

            return sb.ToString();
        }

        public string Crypt_XOR(string text, string key)
        {
            var sb = new StringBuilder();

            for (var i = 0; i < text.Length; i++)
            {
                int ind;
                if (_alph.TryGetValue(text[i], out ind))
                {
                    int encryptedInd = ind ^ _alph[key[i % key.Length]] % _alph.Count;
                    char encryptedChar = _alphR[encryptedInd];
                    sb.Append(encryptedChar);
                }
            }

            return sb.ToString();
        }
    }
}