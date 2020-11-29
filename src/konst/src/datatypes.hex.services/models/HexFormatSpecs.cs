//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public static class HexFormatSpecs
    {
        /// <summary>
        /// The uppercase hex format code
        /// </summary>
        public const string UC = AsciCharText.X;

        /// <summary>
        /// The lowercase hex format code
        /// </summary>
        public const string LC = AsciCharText.x;

        /// <summary>
        /// The delimiter used to separate hex numbers when rendering a hex data sequence
        /// </summary>
        public const char DataDelimiter = Chars.Space;

        /// <summary>
        /// The maximum number of hex characters required to represent an 8-bit number
        /// </summary>
        public const int HexPad8 = 2;

        /// <summary>
        /// The maximum number of hex characters required to represent a 16-bit number
        /// </summary>
        public const int HexPad16 = 4;

        /// <summary>
        /// The maximum number of hex characters required to represent a 32-bit number
        /// </summary>
        public const int HexPad32 = 8;

        /// <summary>
        /// The maximum number of hex characters required to represent a 64-bit number
        /// </summary>
        public const int HexPad64 = 16;

        /// <summary>
        /// Standard hex specifier that leads the numeric content
        /// </summary>
        public const string PreSpec = "0x";

        /// <summary>
        /// Standard hex specifier that trails the numeric content
        /// </summary>
        public const string PostSpec = "h";

        public const string SmallHexSpec = "x4";

        public const string Hex4 = "x1";

        public const string Hex8 = "x2";

        public const string Hex12 = "x3";

        public const string Hex16 = "x4";

        public const string Hex20 = "x5";

        public const string Hex24 = "x6";

        public const string Hex28 = "x7";

        public const string Hex32 = "x8";

        public const string Hex36 = "x9";

        public const string Hex40 = "x10";

        public const string Hex44 = "x11";

        public const string Hex48 = "x12";

        public const string Hex52 = "x13";

        public const string Hex56 = "x14";

        public const string Hex60 = "x15";

        public const string Hex64 = "x16";

        /// <summary>
        /// Specifies the default configuration for hex data emission
        /// </summary>
        public static HexFormatOptions HexData
            => new HexFormatOptions(true, false, false, false, Space);

        /// <summary>
        /// The default configuration for array initialization content
        /// </summary>
        public static HexFormatOptions HexArray
            => new HexFormatOptions(true, true, false, true, Chars.Comma);

        /// <summary>
        /// Selects either the uppercase format code 'X' or lowercase format code 'x'
        /// </summary>
        /// <param name="upper">True for uppercase, false for lowercase</param>
        [MethodImpl(Inline)]
        public static char CaseSpec(bool upper)
            => upper ? 'X' : 'x';

        /// <summary>
        /// Removes leading or trailing hex specifiers
        /// </summary>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline)]
        public static string ClearSpecs(string src)
            => src.Remove("0x").RemoveAny('h');

        [MethodImpl(Inline)]
        public static HexFormatOptions options(bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true, char? delimiter = null)
            => new HexFormatOptions(zpad,specifier, uppercase, prespec, delimiter ?? Space);

        [MethodImpl(Inline)]
        public static HexSeqFormat seq(in HexFormatOptions hex, string delimiter = null)
            => new HexSeqFormat(hex, delimiter ?? hex.Delimiter.ToString());
    }
}