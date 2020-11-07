//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using NI = NumericIndicator;
    using TI = TypeIndicator;
    using MZ = Asm.MemorySize;
    using NK = NumericKind;
    using SI = SegmentedIdentity;
    using FIX = CellWidth;

    using static Konst;

    using Z0.Asm;

    partial struct asm
    {
        /// <summary>
        /// Assigns identity to a <see cref='MemorySize'/> specification
        /// </summary>
        /// <param name="src">A memory size specification</param>
        [Op]
        public static SegmentedIdentity identify(MemorySize src)
            => src switch {
                    MZ.UInt8 => NK.U8,
                    MZ.UInt16 => NK.U16,
                    MZ.UInt32 => NK.U32,
                    MZ.UInt64 => NK.U64,
                    MZ.Int8 => NK.I8,
                    MZ.Int16 => NK.I16,
                    MZ.Int32 => NK.I32,
                    MZ.Int64 => NK.I64,
                    MZ.Float32 => NK.F32,
                    MZ.Float64 => NK.F64,
                    MZ.Packed128_Int8 => (TI.Signed, FIX.W128, FIX.W8, NI.Signed),
                    MZ.Packed128_UInt8 => (TI.Unsigned, FIX.W128, FIX.W8, NI.Unsigned),
                    MZ.Packed128_Int16 => (TI.Signed, FIX.W128, FIX.W16, NI.Signed),
                    MZ.Packed128_UInt16 => (TI.Unsigned, FIX.W128, FIX.W16, NI.Unsigned),
                    MZ.Packed128_Int32 => (TI.Signed, FIX.W128, FIX.W32, NI.Signed),
                    MZ.Packed128_UInt32 => (TI.Unsigned, FIX.W128, FIX.W32, NI.Unsigned),
                    MZ.Packed128_Int64 => (TI.Signed, FIX.W128, FIX.W64, NI.Signed),
                    MZ.Packed128_UInt64 => (TI.Unsigned, FIX.W128, FIX.W64, NI.Unsigned),
                    MZ.Packed128_Float32 => (TI.Float, FIX.W128, FIX.W32, NI.Float),
                    MZ.Packed128_Float64 => (TI.Float, FIX.W128, FIX.W64, NI.Float),
                    MZ.Packed256_Int8 => (TI.Signed, FIX.W256, FIX.W8, NI.Signed),
                    MZ.Packed256_UInt8 => (TI.Unsigned, FIX.W256, FIX.W8, NI.Unsigned),
                    MZ.Packed256_Int16 => (TI.Signed, FIX.W256, FIX.W16, NI.Signed),
                    MZ.Packed256_UInt16 => (TI.Unsigned, FIX.W256, FIX.W16, NI.Unsigned),
                    MZ.Packed256_Int32 => (TI.Signed, FIX.W256, FIX.W32, NI.Signed),
                    MZ.Packed256_UInt32 => (TI.Unsigned, FIX.W256, FIX.W32, NI.Unsigned),
                    MZ.Packed256_Int64 => (TI.Signed, FIX.W256, FIX.W64, NI.Signed),
                    MZ.Packed256_UInt64 => (TI.Unsigned, FIX.W256, FIX.W64, NI.Unsigned),
                    MZ.Packed256_Float32 => (TI.Float, FIX.W256, FIX.W32, NI.Float),
                    MZ.Packed256_Float64 => (TI.Float, FIX.W256, FIX.W64, NI.Float),
                    MZ.Unknown => SI.Empty,
                    _ => SI.from(src.ToString())
            };
    }
}