namespace Texteditor.Encryptions.Interfaces
{
    public interface IEncryptionStrategie
    {
        string Encrypt(string text, params int[] args);
        string Decrpyt(string chiffre, params int[] args);
        string GetDisplayName();
    }
}
