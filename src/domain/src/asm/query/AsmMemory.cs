//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using FW = FixedWidth;
    using NI = NumericIndicator;
    using TI = TypeIndicator;
    using MZ = Asm.MemorySize;
    using NK = NumericKind;
    using SI = SegmentedIdentity;
    using NW = NumericWidth;
    using FIX = FixedWidth;

    using static Konst;    

    partial struct AsmQuery : TSemanticQuery
    {
        public bool IsSegBase(OpKind src)
            => asm.testsegbase(src);

        public bool IsSegEs(OpKind src)            
            => src == OpKind.MemoryESDI
            || src == OpKind.MemoryESEDI
            || src == OpKind.MemoryESRDI;

        public bool IsMem64(OpKind src)
            => src == OpKind.Memory64;

        public bool IsMemDirect(OpKind src)
            => src == OpKind.Memory;         
        
        public bool IsMem(OpKind src)            
            => IsMemDirect(src) || IsMem64(src) || IsSegEs(src) || IsSegBase(src);

        public InstructionMemory InxsMemory(Instruction src, int index)
            => InstructionMemory.From(src,index);

        public bool HasInxsMemory(Instruction src, int index)
            => InstructionMemory.Has(src,index);
            
        public MemInfo MemInfo(Instruction src, int index)
        {            
            var k = OperandKind(src, index);        

            if(IsMem(k))
            {
                var isDirect = IsMemDirect(k);
                var isSegBase = IsSegBase(k);

                var info = new MemInfo();
                var sz = src.MemorySize;
                var memdirect = IsMemDirect(k) ? MemDirect.From(src) : MemDirect.Empty;
                var prefix = (isDirect || isSegBase) ? src.SegmentPrefix : Register.None;
                var segreg = (isDirect || isSegBase) ? src.MemorySegment : Register.None;
                var mem64 = IsMem64(k) ? src.MemoryAddress64 : 0;
                return asm.meminfo(segreg, prefix, memdirect, mem64, sz);
            }

            return default;
        } 
 
        /// <summary>
        /// Specifies the segmented identity of a specified memory size
        /// </summary>
        /// <param name="src">The source value</param>
        public SegmentedIdentity Identify(MemorySize src)
            => identify(src);


        /// <summary>
        /// Specifies the segmented identity of a specified memory size
        /// </summary>
        /// <param name="src">The source value</param>
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