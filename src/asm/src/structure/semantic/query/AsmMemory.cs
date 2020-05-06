//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;

    using W = FixedWidth;
    using NI = NumericIndicator;
    using TI = TypeIndicator;

    partial struct AsmQuery : ISemanticQuery
    {
        [MethodImpl(Inline), Op]
        public bool IsSegBase(OpKind src)
            => src == OpKind.MemorySegDI
            || src == OpKind.MemorySegEDI
            || src == OpKind.MemorySegESI
            || src == OpKind.MemorySegRDI
            || src == OpKind.MemorySegRSI
            || src == OpKind.MemorySegSI;

        [MethodImpl(Inline), Op]
        public bool IsSegEs(OpKind src)            
            => src == OpKind.MemoryESDI
            || src == OpKind.MemoryESEDI
            || src == OpKind.MemoryESRDI;

        [MethodImpl(Inline), Op]
        public bool IsMem64(OpKind src)
            => src == OpKind.Memory64;

        [MethodImpl(Inline), Op]
        public bool IsMemDirect(OpKind src)
            => src == OpKind.Memory;         
        
        [MethodImpl(Inline), Op]
        public bool IsMem(OpKind src)            
            => IsMemDirect(src) || IsMem64(src) || IsSegEs(src) || IsSegBase(src);

        [Op]
        public AsmMemInfo MemInfo(Instruction src, int index)
        {            
            var k = OperandKind(src,index);        

            if(IsMem(k))
            {
                var info = new AsmMemInfo();
                info.Size = src.MemorySize;

                if(IsMemDirect(k))
                    info.Direct = AsmMemDirect.From(src);

                if(IsMemDirect(k) || IsSegBase(k))
                {
                    info.SegmentPrefix = src.SegmentPrefix;                    
                    info.SegmentRegister = src.MemorySegment;
                }

                if(IsMem64(k))
                    info.Address = src.MemoryAddress64;                

                return info;
            }

            return AsmMemInfo.Empty;
        } 

        /// <summary>
        /// Specifies the segmented identity of a specified memory size
        /// </summary>
        /// <param name="src">The source value</param>
        public SegmentedIdentity Identify(MemorySize src)
            => src switch {
                    MemorySize.Packed128_Int8 => (TI.Signed, W.W128, W.W8, NI.Signed),
                    MemorySize.Packed128_UInt8 => (TI.Unsigned, W.W128, W.W8, NI.Unsigned),
                    MemorySize.Packed128_Int16 => (TI.Signed, W.W128, W.W16, NI.Signed),
                    MemorySize.Packed128_UInt16 => (TI.Unsigned, W.W128, W.W16, NI.Unsigned),
                    MemorySize.Packed128_Int32 => (TI.Signed, W.W128, W.W32, NI.Signed),
                    MemorySize.Packed128_UInt32 => (TI.Unsigned, W.W128, W.W32, NI.Unsigned),
                    MemorySize.Packed128_Int64 => (TI.Signed, W.W128, W.W64, NI.Signed),
                    MemorySize.Packed128_UInt64 => (TI.Unsigned, W.W128, W.W64, NI.Unsigned),
                    MemorySize.Packed128_Float32 => (TI.Float, W.W128, W.W32, NI.Float),
                    MemorySize.Packed128_Float64 => (TI.Float, W.W128, W.W64, NI.Float),
                    MemorySize.Packed256_Int8 => (TI.Signed, W.W256, W.W8, NI.Signed),
                    MemorySize.Packed256_UInt8 => (TI.Unsigned, W.W256, W.W8, NI.Unsigned),
                    MemorySize.Packed256_Int16 => (TI.Signed, W.W256, W.W16, NI.Signed),
                    MemorySize.Packed256_UInt16 => (TI.Unsigned, W.W256, W.W16, NI.Unsigned),
                    MemorySize.Packed256_Int32 => (TI.Signed, W.W256, W.W32, NI.Signed),
                    MemorySize.Packed256_UInt32 => (TI.Unsigned, W.W256, W.W32, NI.Unsigned),
                    MemorySize.Packed256_Int64 => (TI.Signed, W.W256, W.W64, NI.Signed),
                    MemorySize.Packed256_UInt64 => (TI.Unsigned, W.W256, W.W64, NI.Unsigned),
                    MemorySize.Packed256_Float32 => (TI.Float, W.W256, W.W32, NI.Float),
                    MemorySize.Packed256_Float64 => (TI.Float, W.W256, W.W64, NI.Float),
                    MemorySize.Unknown => SegmentedIdentity.Empty,
                    _ => SegmentedIdentity.Set(src.ToString())
            };

    }
}