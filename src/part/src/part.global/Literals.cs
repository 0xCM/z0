//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using NK = NumericKind;
    using DW = DataWidth;
    using Z = Zero;

    partial struct Part
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public const MethodImplOptions NotInline = MethodImplOptions.NoInlining;

        public const string EmptyString = "";

        /// <summary>
        /// An abbreviation for the ridiculously long "StringComparison.InvariantCultureIgnoreCase"
        /// </summary>
        public const StringComparison NoCase = StringComparison.InvariantCultureIgnoreCase;

        /// <summary>
        /// An abbreviation for the somewhat verbose "StringComparison.InvariantCulture"
        /// </summary>
        public const StringComparison Cased = StringComparison.InvariantCulture;

        /// <summary>
        /// The end-of-line escape sequence
        /// </summary>
        public const string Eol = Chars.Eol;

        /// <summary>
        /// The number of bits to shift a field specifier left/right to reveal/specify the width of an identified field
        /// </summary>
        public const int WidthOffset = 16;

        /// <summary>
        /// Specifies the widths of system-supported primal numeric data types
        /// </summary>
        public const DW NumericWidths = DW.W8 | DW.W16 | DW.W32 | DW.W64;

        /// <summary>
        /// Specifies unsigned integral types of widths <see cref='NumericWidths'/>
        /// </summary>
         public const NK UnsignedInts = NK.UnsignedInts;

        /// <summary>
        /// Specifies signed integral types of widths <see cref='NumericWidths'/>
        /// </summary>
        public const NK SignedInts = NK.SignedInts;

        /// <summary>
        /// Specifies signed and unsigned integral types of widths <see cref='NumericWidths'/>
        /// </summary>
        public const NK Integers = NK.Integers;

        public const NK AllNumeric = NK.All;

        /// <summary>
        /// The default delimiter to use when formatting structured text
        /// </summary>
        public const char FieldDelimiter = Chars.Pipe;

        /// <summary>
        /// What else could this be?
        /// </summary>
        public const char Space = ' ';

        /// <summary>
        /// Specifies numeric types of width <see cref='W64'/>
        /// </summary>
        public const NK Numeric64k = NK.Width64;

        /// <summary>
        /// Specifies numeric types of width <see cref='W8'/>, <see cref='W16'/> and <see cref='W32'/>
        /// </summary>
        public const NK Numeric8x16x32k = NK.Width8 | NK.Width16 | NK.Width32;

        /// <summary>
        /// Specifies numeric types of width <see cref='W16'/>, <see cref='W32'/>, and <see cref='W64'/>
        /// </summary>
        public const NK Numeric16x32x64k = NK.Width16 | NK.Width32 | NK.Width64;

        /// <summary>
        /// Specifies numeric types of width <see cref='W32'/>, and <see cref='W64'/>
        /// </summary>
        public const NK Numeric32x64k = NK.Width32 | NK.Width64;

        /// <summary>
        /// Specifies signed and unsigned integral type of width <see cref='W8'/>
        /// </summary>
        public const NK Int8k = NK.I8 | NK.U8;

        /// <summary>
        /// Specifies signed and unsigned integral type of width <see cref='W16'/>
        /// </summary>
        public const NK Int16k = NK.I16 | NK.U16;

        /// <summary>
        /// Specifies signed and unsigned integral type of width <see cref='W32'/>
        /// </summary>
        public const NK Int32k = NK.I32 | NK.U32;

        /// <summary>
        /// Specifies signed and unsigned integral type of width <see cref='W64'/>
        /// </summary>
        public const NK Int64k = NK.I64 | NK.U64;

        /// <summary>
        /// Specifies signed and unsigned integral types of width <see cref='W8'/> and <see cref='W16'/>
        /// </summary>
        public const NK Int8x16k = NK.I8 | NK.U8 | NK.I16 | NK.U16;

        /// <summary>
        /// Specifies signed and unsigned integral types of width <see cref='W8'/>, <see cref='W16'/>, and <see cref='W32'/>
        /// </summary>
        public const NK Int8x16x32k = NK.I8 | NK.U8 | NK.I16 | NK.U16 | NK.I32 | NK.U32;

        /// <summary>
        /// Specifies signed and unsigned integral types of width <see cref='W16'/>, <see cref='W32'/>, and <see cref='W64'/>
        /// </summary>
        public const NK Int16x32x64k = NK.I16 | NK.U16 | NK.I32 | NK.U32 | NK.I64 | NK.U64;

        /// <summary>
        /// Specifies signed and unsigned integral types of width <see cref='W8'/> and <see cref='W64'/>
        /// </summary>
        public const NK Int8x64k = NK.I8 | NK.U8 | NK.I64 | NK.U64;

        public const NK Integers8x64k = Int8x64k;

        public const NK Numeric8x16k = Int8x16k;

        public const NK UInt8k = NK.U8;

        public const NK UInt16k = NK.U16;

        public const NK UInt32k = NK.U32;

        public const NK UInt64k = NK.U64;

        public const NK UInt8x64k = Int8x64k;

        public const NK UInt8x16k = Int8x16k;

        public const NK UInt8x16x32k = Int8x16x32k;

        public const NK UInt16x32x64k = Int16x32x64k;

        /// <summary>
        /// Species the base2 singleton representative
        /// </summary>
        public static Base2 base2 => default;

        /// <summary>
        /// Species the base8 singleton representative
        /// </summary>
        public static Base3 base3 => default;

        /// <summary>
        /// Species the base8 singleton representative
        /// </summary>
        public static Base8 base8 => default;

        /// <summary>
        /// Species the base10 singleton representative
        /// </summary>
        public static Base10 base10 => default;

        /// <summary>
        /// Species the base16 singleton representative
        /// </summary>
        public static Base16 base16 => default;

        /// <summary>
        /// Canonical return value for search operation that returns a nonnegative value upon success
        /// </summary>
        public const int NotFound = -1;

        /// <summary>
        /// Zero, presented as an 8-bit signed integer
        /// </summary>
        public const sbyte Zero8i = 0;

        /// <summary>
        /// Zero, presented as an 8-bit unsigned integer
        /// </summary>
        public const byte Zero8u = 0;

        /// <summary>
        /// Zero, presented as a 16-bit signed integer
        /// </summary>
        public const short Zero16i = 0;

        /// <summary>
        /// Zero, presented as a 16-bit unsigned integer
        /// </summary>
        public const ushort Zero16u = 0;

        /// <summary>
        /// Zero, presented as a 32-bit signed integer
        /// </summary>
        public const int Zero32i = 0;

        /// <summary>
        /// Zero, presented as a 32-bit unsigned integer
        /// </summary>
        public const uint Zero32u = 0;

        /// <summary>
        /// Zero, presented as a 64-bit signed integer
        /// </summary>
        public const long Zero64i = 0;

        /// <summary>
        /// Zero, presented as a 64-bit unsigned integer
        /// </summary>
        public const ulong Zero64u = 0;

        /// <summary>
        /// Zero, presented as a 32-bit floating-point number
        /// </summary>
        public const float Zero32f = 0;

        /// <summary>
        /// Zero, presented as a 64-bit floating-point number
        /// </summary>
        public const double Zero64f = 0;

        /// <summary>
        /// Zero, presented as a 128-bit floating-point number
        /// </summary>
        public const decimal Zero128f = 0;

        /// <summary>
        /// Zero, presented as a character
        /// </summary>
        public const char Zero16c = (char)0;

        /// <summary>
        /// Zero, presented as a boolean
        /// </summary>
        public const bool Zero8b = false;

        /// <summary>
        /// The zero-value for an 8-bit signed integer
        /// </summary>
        public const sbyte z8i = Z.z8i;

        /// <summary>
        /// The zero-value for an 8-bit usigned integer
        /// </summary>
        public const byte z8 = Z.z8;

        /// <summary>
        /// The zero-value for a 16-bit signed integer
        /// </summary>
        public const short z16i = Z.z16i;

        /// <summary>
        /// The zero-value for a 16-bit unsigned integer
        /// </summary>
        public const ushort z16 = Z.z16;

        /// <summary>
        /// The zero-value for a 32-bit signed integer
        /// </summary>
        public const int z32i = Z.z32i;

        /// <summary>
        /// The zero-value for a 32-bit usigned integer
        /// </summary>
        public const uint z32 = Z.z32i;

        /// <summary>
        /// The zero-value for a 64-bit signed integer
        /// </summary>
        public const long z64i = Z.z64i;

        /// <summary>
        /// The zero-value for a 64-bit usigned integer
        /// </summary>
        public const ulong z64 = Z.z64;

        /// <summary>
        /// Zero, presented as a character
        /// </summary>
        public const char z16c = Z.z16c;

        /// <summary>
        /// The zero-value for a 32-bit float
        /// </summary>
        public const float z32f = Z.z32f;

        /// <summary>
        /// The zero-value for a 64-bit float
        /// </summary>
        public const double z64f = Z.z64f;

        /// <summary>
        /// The zero-value for a 128-bit float
        /// </summary>
        public const decimal z128f = Z.z128f;

        /// <summary>
        /// The zero-value for a bool
        /// </summary>
        public const bool z8b = Z.z8b;

        /// <summary>
        /// The zero-value for a string
        /// </summary>
        public const string zS = Z.zS;
    }
}