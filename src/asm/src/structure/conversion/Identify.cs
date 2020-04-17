//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using W = FixedWidth;
    using NI = NumericIndicator;

	partial class XTend
    {
        public static SegmentedIdentity Identify(this MemorySize src, TypeIndicator ti)
            => src switch {
                    MemorySize.Packed128_Int8 => (ti, W.W128, W.W8, NI.Signed),
                    MemorySize.Packed128_UInt8 => (ti, W.W128, W.W8, NI.Unsigned),
                    MemorySize.Packed128_Int16 => (ti, W.W128, W.W16, NI.Signed),
                    MemorySize.Packed128_UInt16 => (ti,W.W128, W.W16, NI.Unsigned),
                    MemorySize.Packed128_Int32 => (ti, W.W128, W.W32, NI.Signed),
                    MemorySize.Packed128_UInt32 => (ti, W.W128, W.W32, NI.Unsigned),
                    MemorySize.Packed128_Int64 => (ti, W.W128, W.W64, NI.Signed),
                    MemorySize.Packed128_UInt64 => (ti, W.W128, W.W64, NI.Unsigned),
                    MemorySize.Packed128_Float32 => (ti, W.W128, W.W32, NI.Float),
                    MemorySize.Packed128_Float64 => (ti, W.W128, W.W64, NI.Float),
                    MemorySize.Packed256_Int8 => (ti, W.W256, W.W8, NI.Signed),
                    MemorySize.Packed256_UInt8 => (ti, W.W256, W.W8, NI.Unsigned),
                    MemorySize.Packed256_Int16 => (ti, W.W256, W.W16, NI.Signed),
                    MemorySize.Packed256_UInt16 => (ti, W.W256, W.W16, NI.Unsigned),
                    MemorySize.Packed256_Int32 => (ti, W.W256, W.W32, NI.Signed),
                    MemorySize.Packed256_UInt32 => (ti, W.W256, W.W32, NI.Unsigned),
                    MemorySize.Packed256_Int64 => (ti, W.W256, W.W64, NI.Signed),
                    MemorySize.Packed256_UInt64 => (ti, W.W256, W.W64, NI.Unsigned),
                    MemorySize.Packed256_Float32 => (ti, W.W256, W.W32, NI.Float),
                    MemorySize.Packed256_Float64 => (ti, W.W256, W.W64, NI.Float),
                    _ => SegmentedIdentity.Empty
            };
    }
}