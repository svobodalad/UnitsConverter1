namespace UnitsConverter.Utils
{
    /// <summary>
    /// Structure from parsed input params
    /// </summary>
    struct ParseInput
    {
        public string Value;
        public string Prefix;
        public string Unit;
        public string Error;
    }

    /// <summary>
    /// Structure from parsed required output params
    /// </summary>
    struct ParseOutput
    {
        public string Prefix;
        public string Unit;
        public string Error;
    }

    /// <summary>
    /// Structure for parsing input and output parameters
    /// </summary>
    struct ParseAllParams
    {
        public string InputValue;
        public string InputPrefix;
        public string InputUnit;
        public string OutputPrefix;
        public string OutputUnit;
        public string Error;
    }


    /// <summary>
    /// Result from conversion.
    /// Due to versatility is result Value always 'string'
    /// The "Error" member contains errors from each of steps of conversion(parsing, converting, invalid params, empty params..)
    /// </summary>
    public struct ConvertResult
    {
        public string Error;
        public string Value;
    }
}
