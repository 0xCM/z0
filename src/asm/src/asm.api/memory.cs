//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmRegMemory memory(RegisterKind @base, AsmDisplacement dx, MemoryScale scale)
            => new AsmRegMemory(@base, dx, scale);

        public static RegisterKind convert(IceRegister src, out RegisterKind dst)
        {
            dst = default;
            return dst;
        }

        [Op]
        public static AsmMemory memory(IceInstruction src, byte index)
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

    }
}