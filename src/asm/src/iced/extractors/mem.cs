//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Asm.IceOpKind;

    partial struct IceExtractors
    {
        [Op]
        public static IceMemorySize memsize(IceInstruction src, byte index)
        {
            switch(opkind(src,(byte)index))
            {
                case Memory:
                case Memory64:
                case MemorySegSI:
                case MemorySegESI:
                case MemorySegRSI:
                case MemoryESDI:
                case MemoryESEDI:
                case MemoryESRDI:
                    return src.MemorySize;
                default:
                    return IceMemorySize.Unknown;
            }
        }

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
            dst.Displacement = asm.dx(dxvalue(src,index), dxsize(src,index));
            dst.MemorySegment = convert(memSeg(src,index), out RegisterKind _);
            dst.SegmentPrefix = convert(IceExtractors.segprefix(src,index), out RegisterKind _);
            dst.IsStackInstruction = src.IsStackInstruction;
            dst.StackPointerIncrement = src.StackPointerIncrement;
            dst.IsIPRelativeMemoryOperand = src.IsIPRelativeMemoryOperand;
            dst.IPRelativeMemoryAddress = src.IPRelativeMemoryAddress;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static MemoryScale memScale(IceInstruction src, int index)
            => opkind(src, (byte)index) == Memory ? src.MemoryIndexScale : MemoryScale.Empty;

        [MethodImpl(Inline), Op]
        public static IceMemDirect memDirect(in IceInstruction src)
            => new IceMemDirect(src.MemoryBase, src.MemoryIndexScale, asm.dx(src.MemoryDisplacement, (AsmDisplacementSize)src.MemoryDisplSize));

        [MethodImpl(Inline), Op]
        public static IceRegister memidx(IceInstruction src, byte index)
            => opkind(src, (byte)index) == Memory ? src.MemoryIndex : 0;

        [MethodImpl(Inline), Op]
        public static IceRegister memBase(IceInstruction src, byte index)
            => opkind(src,index) == Memory ? src.MemoryBase : 0;

        [MethodImpl(Inline), Op]
        public static uint dxvalue(IceInstruction src, byte index)
            => opkind(src, (byte)index) == Memory ? src.MemoryDisplacement : 0;

        [MethodImpl(Inline), Op]
        public static AsmDisplacementSize dxsize(in IceInstruction src, byte index)
            => opkind(src,index) == Memory ? (AsmDisplacementSize)src.MemoryDisplSize : 0;

        [MethodImpl(Inline), Op]
        public static IceRegister memSeg(in IceInstruction src, byte index)
        {
            switch(opkind(src,index))
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