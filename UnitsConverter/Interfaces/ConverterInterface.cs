namespace UnitsConverter.Interfaces
{
    public interface ConverterInterface
    {
        bool IsKnownInputUnit { get; }
        bool IsKnownOutputUnit { get; }
        void ParseParameters(string input, string output);
        bool CanConvert { get; }
        string Error { get; }
        string Convert();

    }
}
