using System.Windows.Controls;
using System.Windows.Documents;

namespace WpfRandomizer.Extensions;

public static class Extension
{
    public static string GetTextFromRichTextBox(this RichTextBox rtb)
    {
        TextRange range = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
        return range.Text;
    }
    
}