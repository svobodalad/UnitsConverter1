﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsConverter.Interfaces;
using UnitsConverter.Utils;

namespace UnitsConverter.Convertors
{
    class LengthUnits : ConverterInterface
    {
        private string[] supportedUnits = new string[6] { "inches", "inch", "feets", "feet", "meters", "meter" };
        private ParseInput parseInput;
        private ParseOutput parseOutput;
        private Dictionary<string, decimal> convertConstants;

        public bool CanConvert => IsKnownInputUnit && IsKnownOutputUnit && string.IsNullOrEmpty(Error);
        public bool IsKnownInputUnit => !string.IsNullOrEmpty(parseInput.Unit);
        public bool IsKnownOutputUnit => !string.IsNullOrEmpty(parseOutput.Unit);
        public string Error { get; private set; }

        public string Convert() {
            if(string.IsNullOrEmpty(Error)) {
                var cultureInfo = new System.Globalization.CultureInfo("en-US");
                try {
                    var val1 = (decimal.Parse(parseInput.Value,cultureInfo) * (string.IsNullOrEmpty(parseInput.Prefix) ? 1 : SiPrefixes.SiTables[parseInput.Prefix])) * convertConstants[parseInput.Unit];
                    var val2 = val1 / (((string.IsNullOrEmpty(parseOutput.Prefix) ? 1 : SiPrefixes.SiTables[parseOutput.Prefix])) * convertConstants[parseOutput.Unit]);
                    return $"{Math.Round(val2, 2).ToString(cultureInfo)} {parseOutput.Prefix}{parseOutput.Unit}";
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
            var prefixes = SiPrefixes.SiTables.Keys.ToArray();
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
                convertConstants.Add("inches", 0.0254m);
                convertConstants.Add("inch", 0.0254m);
                convertConstants.Add("feets", 0.3048m);
                convertConstants.Add("feet", 0.3048m);
                convertConstants.Add("meters", 1m);
                convertConstants.Add("meter", 1m);
            }
        }
    }
}