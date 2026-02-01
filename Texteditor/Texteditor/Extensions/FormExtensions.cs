namespace Texteditor.Extensions
{
    public static class FormExtensions
    {
        /// <summary>
        /// returns a Point such that the child Form ist centered on the Parent Form
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="child"></param>
        /// <returns></returns>
        public static Point CalculateStartPosition(this Form parent, Form child)
        {
            return new Point((parent.Location.X + (parent.Size.Width / 2)) - (child.Size.Width / 2), (parent.Location.Y + (parent.Size.Height / 2)) - (child.Size.Height / 2));
        }
    }
}
