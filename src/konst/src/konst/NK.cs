//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using NK = NumericKind;
    using DW = DataWidth;

    partial struct Konst
    {
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

        public const NK Floats = NK.Floats;

        public const NK AllNumeric = NK.All;

        /// <summary>
        /// Specifies numeric types of width <see cref='W8'/>
        /// </summary>
        public const NK Numeric8k = NK.Width8;

        /// <summary>
        /// Specifies numeric types of width <see cref='W16'/>
        /// </summary>
        public const NK Numeric16k = NK.Width16;

        /// <summary>
        /// Specifies numeric types of width <see cref='W32'/>
        /// </summary>
        public const NK Numeric32k = NK.Width32;

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
        /// Defines a <see cref='U8'/> representative
        /// </summary>
        public static U8 t8u => default;

        /// <summary>
        /// Defines a global <see cref='I8'/> representative
        /// </summary>
        public static I8 t8i => default;

        /// <summary>
        /// Defines a global <see cref='U16'/> representative
        /// </summary>
        public static U16 t16u => default;

        /// <summary>
        /// Defines a global <see cref='I16'/> representative
        /// </summary>
        public static I16 t16i => default;

        /// <summary>
        /// Defines a global <see cref='U32'/> representative
        /// </summary>
        public static U32 t32u => default;

        /// <summary>
        /// Defines a global <see cref='I32'/> representative
        /// </summary>
        public static I32 t32i => default;

        /// <summary>
        /// Defines a global <see cref='U64'/> representative
        /// </summary>
        public static U64 t64u => default;

        /// <summary>
        /// Defines a global <see cref='I64'/> representative
        /// </summary>
        public static I64 t64i => default;

        public static F32 t32f => default;

        public static F64 t64f => default;
    }
}