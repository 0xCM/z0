//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public class Konst
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
        /// Specifies the int8 kind
        /// </summary>
        public static NK<sbyte> i8 => default;

        /// <summary>
        /// Specifies the uint8 kind
        /// </summary>
        public static NK<byte> u8 => default;

        /// <summary>
        /// Specifies the int16 kind
        /// </summary>
        public static NK<short> i16 => default;

        /// <summary>
        /// Specifies the uint16 kind
        /// </summary>
        public static NK<ushort> u16 => default;

        /// <summary>
        /// Specifies the int32 kind
        /// </summary>
        public static NK<int> i32 => default;

        /// <summary>
        /// Specifies the uint32 kind
        /// </summary>
        public static NK<uint> u32 => default;

        /// <summary>
        /// Specifies the int64 kind
        /// </summary>
        public static NK<long> i64 => default;

        /// <summary>
        /// Specifies the uint64 kind
        /// </summary>
        public static NK<ulong> u64 => default;

        /// <summary>
        /// Specifies the float32 kind
        /// </summary>
        public static NK<float> f32 => default;

        /// <summary>
        /// Specifies the float64 kind
        /// </summary>
        public static NK<double> f64 => default;        
    }
}