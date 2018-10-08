﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnitsConverter.Interfaces;
using UnitsConverter.Utils;

namespace UnitsConverter.Convertors
{
    class BytesAndBitsUnits : ConverterInterface
    {
        private string[] supportedUnits = new string[4] { "bytes", "byte", "bits", "bit"};
        private ParseInput parseInput;
        private ParseOutput parseOutput;
        private Dictionary<string, decimal> convertConstants;

        public bool CanConvert => IsKnownInputUnit && IsKnownOutputUnit && string.IsNullOrEmpty(Error);
        public bool IsKnownInputUnit => !string.IsNullOrEmpty(parseInput.Unit);
        public bool IsKnownOutputUnit => !string.IsNullOrEmpty(parseOutput.Unit);
        public string Error { get; private set; }

        public string Convert() {
            if(string.IsNullOrEmpty(Error)) {
                try {
                    var cultureInfo = new System.Globalization.CultureInfo("en-US");
                    var val1 = (decimal.Parse(parseInput.Value, cultureInfo) * (string.IsNullOrEmpty(parseInput.Prefix) ? 1 : BitBytePrefixes.Prefixes[parseInput.Prefix])) * convertConstants[parseInput.Unit];
                    if(val1 < 0) throw new Exception("Negative value is not allowed");
                    var val2 = val1 / ((string.IsNullOrEmpty(parseOutput.Prefix) ? 1 : BitBytePrefixes.Prefixes[parseOutput.Prefix]) * convertConstants[parseOutput.Unit]);
                    return $"{val2.ToString(cultureInfo)} {parseOutput.Prefix}{parseOutput.Unit}";
                }
                catch(Exception exc) {
                    Error = exc.Message;
                }
            }
            return string.Empty;
        }

        public void ParseParameters(string input, string output) {
            parseInput.Error = null;
            InitConvertConstants();
            var prefixes = BitBytePrefixes.Prefixes.Keys.ToArray();
            var units = new Dictionary<string, string[]>();
            foreach(var item in supportedUnits) {
                units.Add(item, prefixes);
            }
            parseInput = Utils.Utils.ParseInputParams(input, units);
            Error = parseInput.Error;
            if(string.IsNullOrEmpty(parseInput.Error)) {
                parseOutput = Utils.Utils.ParseOutputParams(output, units);
                Error = parseOutput.Error;
            }
        }

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
