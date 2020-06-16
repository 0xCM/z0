//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public readonly partial struct Konst
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public const MethodImplOptions NotInline = MethodImplOptions.NoInlining;

        public const MethodImplOptions Suboptimal = MethodImplOptions.NoOptimization;

        public const string Kernel32 = "kernel32.dll";

        public const NumericKind UnsignedInts = NumericKind.UnsignedInts;

        public const NumericKind SignedInts = NumericKind.SignedInts;

        public const NumericKind Integers = NumericKind.Integers;

        public const NumericKind Floats = NumericKind.Floats;

        public const NumericKind AllNumeric = NumericKind.All;

        public const NumericKind Numeric8 = NumericKind.Width8;

        public const NumericKind Numeric16 = NumericKind.Width16;

        public const NumericKind Numeric32 = NumericKind.Width32;

        public const NumericKind Numeric64 = NumericKind.Width64;

        public const NumericKind Numeric8u = NumericKind.U8;

        public const NumericKind Numeric8i = NumericKind.I8;

        public const NumericKind Numeric16u = NumericKind.U16;

        public const NumericKind Numeric16i = NumericKind.I16;

        public const NumericKind Numeric32u = NumericKind.U32;

        public const NumericKind Numeric32i = NumericKind.I32;

        public const NumericKind Numeric64u = NumericKind.U64;

        public const NumericKind Numeric64i = NumericKind.I64;

        public const NumericKind Numeric32f = NumericKind.F32;

        public const NumericKind Numeric64f = NumericKind.F64;

        public const NumericKind Numeric8x16 = NumericKind.Width8 | NumericKind.Width16;

        public const NumericKind Numeric8x16x32 = NumericKind.Width8 | NumericKind.Width16 | NumericKind.Width32;

        public const NumericKind Numeric16x32 = NumericKind.Width16 | NumericKind.Width32;

        public const NumericKind Numeric16x32x64 = NumericKind.Width16 | NumericKind.Width32 | NumericKind.Width64;

        public const NumericKind Numeric16x32x64u = NumericKind.U16 | NumericKind.U32 | NumericKind.U64;

        public const NumericKind Numeric16x32x64i = NumericKind.I16 | NumericKind.I32 | NumericKind.I64;

        public const NumericKind Numeric32x64 = NumericKind.Width32 | NumericKind.Width64;

        public const NumericKind Numeric8x16u = NumericKind.U8 | NumericKind.U16;

        public const NumericKind Numeric8x16x32u = NumericKind.U8 | NumericKind.U16 | NumericKind.U32;

        public const NumericKind Numeric16x32u = NumericKind.U16 | NumericKind.U32;
        
        public const NumericKind Numeric32x64u = NumericKind.U32 | NumericKind.U64;

        /// <summary>
        /// The empty type
        /// </summary>
        public static Type TEmpty => typeof(void);

        /// <summary>
        /// An abbreviation for the ridiculously long "StringComparison.InvariantCultureIgnoreCase"
        /// </summary>
        public const StringComparison NoCase = StringComparison.InvariantCultureIgnoreCase;

        /// <summary>
        /// An abbreviation for the somewhat verbose "StringComparison.InvariantCulture"
        /// </summary>
        public const StringComparison Cased = StringComparison.InvariantCulture;

        public const char FilePathSep = '/';

        /// <summary>
        /// The number of bits to shift a field specifier left/right to reveal/specify the width of an identified field
        /// </summary>
        public const int WidthOffset = 16;        

        /// <summary>
        /// The default delimiter to use when formatting structured text
        /// </summary>
        public const char FieldDelimiter = Chars.Pipe;

        /// <summary>
        /// What else could this be?
        /// </summary>
        public const string EmptyString = "";

        /// <summary>
        /// What else could this be?
        /// </summary>
        public const string Space = " ";

        public const FileWriteMode Overwrite = FileWriteMode.Overwrite;

        public const FileWriteMode Append = FileWriteMode.Append;

        /// <summary>
        /// The largest representable value v where v:uint8
        /// </summary>
        public const byte Max8u = byte.MaxValue;

        /// <summary>
        /// The largest representable value v where v:uint16
        /// </summary>
        public const ushort Max16u = ushort.MaxValue;

        /// <summary>
        /// The largest representable value v where v:uint24
        /// </summary>
        public const uint Max24u = (uint)Max16u | ((uint)Max8u << 16);

        /// <summary>
        /// The largest representable value v where v:uint32
        /// </summary>
        public const uint Max32u = uint.MaxValue;

        /// <summary>
        /// The largest representable value v where v:uint40
        /// </summary>
        public const ulong Max40u = (ulong)Max32u | ((ulong)Max8u << 32);

        /// <summary>
        /// The largest representable value v where v:uint48
        /// </summary>
        public const ulong Max48u = (ulong)Max40u | ((ulong)Max8u << 40);

        /// <summary>
        /// The largest representable value v where v:uint56
        /// </summary>
        public const ulong Max56u = (ulong)Max48u | ((ulong)Max8u << 48);

        /// <summary>
        /// The largest representable value v where v:uint64
        /// </summary>
        public const ulong Max64u = ulong.MaxValue;

        /// <summary>
        /// The largest representable value v where v:float32
        /// </summary>
        public const float Max32f = float.MaxValue;

        /// <summary>
        /// The largest representable value v where v:float64
        /// </summary>
        public const double Max64f = double.MaxValue;

        /// <summary>
        /// The largest representable value v where v:int8
        /// </summary>
        public const sbyte Max8i = sbyte.MaxValue;

        /// <summary>
        /// The largest representable value v where v:int16
        /// </summary>
        public const short Max16i = short.MaxValue;

        /// <summary>
        /// The largest representable value v where v:int32
        /// </summary>
        public const int Max32i = int.MaxValue;

        /// <summary>
        /// The largest representable value v where v:int64
        /// </summary>
        public const long Max64i = long.MaxValue;        


        /// <summary>
        /// One, presented as an 8-bit signed integer
        /// </summary>
        public const sbyte One8i = 1;

        /// <summary>
        /// One, presented as an 8-bit unsigned integer
        /// </summary>
        public const byte One8u = 1;

        /// <summary>
        /// One, presented as a 16-bit signed integer
        /// </summary>
        public const short One16i = 1;

        /// <summary>
        /// One, presented as a 16-bit unsigned integer
        /// </summary>
        public const ushort One16u = 1;

        /// <summary>
        /// One, presented as a 32-bit signed integer
        /// </summary>
        public const int One32i = 1;

        /// <summary>
        /// One, presented as a 32-bit unsigned integer
        /// </summary>
        public const uint One32u = 1;

        /// <summary>
        /// One, presented as a 64-bit signed integer
        /// </summary>
        public const long One64i = 1;

        /// <summary>
        /// One, presented as a 64-bit unsigned integer
        /// </summary>
        public const ulong One64u = 1;

        /// <summary>
        /// One, presented as a 32-bit floating-point number
        /// </summary>
        public const float One32f = 1;

        /// <summary>
        /// One, presented as a 64-bit floating-point number
        /// </summary>
        public const double One64f = 1;


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
        /// The zero-value for an 8-bit signed integer
        /// </summary>
        public const sbyte z8i = 0;

        /// <summary>
        /// The zero-value for an 8-bit usigned integer
        /// </summary>
        public const byte z8 = 0;

        /// <summary>
        /// The zero-value for a 16-bit signed integer
        /// </summary>
        public const short z16i = 0;

        /// <summary>
        /// The zero-value for a 16-bit unsigned integer
        /// </summary>
        public const ushort z16 = 0;

        /// <summary>
        /// The zero-value for a 32-bit signed integer
        /// </summary>
        public const int z32i = 0;

        /// <summary>
        /// The zero-value for a 32-bit usigned integer
        /// </summary>
        public const uint z32 = 0;

        /// <summary>
        /// The zero-value for a 64-bit signed integer
        /// </summary>
        public const long z64i = 0;

        /// <summary>
        /// The zero-value for a 64-bit usigned integer
        /// </summary>
        public const ulong z64 = 0;

        /// <summary>
        /// The zero-value for a 32-bit float
        /// </summary>
        public const float z32f = 0;

        /// <summary>
        /// The zero-value for a 64-bit float
        /// </summary>
        public const double z64f = 0;

        /// <summary>
        /// The smallest representable value v where v:int8
        /// </summary>
        public const sbyte Min8i = sbyte.MinValue;

        /// <summary>
        /// The smallest representable value v where v:int16
        /// </summary>
        public const short Min16i = short.MinValue;

        /// <summary>
        /// The smallest representable value v where v:int32
        /// </summary>
        public const int Min32i = int.MinValue;

        /// <summary>
        /// The smallest representable value v where v:int64
        /// </summary>
        public const long Min64i = long.MinValue;

        /// <summary>
        /// The smallest representable value v where v:float32
        /// </summary>
        public const float Min32f = float.MinValue;

        /// <summary>
        /// The smallest representable value v where v:float64
        /// </summary>
        public const double Min64f = double.MinValue;

        public const byte AsciNone = (byte)AsciCharCode.Null;

        public const int NotFound = -1;
    }
}