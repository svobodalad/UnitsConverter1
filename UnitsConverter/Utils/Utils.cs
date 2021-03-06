﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitsConverter.Utils
{
    /// <summary>
    /// Class with parsing methods
    /// </summary>
    class Parsing
    {
        /// <summary>
        /// Static method for parsing input parameters with "value, prefix(optional), unit" for instance:4797.9 meter;36 exameter;10 bytes.....
        /// </summary>
        /// <param name="inputParams"></param>
        /// <param name="allowedUnitsAndPrefixes"></param>
        /// <param name="caseSensitivePrefix"></param>
        /// <param name="caseSensitiveUnits"></param>
        /// <returns></returns>
        public static ParseInput ParseInputParams(string inputParams, Dictionary<string, string[]> allowedUnitsAndPrefixes, bool caseSensitivePrefix = true, bool caseSensitiveUnits = false) {
            if(string.IsNullOrWhiteSpace(inputParams)) return new ParseInput() { Value = string.Empty, Prefix = string.Empty, Unit = string.Empty, Error = "InputParams are empty" };
            var trimmedInputParams = inputParams.Trim();
            var indexPrefixAndUnit = trimmedInputParams.LastIndexOf(' ');
            var prefixAndUnit = string.Empty;
            if(indexPrefixAndUnit > 0) prefixAndUnit = inputParams.Substring(indexPrefixAndUnit + 1).Trim();
            else return new ParseInput() { Value = string.Empty, Prefix = string.Empty, Unit = string.Empty, Error = "Invalid first part of InputParams" };

            var value = trimmedInputParams.Substring(0, indexPrefixAndUnit).Trim();
            var prefixAndUnitLength = prefixAndUnit.Length;
            foreach(var item in allowedUnitsAndPrefixes) {
                var startIndex = prefixAndUnitLength - item.Key.Length;
                if(startIndex < 0) continue;
                var unit = prefixAndUnit.Substring(startIndex);
                if(item.Key.Equals(unit, !caseSensitiveUnits ? StringComparison.InvariantCultureIgnoreCase : StringComparison.InvariantCulture)) {
                    var prefix = prefixAndUnit.Substring(0, startIndex).Trim();
                    if(string.IsNullOrEmpty(prefix)) return new ParseInput() { Value = value, Prefix = string.Empty, Unit = unit, Error = string.Empty };
                    if(item.Value != null && item.Value.Any(p => p.Equals(prefix, !caseSensitivePrefix ? StringComparison.InvariantCultureIgnoreCase : StringComparison.InvariantCulture))) {
                        return new ParseInput() { Value = value, Prefix = prefix, Unit = unit, Error = string.Empty };
                    }
                    else return new ParseInput() { Value = string.Empty, Prefix = string.Empty, Unit = unit, Error = "Prefix for input does not support" };
                }
                else continue;
            }
            return new ParseInput() { Value = string.Empty, Prefix = string.Empty, Unit = string.Empty, Error = string.Empty };
        }

        /// <summary>
        /// Static method for parsing required output unit for instance: meter, kilometer, milimeter, bit, kilobits....
        /// </summary>
        /// <param name="prefixAndUnit"></param>
        /// <param name="allowedUnitsAndPrefixes"></param>
        /// <param name="caseSensitivePrefix"></param>
        /// <param name="caseSensitiveUnits"></param>
        /// <returns></returns>
        public static ParseOutput ParseOutputParams(string prefixAndUnit, Dictionary<string, string[]> allowedUnitsAndPrefixes, bool caseSensitivePrefix = true, bool caseSensitiveUnits = false) {
            if(string.IsNullOrWhiteSpace(prefixAndUnit)) return new ParseOutput() { Prefix = string.Empty, Unit = string.Empty, Error = "PrefixAndUnit for output are empty" };
            var prefixAndUnitLength = prefixAndUnit.Length;
            foreach(var item in allowedUnitsAndPrefixes) {
                var startIndex = prefixAndUnitLength - item.Key.Length;
                if(startIndex < 0) continue;
                var unit = prefixAndUnit.Substring(startIndex);
                if(item.Key.Equals(unit, !caseSensitiveUnits ? StringComparison.InvariantCultureIgnoreCase : StringComparison.InvariantCulture)) {
                    var prefix = prefixAndUnit.Substring(0, startIndex).Trim();
                    if(string.IsNullOrEmpty(prefix)) return new ParseOutput() { Prefix = string.Empty, Unit = unit, Error = string.Empty };
                    if(item.Value != null && item.Value.Any(p => p.Equals(prefix, !caseSensitivePrefix ? StringComparison.InvariantCultureIgnoreCase : StringComparison.InvariantCulture))) {
                        return new ParseOutput() { Prefix = prefix, Unit = unit, Error = string.Empty };
                    }
                    else return new ParseOutput() { Prefix = string.Empty, Unit = unit, Error = "Prefix for output does not support" };
                }
                else continue;
            }
            return new ParseOutput() { Prefix = string.Empty, Unit = string.Empty, Error = string.Empty };
        }

        public static ParseAllParams ParseParams(string inputParams, Dictionary<string, string[]> allowedInputUnitsAndPrefixes, bool caseSensitiveInputPrefix, bool caseSensitiveInputUnits,
            string outputPrefixAndUnit, Dictionary<string, string[]> allowedOutputUnitsAndPrefixes, bool caseSensitiveOutputPrefix, bool caseSensitiveOutputUnits) {
            var parseInput = ParseInputParams(inputParams, allowedInputUnitsAndPrefixes, caseSensitiveInputPrefix, caseSensitiveInputUnits);
            if(string.IsNullOrEmpty(parseInput.Error)) {
                var parseOutput = ParseOutputParams(outputPrefixAndUnit, allowedOutputUnitsAndPrefixes, caseSensitiveOutputPrefix, caseSensitiveOutputUnits);
                return new ParseAllParams() {
                    Error = parseOutput.Error,
                    OutputPrefix = parseOutput.Prefix,
                    OutputUnit = parseOutput.Unit,
                    InputPrefix = parseInput.Prefix,
                    InputUnit = parseInput.Unit,
                    InputValue = parseInput.Value
                };
            }
            else {
                return new ParseAllParams() {
                    Error = parseInput.Error,
                    InputPrefix = parseInput.Prefix,
                    InputUnit = parseInput.Unit,
                    InputValue = parseInput.Value
                };
            }
        }
    }
}
