using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texteditor.NET
{
    public static class CaesarEncryption
    {
        public const int STANDARD_ROTATION = 13;
        public const int MIN_ROTATION = 1;
        public const int MAX_ROTATION = 25;
        public const int MAX_TEXTLAENGE = 250;

        public static string Entschlüsseln(string input, int rotation)
        {
            Textlaenge_pruefen(input);

            StringBuilder Klartext = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if ("äöüÄÖÜ".Contains(c))
                    {
                        Klartext.Append(c);
                        continue;
                    }
                    char first = (char.IsUpper(c)) ? 'A' : 'a';
                    char new_char = (char)(c - rotation);
                    if (new_char < first)
                    {
                        new_char = (char)(new_char + 26);
                    }
                    Klartext.Append(new_char);
                }
                else
                {
                    Klartext.Append(c);
                }
            }

            return Klartext.ToString();
        }

        public static string Verschlüsseln(string input, int rotation)
        {
            Textlaenge_pruefen(input);

            StringBuilder Chiffre = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if ("äöüÄÖÜ".Contains(c))
                    {
                        Chiffre.Append(c);
                        continue;
                    }
                    char last = (char.IsUpper(c)) ? 'Z' : 'z';
                    char new_char = (char)(c + rotation);
                    if (new_char > last)
                    {
                        new_char = (char)(new_char - 26);
                    }
                    Chiffre.Append(new_char);
                }
                else
                {
                    Chiffre.Append(c);
                }
            }

            return Chiffre.ToString();
        }

        private static void Textlaenge_pruefen(string Text)
        {
            if (Text == null || Text == "")
            {
                throw new ArgumentException("Input was empty", "Text");
            }
            else if (Text.Length > MAX_TEXTLAENGE)
            {
                throw new ArgumentException($"Input was to long", "Text");
            }
        }
    }
}