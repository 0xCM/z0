//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using NK = NumericKind;
    using DW = DataWidth;

    using static DataWidth;

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
        /// Specifies numeric types of width <see cref='W32'/>
        /// </summary>
        public const NK Numeric32k = NK.Width32;

        /// <summary>
        /// Specifies numeric types of width <see cref='W64'/>
        /// </summary>
        public const NK Numeric64k = NK.Width64;

        /// <summary>
        /// Specifies an unsigned itegral type of width <see cref='W8'/>
        /// </summary>
        public const NK UInt8k = NK.U8;

        /// <summary>
        /// Specifies a signed itegral type of width <see cref='W8'/>
        /// </summary>
        public const NK Int8k = NK.I8;

        /// <summary>
        /// Specifies an unsigned itegral type of width <see cref='W16'/>
        /// </summary>
        public const NK UInt16k = NK.U16;

        /// <summary>
        /// Specifies a signed itegral type of width <see cref='W16'/>
        /// </summary>
        public const NK Int16k = NK.I16;

        public const NK UInt32k = NK.U32;

        public const NK Int32k = NK.I32;

        public const NK UInt64k = NK.U64;

        public const NK Int64k = NK.I64;

        public const NK Float32k = NK.F32;

        public const NK Float64k = NK.F64;

        public const NK Numeric8x16k = NK.Width8 | NK.Width16;

        /// <summary>
        /// Specifies numeric types of width <see cref='W8'/>, <see cref='W16'/> and <see cref='W32'/>
        /// </summary>
        public const NK Numeric8x16x32k = NK.Width8 | NK.Width16 | NK.Width32;

        /// <summary>
        /// Specifies numeric types of width <see cref='W16'/> and <see cref='W32'/>
        /// </summary>
        public const NK Numeric16x32k = NK.Width16 | NK.Width32;

        /// <summary>
        /// Specifies numeric types of width <see cref='W16'/>, <see cref='W32'/>, and <see cref='W64'/>
        /// </summary>
        public const NK Numeric16x32x64k = NK.Width16 | NK.Width32 | NK.Width64;

        /// <summary>
        /// Specifies unsigned integral types of width <see cref='W16'/>, <see cref='W32'/>, and <see cref='W64'/>
        /// </summary>
        public const NK UInt16x32x64k = NK.U16 | NK.U32 | NK.U64;

        /// <summary>
        /// Specifies signed integral types of width <see cref='W16'/>, <see cref='W32'/>, and <see cref='W64'/>
        /// </summary>
        public const NK Int16x32x64k = NK.I16 | NK.I32 | NK.I64;

        /// <summary>
        /// Specifies numeric types of width <see cref='W32'/>, and <see cref='W64'/>
        /// </summary>
        public const NK Numeric32x64k = NK.Width32 | NK.Width64;

        /// <summary>
        /// Specifies unsigned numeric types of width <see cref='W8'/>, and <see cref='W16'/>
        /// </summary>
        public const NK UInt8x16k = NK.U8 | NK.U16;

        /// <summary>
        /// Specifies unsigned numeric types of width <see cref='W8'/>, <see cref='W16'/>, and <see cref='W32'/>
        /// </summary>
        public const NK UInt8x16x32k = NK.U8 | NK.U16 | NK.U32;

        /// <summary>
        /// Specifies unsigned numeric types of width <see cref='W16'/> and <see cref='W32'/>
        /// </summary>
        public const NK UInt16x32k = NK.U16 | NK.U32;
        
        /// <summary>
        /// Specifies unsigned numeric types of width <see cref='W32'/> and <see cref='W64'/>
        /// </summary>
        public const NK UInt32x64k = NK.U32 | NK.U64;

        /// <summary>
        /// Specifies signed integral types of width <see cref='W8'/> and <see cref='W64'/>
        /// </summary>
        public const NK Int8x64k = Int8k | Int64k;

        /// <summary>
        /// Specifies unsigned integral types of width <see cref='W8'/> and <see cref='W64'/>
        /// </summary>
        public const NK UInt8x64k = UInt8k | UInt64k;

        /// <summary>
        /// Specifies signed and unsigned integral types of width <see cref='W8'/> and <see cref='W64'/>
        /// </summary>
        public const NK Integers8x64k = UInt8x64k | Int8x64k;
    }
}