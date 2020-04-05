//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

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
        public const byte MinScalarCode = 48;
        
        /// <summary>
        /// The asci code of the '9' digit
        /// </summary>
        public const byte MaxScalarCode = 57;

        /// <summary>
        /// The asci code of the 'A' digit
        /// </summary>
        public const byte MinCharCodeU = 65;

        /// <summary>
        /// The asci code of the 'F' digit
        /// </summary>
        public const byte MaxCharCodeU = 70;

        /// <summary>
        /// The asci code of the 'a' digit
        /// </summary>
        public const byte MinCharCodeL = 97;

        /// <summary>
        /// The asci code of the 'f' digit
        /// </summary>
        public const byte MaxCharCodeL = 102;

        /// <summary>
        /// Defines the asci character codes for uppercase hex digits 1,2, ..., 9, A, ..., F
        /// </summary>
        public static ReadOnlySpan<byte> Uppercase
            => new byte[]{48,49,50,51,52,53,54,55,56,57,65,66,67,68,69,70};

        /// <summary>
        /// Defines the asci character codes for uppercase hex digits 1,2, ..., 9, a, ..., f
        /// </summary>
        public static ReadOnlySpan<byte> Lowercase
            => new byte[]{48,49,50,51,52,53,54,55,56,57,97,98,99,100,101,102};

        /// <summary>
        /// Determines whether a character corresponds to one of the lower hex codes
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        public static bool IsScalar(char c)
            => (byte)c >= MinScalarCode && (byte)c <= MaxScalarCode;

        /// <summary>
        /// Determines whether a character corresponds to one of the uppercase hex code characters
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        public static bool IsUpperChar(char c)
            => (byte)c >= MinCharCodeU && (byte)c <= MaxCharCodeU;        

        /// <summary>
        /// Determines whether a character corresponds to one of the lowercase hex code characters
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        public static bool IsLowerChar(char c)
            => (byte)c >= MinCharCodeU && (byte)c <= MaxCharCodeU;        

        /// <summary>
        /// Determines whether a character is a hex digit
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline)]
        public static bool IsHex(char c)
            => IsScalar(c) || IsUpperChar(c) || IsLowerChar(c);

        /// <summary>
        /// Selects the uppercase or lowercase hex format code
        /// </summary>
        /// <param name="upper">True for uppercase, false for lowercase</param>
        [MethodImpl(Inline)]
        public static string HexFmtSpec(bool upper)
            => upper ? "X" : "x";

        /// <summary>
        /// Removes leading or trailing hex specifiers
        /// </summary>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline)]
        public static string ClearSpecs(string src)
            => src.Remove("0x").RemoveAny('h');
    }
}