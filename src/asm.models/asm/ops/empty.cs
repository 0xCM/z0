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
        
    partial struct asm
    {        
        [MethodImpl(Inline), Op]
        public static bool empty(in InstructionMemory src)
        {
            var empty = true;
            empty &= (src.MemoryBase == 0);
            empty &= (src.MemoryIndex == 0);
            empty &= (src.MemorySize == 0);
            empty &= (src.MemoryIndexScale.IsEmpty);
            empty &= (src.MemDx.IsEmpty);
            empty &= (src.MemorySegment == 0);
            empty &= (src.SegmentPrefix == 0);
            empty &= (!src.IsStackInstruction);
            empty &= (src.StackPointerIncrement == 0);            
            empty &= (!src.IsIPRelativeMemoryOperand);
            return empty;
        }
    }
}