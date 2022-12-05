using System;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using WpfRandomizer.Models;
using WpfRandomizer.Services;

namespace WpfRandomizer;

public partial class Settings : Window
{
    private int _checked;
    public Settings(OptionModel model)
    {
        Uri iconUri = new Uri("pack://application:,,,/Assets/favicon.ico", UriKind.RelativeOrAbsolute); 
        Icon = BitmapFrame.Create(iconUri);
        InitializeComponent();
        switch (model.Separation)
        {
            case OptionModel.SeparationOptions.Enter:
                EnterRadio.IsChecked = true;
                CommaRadio.IsChecked = false;
                NumberRadio.IsChecked = false;
                break;
            case OptionModel.SeparationOptions.Comma:
                EnterRadio.IsChecked = false;
                CommaRadio.IsChecked = true;
                NumberRadio.IsChecked = false;
                break;
            case OptionModel.SeparationOptions.NumberedList:
                EnterRadio.IsChecked = false;
                CommaRadio.IsChecked = false;
                NumberRadio.IsChecked = true;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        NumberedCheckBox.IsChecked = model.NumberedOutput;
    }
    
    private void BtnSave_OnClick(object sender, RoutedEventArgs e)
    {
        var model = new OptionModel
        {
            Separation = (OptionModel.SeparationOptions)_checked,
            NumberedOutput = NumberedCheckBox.IsChecked ?? false
        };
        var json = JsonSerializer.Serialize(model);
        try
        {
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (!File.Exists(Path.Combine(documents,"RandomizerConfig","randomizeOptions.json")))
            {
                Directory.CreateDirectory(Path.Combine(documents, "RandomizerConfig"));
            }
            FileService.CreateConfig(Path.Combine(documents,"RandomizerConfig","randomizeOptions.json"),json);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }
        finally
        {
            MessageBox.Show("Settings saved!");
            Close();
        }
    }

    private void Option_OnChecked(object sender, RoutedEventArgs e)
    {
        var rb = sender as RadioButton;
        if (rb is { IsChecked: { } } && rb.IsChecked.Value)
        {
            var content = rb.Content.ToString();
            switch (content)
            {
                case "New line":
                    _checked = 10;
                    break;
                case "Comma":
                    _checked = 20;
                    break;
                case "Number":
                    _checked = 30;
                    break;
                default:
                    MessageBox.Show(
                        "There were some errors please. Close and reopen the app. If problem keeps going on consider contacting developer :)");
                    break;
            }
        }
    }
}