using System.Text.RegularExpressions;

namespace Texteditor.Extensions
{
    public static partial class TextBoxExtensions
    {
        static Regex SplitWords = regex();

        /// <summary>
        /// Returns a Tuple containing Charcount and Wordcount in that order
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static Tuple<int,int> GetTextInfo(this TextBox textBox)
        {
            string text = textBox.Text.Replace("\r", "").Replace("\n", "");

            return new Tuple<int, int>(text.Length,SplitWords.Split(text).Length);
        }

        [GeneratedRegex(@"[\w-]+")]
        private static partial Regex regex();
    }
}
