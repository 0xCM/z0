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
        public static SegmentPrefix segPrefix(Instruction fx, int index) 
        {
            var k = kind(fx, index);
            switch(k)
            {
                case Memory:
                case Memory64:
                case MemorySegSI:
                case MemorySegESI:
                case MemorySegRSI:
                    return new SegmentPrefix(fx.MemorySegment);
            }
            return default;
        } 
   }
}