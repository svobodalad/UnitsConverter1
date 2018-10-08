namespace UnitsConverter.Interfaces
{
    /// <summary>
    /// The interface declare necessary structure that is use each of converters
    /// </summary>
    public interface ConverterInterface
    {
        /// <summary>
        /// The property tells if an input unit is supported for conversion
        /// </summary>
        bool IsKnownInputUnit { get; }
        /// <summary>
        /// The property tells if an output unit is supported for conversion
        /// </summary>
        bool IsKnownOutputUnit { get; }
        /// <summary>
        /// The method parse input and output parameters
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        void ParseParameters(string input, string output);
        /// <summary>
        ///  The property tells if a conversion of input/output units is supported
        /// </summary>
        bool CanConvert { get; }
        /// <summary>
        /// The property contains an errors of proccessing
        /// </summary>
        string Error { get; }
        /// <summary>
        /// Main method provides conversion function of parsed parrameters
        /// </summary>
        /// <returns></returns>
        string Convert();

    }
}
