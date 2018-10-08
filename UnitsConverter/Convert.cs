using System;
using System.Linq;
using System.Reflection;
using UnitsConverter.Interfaces;
using UnitsConverter.Utils;

namespace UnitsConverter
{
    public sealed class Convert {

        private readonly Lazy<ConverterInterface[]> convertors;

        public Convert() {
            convertors = new Lazy<ConverterInterface[]>(() => LoadConvertors());
        }

        private ConverterInterface[] LoadConvertors() {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            var typesWithInterface = types.Where(tp => tp.IsClass && typeof(ConverterInterface).IsAssignableFrom(tp)).Select(tp => (ConverterInterface)Activator.CreateInstance(tp)).ToArray();
            return typesWithInterface;
        }

        public ConvertResult ExecuteConvert(string inputParams, string outputPrefixAndUnit) {
            foreach(var item in convertors.Value) {
                item.ParseParameters(inputParams, outputPrefixAndUnit);
                if(item.CanConvert) {
                    var res = new ConvertResult();
                    res.Value = item.Convert();
                    res.Error = item.Error;
                    return res;
                }
                else if(!string.IsNullOrEmpty(item.Error)) {
                    var res = new ConvertResult();
                    res.Value = null;
                    res.Error = item.Error;
                    return res;
                }
            }
            return new ConvertResult() { Value = null, Error = "Not find suitable convertor" };
        }
    }
}
