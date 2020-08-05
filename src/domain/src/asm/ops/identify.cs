//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
        
    using static Konst;

    using FW = FixedWidth;
    using NI = NumericIndicator;
    using TI = TypeIndicator;
    using MZ = Asm.MemorySize;
    using NK = NumericKind;
    using SI = SegmentedIdentity;
    using NW = NumericWidth;
   
    partial struct asm
    {
        /// <summary>
        /// Specifies the segmented identity of a specified memory size
        /// </summary>
        /// <param name="src">The source value</param>
        [Op]
        public static SI identify(MemorySize src)
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
                    MZ.Packed128_Int8 => (TI.Signed, FW.W128, FW.W8, NI.Signed),
                    MZ.Packed128_UInt8 => (TI.Unsigned, FW.W128, FW.W8, NI.Unsigned),
                    MZ.Packed128_Int16 => (TI.Signed, FW.W128, FW.W16, NI.Signed),
                    MZ.Packed128_UInt16 => (TI.Unsigned, FW.W128, FW.W16, NI.Unsigned),
                    MZ.Packed128_Int32 => (TI.Signed, FW.W128, FW.W32, NI.Signed),
                    MZ.Packed128_UInt32 => (TI.Unsigned, FW.W128, FW.W32, NI.Unsigned),
                    MZ.Packed128_Int64 => (TI.Signed, FW.W128, FW.W64, NI.Signed),
                    MZ.Packed128_UInt64 => (TI.Unsigned, FW.W128, FW.W64, NI.Unsigned),
                    MZ.Packed128_Float32 => (TI.Float, FW.W128, FW.W32, NI.Float),
                    MZ.Packed128_Float64 => (TI.Float, FW.W128, FW.W64, NI.Float),
                    MZ.Packed256_Int8 => (TI.Signed, FW.W256, FW.W8, NI.Signed),
                    MZ.Packed256_UInt8 => (TI.Unsigned, FW.W256, FW.W8, NI.Unsigned),
                    MZ.Packed256_Int16 => (TI.Signed, FW.W256, FW.W16, NI.Signed),
                    MZ.Packed256_UInt16 => (TI.Unsigned, FW.W256, FW.W16, NI.Unsigned),
                    MZ.Packed256_Int32 => (TI.Signed, FW.W256, FW.W32, NI.Signed),
                    MZ.Packed256_UInt32 => (TI.Unsigned, FW.W256, FW.W32, NI.Unsigned),
                    MZ.Packed256_Int64 => (TI.Signed, FW.W256, FW.W64, NI.Signed),
                    MZ.Packed256_UInt64 => (TI.Unsigned, FW.W256, FW.W64, NI.Unsigned),
                    MZ.Packed256_Float32 => (TI.Float, FW.W256, FW.W32, NI.Float),
                    MZ.Packed256_Float64 => (TI.Float, FW.W256, FW.W64, NI.Float),
                    MZ.Unknown => SI.Empty,
                    _ => SI.from(src.ToString())
            };


        [MethodImpl(Inline), Op]
        public static SI identify(TI si, int totalwidth, int segwidth, char ni)
        {
            if(Enum.IsDefined(typeof(FW), (uint)totalwidth) && Enum.IsDefined(typeof(FW), (uint)segwidth) && Enum.IsDefined(typeof(NI), (ushort)ni)) 
            {
                var nk = NumericKinds.kind((NW)segwidth, (NI)ni);            
                return SI.identify(si, (FW)totalwidth, nk);                    
            }
            else
                return SI.Empty;
        }
    }
}