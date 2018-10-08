namespace UnitsConverter.Utils
{
    struct ParseInput
    {
        public string Value;
        public string Prefix;
        public string Unit;
        public string Error;
    }

    struct ParseOutput
    {
        public string Prefix;
        public string Unit;
        public string Error;
    }

    public struct ConvertResult
    {
        public string Error;
        public string Value;
    }
}
