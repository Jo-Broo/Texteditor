using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texteditor.NET
{
    class TestAlgorithmus : IEncryption
    {
        public string Decrpyt(string chiffre, params int[] args)
        {
            return "Entschlüsselt";
        }

        public string Encrypt(string text, params int[] args)
        {
            return "Verschlüsselt";
        }
    }
}
