using System.Windows.Controls;
using SautinSoft.Document;
namespace WpfRandomizer;

public static class FileManager
{
    public static void SaveAsDoc(string text)
    {
        var dr = new DocumentCore();
        dr.Content.End.Insert(text);
        dr.Save(@"result.docx");
    }
}