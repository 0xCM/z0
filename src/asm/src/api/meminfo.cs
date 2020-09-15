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
        public static MemInfo meminfo(IceRegister sReg, IceRegister prefix, MemDirect mem, MemoryAddress address, MemorySize size)
            => new MemInfo(sReg, prefix, mem, address, size);

        [Op]
        public static MemInfo meminfo(Instruction src, byte index)
        {
            var k = kind(src, (byte)index);

            if(isMem(k))
            {
                var direct = isMemDirect(k);
                var segBase = isSegBase(k);
                var mem64 = isMem64(k);
                var info = new MemInfo();
                var sz = src.MemorySize;
                var memdirect = direct ? memDirect(src) : MemDirect.Empty;
                var prefix = (direct || segBase) ? src.SegmentPrefix : Z0.Asm.IceRegister.None;
                var sReg = (direct || segBase) ? src.MemorySegment : Z0.Asm.IceRegister.None;
                var address = mem64 ? src.MemoryAddress64 : 0;
                return new MemInfo(sReg, prefix, memdirect, address, sz);
            }

            return default;
        }
    }
}