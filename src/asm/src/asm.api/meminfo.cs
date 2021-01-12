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
        public static IceMemoryInfo meminfo(IceRegister sReg, IceRegister prefix, IceMemDirect mem, MemoryAddress address, IceMemorySize size)
            => new IceMemoryInfo(sReg, prefix, mem, address, size);

        [Op]
        public static IceMemoryInfo meminfo(IceInstruction src, byte index)
        {
            var k = kind(src, (byte)index);

            if(AsmTest.isMem(k))
            {
                var direct = AsmTest.isMemDirect(k);
                var segBase = AsmTest.isSegBase(k);
                var mem64 = AsmTest.isMem64(k);
                var info = new IceMemoryInfo();
                var sz = src.MemorySize;
                var memdirect = direct ? memDirect(src) : IceMemDirect.Empty;
                var prefix = (direct || segBase) ? src.SegmentPrefix : Z0.Asm.IceRegister.None;
                var sReg = (direct || segBase) ? src.MemorySegment : Z0.Asm.IceRegister.None;
                var address = mem64 ? src.MemoryAddress64 : 0;
                return new IceMemoryInfo(sReg, prefix, memdirect, address, sz);
            }

            return default;
        }
    }
}