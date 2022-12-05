using System;
using System.IO;
using System.Text.Json;
using WpfRandomizer.Models;

namespace WpfRandomizer.Services;

public static class FileService
{
    public static void CreateConfig(string path, string? config = null)
    {
        if (String.IsNullOrEmpty(config))
        {
            config = JsonSerializer.Serialize(new OptionModel
            {
                NumberedOutput = true,
                Separation = OptionModel.SeparationOptions.Comma
            });
        }
        File.WriteAllText(path,config);
    }
}