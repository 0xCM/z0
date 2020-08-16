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
        /// <summary>
        /// Extracts memory information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        [MethodImpl(Inline), Op]
        public static InstructionMemory memory(Instruction src, byte index)            
        {
            var dst = default(InstructionMemory);
            dst.MemoryBase = memBase(src,index);
            dst.MemoryIndex = memIdx(src,index);
            dst.MemorySize = memSize(src,index);
            dst.MemoryIndexScale = memScale(src,index);
            dst.MemDx = memDx(memDx(src,index), memDxSize(src,index));
            dst.MemorySegment = memSeg(src,index);
            dst.SegmentPrefix = regSegPrefix(src,index);
            dst.IsStackInstruction = src.IsStackInstruction;
            dst.StackPointerIncrement = src.StackPointerIncrement;
            dst.IsIPRelativeMemoryOperand = src.IsIPRelativeMemoryOperand;
            dst.IPRelativeMemoryAddress = src.IPRelativeMemoryAddress;
            return dst;
        }
    }
}