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

    partial struct AsmQuery : IAsmQuery
    {
        [MethodImpl(Inline)]
        public bool IsSegBase(OpKind src)
            => src == OpKind.MemorySegDI
            || src == OpKind.MemorySegEDI
            || src == OpKind.MemorySegESI
            || src == OpKind.MemorySegRDI
            || src == OpKind.MemorySegRSI
            || src == OpKind.MemorySegSI;

        [MethodImpl(Inline)]
        public bool IsMemEs(OpKind src)            
            => src == OpKind.MemoryESDI
            || src == OpKind.MemoryESEDI
            || src == OpKind.MemoryESRDI;

        [MethodImpl(Inline)]
        public bool IsMem64(OpKind src)
            => src == OpKind.Memory64;

        [MethodImpl(Inline)]
        public bool IsMemDirect(OpKind src)
            => src == OpKind.Memory;         
        
        [MethodImpl(Inline)]
        public bool IsMem(OpKind src)            
            => IsMemDirect(src) || IsMem64(src) || IsMemEs(src) || IsSegBase(src);

        public AsmMemInfo MemInfo(Instruction src, int index)
        {            
            var k = OperandKind(src,index);        

            if(IsMem(k))
            {
                var info = new AsmMemInfo();
                info.Size = src.MemorySize;

                if(IsMemDirect(k))
                    info.Direct = new AsmMemDirect(src.MemoryBase, src.MemoryDisplacement, src.MemoryDisplSize, src.MemoryIndexScale);

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
    }
}