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
        public static RegisterKind convert(IceRegister src, out RegisterKind dst)
        {
            dst = default;
            return dst;
        }

        [Op]
        public static AsmMemory memory2(Instruction src, byte index)
        {
            var dst = new AsmMemory();
            dst.MemoryBase = convert(memBase(src,index), out RegisterKind _);
            dst.MemoryIndex = convert(memidx(src,index), out RegisterKind _);
            dst.MemorySize = memsize(src,index);
            dst.MemoryIndexScale = memScale(src,index);
            dst.Displacement = dx(dxvalue(src,index), dxsize(src,index));
            dst.MemorySegment = convert(memSeg(src,index), out RegisterKind _);
            dst.SegmentPrefix = convert(segprefix(src,index), out RegisterKind _);
            dst.IsStackInstruction = src.IsStackInstruction;
            dst.StackPointerIncrement = src.StackPointerIncrement;
            dst.IsIPRelativeMemoryOperand = src.IsIPRelativeMemoryOperand;
            dst.IPRelativeMemoryAddress = src.IPRelativeMemoryAddress;
            return dst;
        }

        /// <summary>
        /// Extracts memory information, if applicable, from an instruction operand
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="index">The operand index</param>
        [MethodImpl(Inline), Op]
        public static AsmFxMemory memory(Instruction src, byte index)
        {
            var dst = default(AsmFxMemory);
            dst.MemoryBase = memBase(src,index);
            dst.MemoryIndex = memidx(src,index);
            dst.MemorySize = memsize(src,index);
            dst.MemoryIndexScale = memScale(src,index);
            dst.MemDx = dx(dxvalue(src,index), dxsize(src,index));
            dst.MemorySegment = memSeg(src,index);
            dst.SegmentPrefix = segprefix(src,index);
            dst.IsStackInstruction = src.IsStackInstruction;
            dst.StackPointerIncrement = src.StackPointerIncrement;
            dst.IsIPRelativeMemoryOperand = src.IsIPRelativeMemoryOperand;
            dst.IPRelativeMemoryAddress = src.IPRelativeMemoryAddress;
            return dst;
        }
    }
}