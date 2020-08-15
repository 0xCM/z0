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
        [MethodImpl(Inline), Op]
        public static InstructionMemory memory(Instruction src, byte index)            
        {
            var dst = default(InstructionMemory);
            dst.MemoryBase = asm.membase(src,index);
            dst.MemoryIndex = asm.memidx(src,index);
            dst.MemorySize = asm.memsize(src,index);
            dst.MemoryIndexScale = asm.memscale(src,index);
            dst.MemDx = asm.memdx(asm.memdx(src,index), asm.memdxsize(src,index));
            dst.MemorySegment = asm.memseg(src,index);
            dst.SegmentPrefix = regsegprefix(src,index);
            dst.IsStackInstruction = src.IsStackInstruction;
            dst.StackPointerIncrement = src.StackPointerIncrement;
            dst.IsIPRelativeMemoryOperand = src.IsIPRelativeMemoryOperand;
            dst.IPRelativeMemoryAddress = src.IPRelativeMemoryAddress;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Register membase(Instruction src, int index)
            => kind(src,index) == Memory ? src.MemoryBase : 0;
    }
}