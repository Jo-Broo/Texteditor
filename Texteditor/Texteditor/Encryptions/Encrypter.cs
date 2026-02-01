using Texteditor.Encryptions.Interfaces;

namespace Texteditor.Encryptions
{
    public class Encrypter
    {
        public List<Tuple<IEncryptionStrategie, Form>> Strategies { get; set; } = new();

        private IEncryptionStrategie? _strategy;

        public string Decrypt(string chiffre, params int[] args)
        {
            if (this._strategy == null) { throw new InvalidOperationException("The Encrypter has no startegy set"); }
            return this._strategy.Decrpyt(chiffre, args);
        }

        public string Encrypt(string text, params int[] args)
        {
            if (this._strategy == null) { throw new InvalidOperationException("The Encrypter has no startegy set"); }
            return this._strategy.Encrypt(text, args);
        }

        public void SetStrategy(IEncryptionStrategie strategy)
        {
            this._strategy = strategy;
        }
    }
}
