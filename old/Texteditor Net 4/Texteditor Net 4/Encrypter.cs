using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texteditor.NET
{
    public interface IEncryption
    {
        string Encrypt(string text, params int[] args);
        string Decrpyt(string chiffre, params int[] args);
    }


    public class Encrypter
    {
        private IEncryption strategy;

        public Encrypter()
        {
            this.strategy = new CaesarEncryption();
        }

        public string Decrpyt(string chiffre, params int[] args)
        {
            if(this.strategy == null) { throw new InvalidOperationException("The Encrypter has no startegy set"); }
            return this.strategy.Decrpyt(chiffre, args);
        }

        public string Encrypt(string text, params int[] args)
        {
            if (this.strategy == null) { throw new InvalidOperationException("The Encrypter has no startegy set"); }
            return this.strategy.Encrypt(text, args);
        }

        public void SetStrategy(IEncryption strategy)
        {
            this.strategy = strategy;
        }

    }


}
