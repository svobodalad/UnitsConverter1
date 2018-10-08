using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitsConverterTests
{
    /// <summary>
    /// Tests for simulate real parameters for conversions
    /// </summary>
    [TestClass]
    public class Tests
    {
        private readonly Lazy<UnitsConverter.Convert> convert = new Lazy<UnitsConverter.Convert>(() => new UnitsConverter.Convert());

        #region Test prefix + unit(meter) >> feet
        [TestMethod]
        public void TestMethod1() {
            var result = convert.Value.ExecuteConvert("37 yottameter", "feet");
            Assert.AreEqual("121391076115485564304461942.26 feet", result.Value);
        }
        
        [TestMethod]
        public void TestMethod2() {
            var result = convert.Value.ExecuteConvert("154 zettameter", "feet");
            Assert.AreEqual("505249343832020997375328.08 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod3() {
            var result = convert.Value.ExecuteConvert("36 exameter", "feet");
            Assert.AreEqual("118110236220472440944.88 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod4() {
            var result = convert.Value.ExecuteConvert("30 petameter", "feet");
            Assert.AreEqual("98425196850393700.79 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod5() {
            var result = convert.Value.ExecuteConvert("37 terameter", "feet");
            Assert.AreEqual("121391076115485.56 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod6() {
            var result = convert.Value.ExecuteConvert("3 gigameter", "feet");
            Assert.AreEqual("9842519685.04 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod7() {
            var result = convert.Value.ExecuteConvert("5 megameter", "feet");
            Assert.AreEqual("16404199.48 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod8() {
            var result = convert.Value.ExecuteConvert("1.5 kilometer", "feet");
            Assert.AreEqual("4921.26 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod9() {
            var result = convert.Value.ExecuteConvert("3.5 hectometer", "feet");
            Assert.AreEqual("1148.29 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod10() {
            var result = convert.Value.ExecuteConvert("4.9 decameter", "feet");
            Assert.AreEqual("160.76 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod11() {
            var result = convert.Value.ExecuteConvert("37 decimeter", "feet");
            Assert.AreEqual("12.14 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod12() {
            var result = convert.Value.ExecuteConvert("154 centimeter", "feet");
            Assert.AreEqual("5.05 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod13() {
            var result = convert.Value.ExecuteConvert("36 millimeter", "feet");
            Assert.AreEqual("0.12 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod14() {
            var result = convert.Value.ExecuteConvert("30825866.78 micrometer", "feet");
            Assert.AreEqual("101.13 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod15() {
            var result = convert.Value.ExecuteConvert("32175646785465787 nanometer", "feet");
            Assert.AreEqual("105563145.62 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod16() {
            var result = convert.Value.ExecuteConvert("5468754657984565797564643 picometer", "feet");
            Assert.AreEqual("17942108457954.61 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod17() {
            var result = convert.Value.ExecuteConvert("5489754654687845 femtometer", "feet");
            Assert.AreEqual("18.01 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod18() {
            var result = convert.Value.ExecuteConvert("1562598986544656794.55 attometer", "feet");
            Assert.AreEqual("5.13 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod19() {
            var result = convert.Value.ExecuteConvert("358798746579746879856465.9 zeptometer", "feet");
            Assert.AreEqual("1177.16 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod20() {
            var result = convert.Value.ExecuteConvert("4878795346594658987564797.9 yoctometer", "feet");
            Assert.AreEqual("16.01 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod21() {
            var result = convert.Value.ExecuteConvert("4797.9 meter", "feet");
            Assert.AreEqual("15741.14 feet", result.Value);
        }
        #endregion

        #region Test meter with prefix and noprefix
        [TestMethod]
        public void TestMethod22() {
            var result = convert.Value.ExecuteConvert("4797.9 meter", "kilometer");
            Assert.AreEqual("4.80 kilometer", result.Value);
        }
        #endregion


        #region Test metric short prefix + meter >> feet
        [TestMethod]
        public void TestMethod23() {
            var result = convert.Value.ExecuteConvert("37 Ymeter", "feet");
            Assert.AreEqual("121391076115485564304461942.26 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod24() {
            var result = convert.Value.ExecuteConvert("154 Zmeter", "feet");
            Assert.AreEqual("505249343832020997375328.08 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod25() {
            var result = convert.Value.ExecuteConvert("36 Emeter", "feet");
            Assert.AreEqual("118110236220472440944.88 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod26() {
            var result = convert.Value.ExecuteConvert("30 Pmeter", "feet");
            Assert.AreEqual("98425196850393700.79 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod27() {
            var result = convert.Value.ExecuteConvert("37 Tmeter", "feet");
            Assert.AreEqual("121391076115485.56 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod28() {
            var result = convert.Value.ExecuteConvert("3 Gmeter", "feet");
            Assert.AreEqual("9842519685.04 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod29() {
            var result = convert.Value.ExecuteConvert("5 Mmeter", "feet");
            Assert.AreEqual("16404199.48 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod30() {
            var result = convert.Value.ExecuteConvert("1.5 kmeter", "feet");
            Assert.AreEqual("4921.26 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod31() {
            var result = convert.Value.ExecuteConvert("3.5 hmeter", "feet");
            Assert.AreEqual("1148.29 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod32() {
            var result = convert.Value.ExecuteConvert("4.9 dameter", "feet");
            Assert.AreEqual("160.76 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod33() {
            var result = convert.Value.ExecuteConvert("37 dmeter", "feet");
            Assert.AreEqual("12.14 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod34() {
            var result = convert.Value.ExecuteConvert("154 cmeter", "feet");
            Assert.AreEqual("5.05 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod35() {
            var result = convert.Value.ExecuteConvert("36 mmeter", "feet");
            Assert.AreEqual("0.12 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod36() {
            var result = convert.Value.ExecuteConvert("30825866.78 µmeter", "feet");
            Assert.AreEqual("101.13 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod37() {
            var result = convert.Value.ExecuteConvert("32175646785465787 nmeter", "feet");
            Assert.AreEqual("105563145.62 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod38() {
            var result = convert.Value.ExecuteConvert("5468754657984565797564643 pmeter", "feet");
            Assert.AreEqual("17942108457954.61 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod39() {
            var result = convert.Value.ExecuteConvert("5489754654687845 fmeter", "feet");
            Assert.AreEqual("18.01 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod40() {
            var result = convert.Value.ExecuteConvert("1562598986544656794.55 ameter", "feet");
            Assert.AreEqual("5.13 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod41() {
            var result = convert.Value.ExecuteConvert("358798746579746879856465.9 zmeter", "feet");
            Assert.AreEqual("1177.16 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod42() {
            var result = convert.Value.ExecuteConvert("4878795346594658987564797.9 ymeter", "feet");
            Assert.AreEqual("16.01 feet", result.Value);
        }

        #endregion

        #region Test meter with short prefix and noprefix
        [TestMethod]
        public void TestMethod43() {
            var result = convert.Value.ExecuteConvert("4797.9 meter", "kmeter");
            Assert.AreEqual("4.80 kmeter", result.Value);
        }
        #endregion


        #region Combine length units without prefixes
        [TestMethod]
        public void TestMethod44() {
            var result = convert.Value.ExecuteConvert("4797.9 meter", "inch");
            Assert.AreEqual("188893.70 inch", result.Value);
        }

        [TestMethod]
        public void TestMethod45() {
            var result = convert.Value.ExecuteConvert("47970.9 inch", "meter");
            Assert.AreEqual("1218.46 meter", result.Value);
        }

        [TestMethod]
        public void TestMethod46() {
            var result = convert.Value.ExecuteConvert("47970.9 inch", "feet");
            Assert.AreEqual("3997.58 feet", result.Value);
        }

        [TestMethod]
        public void TestMethod47() {
            var result = convert.Value.ExecuteConvert("47970.9 feet", "inch");
            Assert.AreEqual("575650.8 inch", result.Value);
        }
        #endregion

        #region Combine length units with noplurals and plurals
        [TestMethod]
        public void TestMethod48() {
            var result = convert.Value.ExecuteConvert("4797.9 meters", "inches");
            Assert.AreEqual("188893.70 inches", result.Value);
        }

        [TestMethod]
        public void TestMethod49() {
            var result = convert.Value.ExecuteConvert("47970.9 inches", "meter");
            Assert.AreEqual("1218.46 meter", result.Value);
        }

        [TestMethod]
        public void TestMethod50() {
            var result = convert.Value.ExecuteConvert("47970.9 inch", "feets");
            Assert.AreEqual("3997.58 feets", result.Value);
        }
        #endregion

        #region Test prefix + bytes > bytes
        [TestMethod]
        public void TestMethod51() {
            var result = convert.Value.ExecuteConvert("10 yottabytes", "bytes");
            Assert.AreEqual("10000000000000000000000000 bytes", result.Value);
        }

        [TestMethod]
        public void TestMethod52() {
            var result = convert.Value.ExecuteConvert("10 zettabytes", "bytes");
            Assert.AreEqual("10000000000000000000000 bytes", result.Value);
        }

        [TestMethod]
        public void TestMethod53() {
            var result = convert.Value.ExecuteConvert("10 exabytes", "bytes");
            Assert.AreEqual("10000000000000000000 bytes", result.Value);
        }

        [TestMethod]
        public void TestMethod54() {
            var result = convert.Value.ExecuteConvert("10 petabytes", "bytes");
            Assert.AreEqual("10000000000000000 bytes", result.Value);
        }

        [TestMethod]
        public void TestMethod55() {
            var result = convert.Value.ExecuteConvert("10 terabytes", "bytes");
            Assert.AreEqual("10000000000000 bytes", result.Value);
        }

        [TestMethod]
        public void TestMethod56() {
            var result = convert.Value.ExecuteConvert("10 gigabytes", "bytes");
            Assert.AreEqual("10000000000 bytes", result.Value);
        }

        [TestMethod]
        public void TestMethod57() {
            var result = convert.Value.ExecuteConvert("10 megabytes", "bytes");
            Assert.AreEqual("10000000 bytes", result.Value);
        }

        [TestMethod]
        public void TestMethod58() {
            var result = convert.Value.ExecuteConvert("10 kilobytes", "bytes");
            Assert.AreEqual("10000 bytes", result.Value);
        }
        #endregion

        #region Test short prefix + bytes > bytes
        [TestMethod]
        public void TestMethod59() {
            var result = convert.Value.ExecuteConvert("10 Ybytes", "bytes");
            Assert.AreEqual("10000000000000000000000000 bytes", result.Value);
        }

        [TestMethod]
        public void TestMethod60() {
            var result = convert.Value.ExecuteConvert("10 Zbytes", "bytes");
            Assert.AreEqual("10000000000000000000000 bytes", result.Value);
        }

        [TestMethod]
        public void TestMethod61() {
            var result = convert.Value.ExecuteConvert("10 Ebytes", "bytes");
            Assert.AreEqual("10000000000000000000 bytes", result.Value);
        }

        [TestMethod]
        public void TestMethod62() {
            var result = convert.Value.ExecuteConvert("10 Pbytes", "bytes");
            Assert.AreEqual("10000000000000000 bytes", result.Value);
        }

        [TestMethod]
        public void TestMethod63() {
            var result = convert.Value.ExecuteConvert("10 Tbytes", "bytes");
            Assert.AreEqual("10000000000000 bytes", result.Value);
        }

        [TestMethod]
        public void TestMethod64() {
            var result = convert.Value.ExecuteConvert("10 Gbytes", "bytes");
            Assert.AreEqual("10000000000 bytes", result.Value);
        }

        [TestMethod]
        public void TestMethod65() {
            var result = convert.Value.ExecuteConvert("10 Mbytes", "bytes");
            Assert.AreEqual("10000000 bytes", result.Value);
        }

        [TestMethod]
        public void TestMethod66() {
            var result = convert.Value.ExecuteConvert("10 kbytes", "bytes");
            Assert.AreEqual("10000 bytes", result.Value);
        }
        #endregion

        #region 2 Test short prefix + bytes > bits
        [TestMethod]
        public void TestMethod67() {
            var result = convert.Value.ExecuteConvert("10 Ybytes", "bits");
            Assert.AreEqual("80000000000000000000000000 bits", result.Value);
        }

        [TestMethod]
        public void TestMethod68() {
            var result = convert.Value.ExecuteConvert("10 Zbytes", "bits");
            Assert.AreEqual("80000000000000000000000 bits", result.Value);
        }
        #endregion

        #region 2 Test short bits > prefix + bytes
        [TestMethod]
        public void TestMethod69() {
            var result = convert.Value.ExecuteConvert("256 bits", "bytes");
            Assert.AreEqual("32 bytes", result.Value);
        }

        [TestMethod]
        public void TestMethod70() {
            var result = convert.Value.ExecuteConvert("128 bits", "bytes");
            Assert.AreEqual("16 bytes", result.Value);
        }
        #endregion

        #region 2 Test short bits > prefix + bytes
        [TestMethod]
        public void TestMethod71() {
            var result = convert.Value.ExecuteConvert("8192 bits", "kbytes");
            Assert.AreEqual("1.024 kbytes", result.Value);
        }

        [TestMethod]
        public void TestMethod72() {
            var result = convert.Value.ExecuteConvert("16384 bits", "kilobytes");
            Assert.AreEqual("2.048 kilobytes", result.Value);
        }
        #endregion

        #region 2 Test  bits > bytes with plurals and not plurals
        [TestMethod]
        public void TestMethod73() {
            var result = convert.Value.ExecuteConvert("8192 bits", "byte");
            Assert.AreEqual("1024 byte", result.Value);
        }

        [TestMethod]
        public void TestMethod74() {
            var result = convert.Value.ExecuteConvert("16384 bit", "bytes");
            Assert.AreEqual("2048 bytes", result.Value);
        }
        #endregion

        #region 2 Test with invalid parameters
        [TestMethod]
        public void TestMethod75() {
            var result = convert.Value.ExecuteConvert("", "");
            Assert.AreEqual("InputParams are empty", result.Error);
        }

        [TestMethod]
        public void TestMethod76() {
            var result = convert.Value.ExecuteConvert(null, "bytes");
            Assert.AreEqual("InputParams are empty", result.Error);
        }

        [TestMethod]
        public void TestMethod77() {
            var result = convert.Value.ExecuteConvert("", null);
            Assert.AreEqual("InputParams are empty", result.Error);
        }

        [TestMethod]
        public void TestMethod78() {
            var result = convert.Value.ExecuteConvert("16384 bit", null);
            Assert.AreEqual("PrefixAndUnit for output are empty", result.Error);
        }

        [TestMethod]
        public void TestMethod79() {
            var result = convert.Value.ExecuteConvert("16384 bit", "inch");
            Assert.AreEqual("Not find suitable convertor", result.Error);
        }

        [TestMethod]
        public void TestMethod80() {
            var result = convert.Value.ExecuteConvert("16384 bit", "qwer");
            Assert.AreEqual("Not find suitable convertor", result.Error);
        }

        [TestMethod]
        public void TestMethod81() {
            var result = convert.Value.ExecuteConvert("bit", "kbit");
            Assert.AreEqual("Invalid first part of InputParams", result.Error);
        }

        [TestMethod]
        public void TestMethod82() {
            var result = convert.Value.ExecuteConvert("2bit", "kbit");
            Assert.AreEqual("Invalid first part of InputParams", result.Error);
        }

        [TestMethod]
        public void TestMethod83() {
            var result = convert.Value.ExecuteConvert("16 bit", "brumkbit");
            Assert.AreEqual("Prefix for output does not support", result.Error);
        }

        [TestMethod]
        public void TestMethod84() {
            var result = convert.Value.ExecuteConvert("16 brumbit", "kbit");
            Assert.AreEqual("Prefix for input does not support", result.Error);
        }

        [TestMethod]
        public void TestMethod85() {
            var result = convert.Value.ExecuteConvert("-16 bit", "kbit");
            Assert.AreEqual("Negative value is not allowed", result.Error);
        }


        #endregion



    }
}

