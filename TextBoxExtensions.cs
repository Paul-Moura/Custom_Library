using System.Windows.Forms;

namespace Custom
{
	public static class TextBoxExtensions
	{
		public static void CursorToFront(this TextBox textBox)
		{
			textBox.Select(0, 0);
		}

		public static void CursorToBack(this TextBox textBox)
		{
			textBox.Select(textBox.TextLength, 0);
		}
	}
}
