// Adapted from:
// https://msdn.microsoft.com/en-us/library/kz40084e%28v=vs.110%29.aspx
using System;
using System.Windows.Forms;

class Unformat
{
	[STAThreadAttribute]
	static public void Main()
	{
		try
		{
			StripClipFormatting();
		} catch (Exception) { }
	}

	static public void StripClipFormatting()
	{
		String text = Clipboard.GetText(TextDataFormat.Text);
		Clipboard.SetText(text, TextDataFormat.Text);
	}
}
