using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using WpfRandomizer.Extensions;
using WpfRandomizer.Models;

namespace WpfRandomizer
{
    /// <summary>
    /// Interaction logic for ListRandomizer.xaml
    /// </summary>
    public partial class ListRandomizer
    {
        private OptionModel Model
        {
            get
            {
                using (var reader = new StreamReader(Path.Combine(Environment.CurrentDirectory,"Config","randomizeOptions.json")))
                {
                    string json = reader.ReadToEnd();
                    var deserialized = JsonSerializer.Deserialize<OptionModel>(json);
                    if (deserialized != null)
                    {
                        return deserialized;
                    }
                }

                return new OptionModel
                {
                    Separation = OptionModel.SeparationOptions.Comma,
                    NumberedOutput = true
                };
            }
        }

        public ListRandomizer()
        {

            Uri iconUri = new Uri("pack://application:,,,/Assets/favicon.ico", UriKind.RelativeOrAbsolute); 
            Icon = BitmapFrame.Create(iconUri);
            InitializeComponent();
        }
        
        private void BtnRandomize_OnClick(object sender, RoutedEventArgs e)
        {
            var input = InputBox.GetTextFromRichTextBox();

            List<string> list;
            switch (Model.Separation)
            {
                case OptionModel.SeparationOptions.Enter:
                    list = input.Split('\n', StringSplitOptions.RemoveEmptyEntries).ToList(); 
                    break;
                case OptionModel.SeparationOptions.Comma:
                    list = input.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();
                    break;
                case OptionModel.SeparationOptions.NumberedList:
                    var inputAsList = input.Split('\n').ToList();
                    list = inputAsList.Where(
                        s => !String.IsNullOrWhiteSpace(s) && !String.IsNullOrEmpty(s)).Select(
                        s => s.Split(')')[1]).ToList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var rnd = new Random();
            var result =  list.OrderBy(_ => rnd.Next());
            OutputBox.Document.Blocks.Clear();
            switch (Model.NumberedOutput)
            {
                case true:
                    var i = 1;
                    foreach (var elem in result)
                    {
                        OutputBox.Document.Blocks.Add(new Paragraph(new Run($"{i}) {elem}")));
                        i++;
                    }       
                    break;
                case false:
                    foreach (var elem in result)
                    {
                        OutputBox.Document.Blocks.Add(new Paragraph(new Run($"{elem}")));
                    }
                    break;
            }
        }

        private void BtnSettings_OnClick(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings(Model);
            settings.Show();
        }

        private void BtnReset_OnClick(object sender, RoutedEventArgs e)
        {
            InputBox.Document.Blocks.Clear();
            OutputBox.Document.Blocks.Clear();
            MessageBox.Show("Cleared!");
        }

        private void BtnSaveDoc_OnClick(object sender, RoutedEventArgs e)
        {
            FileManager.SaveAsDoc(OutputBox.GetTextFromRichTextBox());
        }
    }
}