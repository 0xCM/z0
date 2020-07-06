//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public static class HexSpecs
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

        /// <summary>
        /// Attempts to parse a hex digit
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline)]
        public static ParseResult<byte> Parse(char c)
        {
            var u = Char.ToUpperInvariant(c);
            if(Hex.isNumber(c))
                return ParseResult.Success(c, (byte)((byte)u - Hex.MinScalarCode));
            else if(Hex.isUpper(c))
                return ParseResult.Success(c, (byte)((byte)u - Hex.MinCharCodeU + 0xA));
            else
                return ParseResult.Fail<byte>(c);
        }
    }
}