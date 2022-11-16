namespace WpfRandomizer.Models;

public class OptionModel
{
    public enum SeparationOptions
    {
        Enter = 10,
        Comma = 20,
        NumberedList = 30
    }

    public SeparationOptions Separation { get; set; }
    public bool NumberedOutput { get; set; }

    public override string ToString()
    {
        return $"Separation: {Separation}, Numbered: {NumberedOutput}";
    }
}