//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmHexCode jo(Hex8 cb)
        {
            const byte OpCode = 0x70;
            var dst = new AsmHexCode(OpCode);
            dst[1] = cb;
            dst[15] = 2;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode jo(Hex32 cb)
        {
            const ushort OpCode = 0x7080;
            var dst = new AsmHexCode(OpCode);
            ref var x = ref seek(dst.Bytes,1);
            ref var y = ref @as<byte,Hex32>(x);
            y = cb;
            dst[15] = 6;
            return dst;
        }
    }
}