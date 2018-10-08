using System;
using System.Collections.Generic;

namespace UnitsConverter.Utils
{
    public sealed class SiPrefixes {

        private static readonly Lazy<SiPrefixes> prefixes = new Lazy<SiPrefixes>(() => new SiPrefixes());
        public static Dictionary<string, decimal> SiTables { get { return prefixes.Value.SiDictionary; } }
        public Dictionary<string, decimal> SiDictionary { get; private set; }

        private SiPrefixes() {
            InitTables();
        }

        private void InitTables() {
            var siDictionaryLocal = new Dictionary<string, decimal>();
            siDictionaryLocal.Add("yotta", 1000000000000000000000000m);
            siDictionaryLocal.Add("zetta", 1000000000000000000000m);
            siDictionaryLocal.Add("exa", 1000000000000000000m);
            siDictionaryLocal.Add("peta", 1000000000000000m);
            siDictionaryLocal.Add("tera", 1000000000000m);
            siDictionaryLocal.Add("giga", 1000000000m);
            siDictionaryLocal.Add("mega", 1000000m);
            siDictionaryLocal.Add("kilo", 1000m);
            siDictionaryLocal.Add("hecto", 100m);
            siDictionaryLocal.Add("deca", 10m);

            siDictionaryLocal.Add("deci", 0.1m);
            siDictionaryLocal.Add("centi", 0.01m);
            siDictionaryLocal.Add("milli", 0.001m);
            siDictionaryLocal.Add("micro", 0.000001m);
            siDictionaryLocal.Add("nano", 0.000000001m);
            siDictionaryLocal.Add("pico", 0.000000000001m);
            siDictionaryLocal.Add("femto", 0.000000000000001m);
            siDictionaryLocal.Add("atto", 0.000000000000000001m);
            siDictionaryLocal.Add("zepto", 0.000000000000000000001m);
            siDictionaryLocal.Add("yocto", 0.000000000000000000000001m);

            siDictionaryLocal.Add("Y", 1000000000000000000000000m);
            siDictionaryLocal.Add("Z", 1000000000000000000000m);
            siDictionaryLocal.Add("E", 1000000000000000000m);
            siDictionaryLocal.Add("P", 1000000000000000m);
            siDictionaryLocal.Add("T", 1000000000000m);
            siDictionaryLocal.Add("G", 1000000000m);
            siDictionaryLocal.Add("M", 1000000m);
            siDictionaryLocal.Add("k", 1000m);
            siDictionaryLocal.Add("h", 100m);
            siDictionaryLocal.Add("da", 10m);

            siDictionaryLocal.Add("d", 0.1m);
            siDictionaryLocal.Add("c", 0.01m);
            siDictionaryLocal.Add("m", 0.001m);
            siDictionaryLocal.Add("µ", 0.000001m);
            siDictionaryLocal.Add("n", 0.000000001m);
            siDictionaryLocal.Add("p", 0.000000000001m);
            siDictionaryLocal.Add("f", 0.000000000000001m);
            siDictionaryLocal.Add("a", 0.000000000000000001m);
            siDictionaryLocal.Add("z", 0.000000000000000000001m);
            siDictionaryLocal.Add("y", 0.000000000000000000000001m);
            SiDictionary = siDictionaryLocal;
        }
    }
}
