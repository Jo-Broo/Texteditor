using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texteditor.NET
{
    public class CaesarEncryption : IEncryption
    {
        public const int STANDARD_ROTATION = 13;
        public const int MIN_ROTATION = 1;
        public const int MAX_ROTATION = 25;
        public const int MAX_TEXTLAENGE = 250;

        private static void Textlaenge_pruefen(string Text)
        {
            if (Text == null || Text == "")
            {
                throw new ArgumentException("Input was empty");
            }
            else if (Text.Length > MAX_TEXTLAENGE)
            {
                /// Die maximale Länge des Textes hab ich erstmal ausgeschaltet

                //throw new ArgumentException($"Input was to long");
            }
        }

        /// <summary>
        /// Decrypts the given chiffre depending on the first argument reperesenting the rotation
        /// </summary>
        /// <param name="chiffre">text chiffre</param>
        /// <param name="args">first value represents the rotation</param>
        /// <returns></returns>
        public string Decrpyt(string chiffre, params int[] args)
        {
            Textlaenge_pruefen(chiffre);
            int rotation = args[0];

            StringBuilder Klartext = new StringBuilder();

            foreach (char c in chiffre)
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

        /// <summary>
        /// encrypts the given text depeding on the rotation
        /// </summary>
        /// <param name="text">clear text</param>
        /// <param name="args">first value represents the rotation</param>
        /// <returns></returns>
        public string Encrypt(string text, params int[] args)
        {
            Textlaenge_pruefen(text);
            int rotation = args[0];

            StringBuilder Chiffre = new StringBuilder();

            foreach (char c in text)
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
    }
}