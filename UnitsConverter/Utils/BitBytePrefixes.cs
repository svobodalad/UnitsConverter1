using System;
using System.Collections.Generic;

namespace UnitsConverter.Utils
{
    public sealed class BitBytePrefixes
    {

        private static readonly Lazy<BitBytePrefixes> prefixes = new Lazy<BitBytePrefixes>(() => new BitBytePrefixes());
        public static Dictionary<string, decimal> Prefixes { get { return prefixes.Value.BitByteDictionary; } }
        public Dictionary<string, decimal> BitByteDictionary { get; private set; }

        private BitBytePrefixes() {
            InitTables();
        }

        private void InitTables() {
            var bitByteDictionaryLocal = new Dictionary<string, decimal>();
            bitByteDictionaryLocal.Add("yotta", 1000000000000000000000000m);
            bitByteDictionaryLocal.Add("zetta", 1000000000000000000000m);
            bitByteDictionaryLocal.Add("exa", 1000000000000000000m);
            bitByteDictionaryLocal.Add("peta", 1000000000000000m);
            bitByteDictionaryLocal.Add("tera", 1000000000000m);
            bitByteDictionaryLocal.Add("giga", 1000000000m);
            bitByteDictionaryLocal.Add("mega", 1000000m);
            bitByteDictionaryLocal.Add("kilo", 1000m);

            bitByteDictionaryLocal.Add("Y", 1000000000000000000000000m);
            bitByteDictionaryLocal.Add("Z", 1000000000000000000000m);
            bitByteDictionaryLocal.Add("E", 1000000000000000000m);
            bitByteDictionaryLocal.Add("P", 1000000000000000m);
            bitByteDictionaryLocal.Add("T", 1000000000000m);
            bitByteDictionaryLocal.Add("G", 1000000000m);
            bitByteDictionaryLocal.Add("M", 1000000m);
            bitByteDictionaryLocal.Add("k", 1000m);

            BitByteDictionary = bitByteDictionaryLocal;
        }
    }
}
