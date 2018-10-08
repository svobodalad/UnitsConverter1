using System;

namespace UnitsConverterConsole
{
    public class Program
    {
        static void Main(string[] args) {
            var convert = new UnitsConverter.Convert();
            Console.WriteLine(convert.ExecuteConvert(args[0], args[1]).Value);
        }
    }
}
