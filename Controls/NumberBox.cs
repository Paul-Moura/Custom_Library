using System;
using System.Windows.Forms;

namespace Custom.Controls
{
	public class NumberBox : TextBox
	{
		protected override void OnTextChanged(EventArgs e)
		{
			int n;
			int.TryParse(Text, out n);
			//FJT.ConsumablesQuantity.Cleaner = n;
			//txtCleaner.Text = FJT.ConsumablesQuantity.Cleaner.ToString(CultureInfo.InvariantCulture);
			//txtCleaner.CursorToBack();
			base.OnTextChanged(e);
		}
	}
}
