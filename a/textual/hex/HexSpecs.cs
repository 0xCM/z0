//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    public static class HexSpecs
    {
        /// <summary>
        /// The uppercase hex format code
        /// </summary>
        public const string UC = "X";

        /// <summary>
        /// The lowercase hex format code
        /// </summary>
        public const string LC = "x";

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
        public const char PostSpec = 'h';

        /// <summary>
        /// The asci code of the '0' digit
        /// </summary>
        public const byte MinCode = 48;
        
        /// <summary>
        /// The asci code of the '9' digit
        /// </summary>
        public const byte MaxLoCode = 57;

        /// <summary>
        /// The asci code of the 'A' digit
        /// </summary>
        public const byte MinHiCode = 65;

        /// <summary>
        /// The asci code of the 'F' digit
        /// </summary>
        public const byte MaxCode = 70;

        /// <summary>
        /// Defines the asci character codes for uppercase hex digits 1,2, ..., 9, A, ..., F
        /// </summary>
        public static ReadOnlySpan<byte> Uppercase
            => new byte[]{48,49,50,51,52,53,54,55,56,57,65,66,67,68,69,70};

        /// <summary>
        /// Determines whether a character corresponds to one of the lower hex codes
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        public static bool islo(char c)
            => (byte)c >= MinCode && (byte)c <= MaxLoCode;

        /// <summary>
        /// Determines whether a character corresponds to one of the uper hex codes
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        public static bool ishi(char c)
            => (byte)c >= MinHiCode && (byte)c <= MaxCode;        
        
        /// <summary>
        /// Determines whether a character corresponds to a digit in the set {1,2, ..., 9, A, ..., F}
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        public static bool ishex(char c)
            => islo(c) || ishi(Char.ToUpper(c));

        /// <summary>
        /// Selects the uppercase or lowercase hex format code
        /// </summary>
        /// <param name="upper">True for uppercase, false for lowercase</param>
        [MethodImpl(Inline)]
        public static string HexFmtSpec(bool upper)
            => upper ? "X" : "x";
    }
}