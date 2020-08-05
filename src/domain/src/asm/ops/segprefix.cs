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
    using static Asm.OpKind;
   
    partial struct asm
    {
        [Op]
        public static SegmentPrefix segprefix(Instruction inxs, int index) 
        {
            var k = kind(inxs, index);
            switch(k)
            {
                case Memory:
                case Memory64:
                case MemorySegSI:
                case MemorySegESI:
                case MemorySegRSI:
                    return new SegmentPrefix(inxs.MemorySegment);
            }
            return SegmentPrefix.Empty;
        }

        [MethodImpl(Inline), Op]
        public static Register regsegprefix(Instruction src, int index)
        {
            switch(kind(src,index))
            {
                case Memory:
                case Memory64:
                case MemorySegSI:
                case MemorySegESI:
                case MemorySegRSI:
                    return src.MemorySegment;
                default:
                    return 0;
            }
        }        
    }
}