using System;
using System.Collections.Generic;
using System.Linq;
using UnitsConverter.Interfaces;
using UnitsConverter.Utils;

namespace UnitsConverter.Convertors
{
    /// <summary>
    /// Class for convert Units of data, supported units: "bytes", "byte", "bits", "bit"
    /// </summary>
    class BytesAndBitsUnits : ConverterInterface
    {
        private string[] supportedUnits = new string[4] { "bytes", "byte", "bits", "bit"};
        private ParseAllParams parseAllParams;
        private Dictionary<string, decimal> convertConstants;

        /// <summary>
        /// The property tells if the class supports conversion of input/output units
        /// </summary>
        public bool CanConvert => IsKnownInputUnit && IsKnownOutputUnit && string.IsNullOrEmpty(Error);
        /// <summary>
        /// The property tells if an input unit is supported for conversion
        /// </summary>
        public bool IsKnownInputUnit => !string.IsNullOrEmpty(parseAllParams.InputUnit);
        /// <summary>
        /// The property tells if an output unit is known and supported
        /// </summary>
        public bool IsKnownOutputUnit => !string.IsNullOrEmpty(parseAllParams.OutputUnit);
        /// <summary>
        /// Error in input analysis, convert, syntaxes...
        /// </summary>
        public string Error { get; private set; }

        /// <summary>
        /// Main method provides conversion function of parsed parameters
        /// Values from this method are not rounded, that provide full output values
        /// </summary>
        /// <returns></returns>
        public string Convert() {
            if(string.IsNullOrEmpty(Error)) {
                try {
                    var cultureInfo = new System.Globalization.CultureInfo("en-US");
                    var val1 = (decimal.Parse(parseAllParams.InputValue, cultureInfo) * (string.IsNullOrEmpty(parseAllParams.InputPrefix) ? 1 : BitBytePrefixes.Prefixes[parseAllParams.InputPrefix])) * convertConstants[parseAllParams.InputUnit];
                    if(val1 < 0) throw new Exception("Negative value is not allowed");
                    var val2 = val1 / ((string.IsNullOrEmpty(parseAllParams.OutputPrefix) ? 1 : BitBytePrefixes.Prefixes[parseAllParams.OutputPrefix]) * convertConstants[parseAllParams.OutputUnit]);
                    return $"{val2.ToString(cultureInfo)} {parseAllParams.OutputPrefix}{parseAllParams.OutputUnit}";
                }
                catch(Exception exc) {
                    Error = exc.Message;
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// The method extracts parameters from input and required output
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        public void ParseParameters(string input, string output) {
            parseAllParams.Error = null;
            Error = null;
            InitConvertConstants();
            var prefixes = BitBytePrefixes.Prefixes.Keys.ToArray();
            var units = new Dictionary<string, string[]>();
            foreach(var item in supportedUnits) {
                units.Add(item, prefixes);
            }
            //For this converter are outputprefixes the same as inputprefixes 
            parseAllParams = Parsing.ParseParams(input, units, true, false, output, units, true, false);
            Error = parseAllParams.Error;
        }

        /// <summary>
        ///  Init constants for convert units.
        ///  Base unit is bit
        /// </summary>
        private void InitConvertConstants() {
            if(convertConstants == null) {
                convertConstants = new Dictionary<string, decimal>();
                convertConstants.Add("bytes", 8m);
                convertConstants.Add("byte", 8m);
                convertConstants.Add("bits", 1m);
                convertConstants.Add("bit", 1m);
            }
        }
    }
}
