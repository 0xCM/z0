//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static HexFormatSpecs;

    partial class XTend
    {
        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this sbyte src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty)
            + (zpad ? src.ToString(CaseSpec(uppercase).ToString()).PadLeft(HexPad8, '0')
            : src.ToString(CaseSpec(uppercase).ToString()))
             + (specifier && !prespec ? "h" : string.Empty);


        [MethodImpl(Inline)]
        public static string FormatHex(this byte src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty)
             + (zpad ? src.ToString(CaseSpec(uppercase).ToString()).PadLeft(HexPad8, '0')
                     : src.ToString(CaseSpec(uppercase).ToString()))
             + (specifier && !prespec ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this short src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty)
             + (zpad ? src.ToString(CaseSpec(uppercase).ToString()).PadLeft(HexPad16, '0')
                     : src.ToString(CaseSpec(uppercase).ToString()))
             + (specifier && !prespec ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this ushort src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty)
             + (zpad ? src.ToString(CaseSpec(uppercase).ToString()).PadLeft(HexPad16, '0')
                     : src.ToString(CaseSpec(uppercase).ToString()))
             + (specifier && !prespec ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this int src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty)
             + (zpad ? src.ToString(CaseSpec(uppercase).ToString()).PadLeft(HexPad32, '0')
                     : src.ToString(CaseSpec(uppercase).ToString()))
             + (specifier && !prespec ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this uint src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty)
             + (zpad ? src.ToString(CaseSpec(uppercase).ToString()).PadLeft(HexPad32, '0')
                     : src.ToString(CaseSpec(uppercase).ToString()))
             + (specifier && !prespec ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this long src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty)
             + (zpad ? src.ToString(CaseSpec(uppercase).ToString()).PadLeft(HexPad64, '0')
                     : src.ToString(CaseSpec(uppercase).ToString()))
             + (specifier && !prespec  ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this ulong src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty)
             + (zpad ? src.ToString(CaseSpec(uppercase).ToString()).PadLeft(HexPad64, '0')
                     : src.ToString(CaseSpec(uppercase).ToString()))
             + (specifier && !prespec  ? "h" : string.Empty);

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this float src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => BitConverter.SingleToInt32Bits(src).FormatHex(zpad, specifier, uppercase, prespec);

        /// <summary>
        /// Formats a scalar value as a sequence of hex digits
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="uppercase">Whether to use uppercase characters for digits A - F</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this double src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => BitConverter.DoubleToInt64Bits(src).FormatHex(zpad, specifier, uppercase, prespec);

        [MethodImpl(Inline)]
        public static string FormatHex(this byte src, HexFormatOptions config)
            => src.FormatHex(config.ZPad, config.Specifier, config.Uppercase, config.PreSpec);

        [MethodImpl(Inline)]
        public static string FormatHex(this sbyte src, HexFormatOptions config)
            => src.FormatHex(config.ZPad, config.Specifier, config.Uppercase, config.PreSpec);

        [MethodImpl(Inline)]
        public static string FormatHex(this short src, HexFormatOptions config)
            => src.FormatHex(config.ZPad, config.Specifier, config.Uppercase, config.PreSpec);

        [MethodImpl(Inline)]
        public static string FormatHex(this ushort src, HexFormatOptions config)
            => src.FormatHex(config.ZPad, config.Specifier, config.Uppercase, config.PreSpec);

        [MethodImpl(Inline)]
        public static string FormatHex(this int src, HexFormatOptions config)
            => src.FormatHex(config.ZPad, config.Specifier, config.Uppercase, config.PreSpec);

        [MethodImpl(Inline)]
        public static string FormatHex(this uint src, HexFormatOptions config)
            => src.FormatHex(config.ZPad, config.Specifier, config.Uppercase, config.PreSpec);

        [MethodImpl(Inline)]
        public static string FormatHex(this ulong src, HexFormatOptions config)
            => src.FormatHex(config.ZPad, config.Specifier, config.Uppercase, config.PreSpec);

        [MethodImpl(Inline)]
        public static string FormatHex(this long src, HexFormatOptions config)
            => src.FormatHex(config.ZPad, config.Specifier, config.Uppercase, config.PreSpec);

        [MethodImpl(Inline)]
        public static string FormatHexData(this byte src)
            => src.FormatHex(HexFormatOptions.HexData);

        [MethodImpl(Inline)]
        public static string FormatHexData(this sbyte src)
            => src.FormatHex(HexFormatOptions.HexData);

        [MethodImpl(Inline)]
        public static string FormatHexData(this short src)
            => src.FormatHex(HexFormatOptions.HexData);

        [MethodImpl(Inline)]
        public static string FormatHexData(this ushort src)
            => src.FormatHex(HexFormatOptions.HexData);

        [MethodImpl(Inline)]
        public static string FormatHexData(this int src)
            => src.FormatHex(HexFormatOptions.HexData);

        [MethodImpl(Inline)]
        public static string FormatHexData(this uint src)
            => src.FormatHex(HexFormatOptions.HexData);

        [MethodImpl(Inline)]
        public static string FormatHexData(this ulong src)
            => src.FormatHex(HexFormatOptions.HexData);

        [MethodImpl(Inline)]
        public static string FormatHexData(this long src)
            => src.FormatHex(HexFormatOptions.HexData);
    }
}