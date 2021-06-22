//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;

    partial struct AsmRegs
    {
        [StructLayout(LayoutKind.Sequential, Size = 2)]
        public readonly struct RegSpec
        {

        }

        [MethodImpl(Inline), Op]
        public static RegSpec reg(RegWidth width, RegClass @class, RegIndex index)
            => to(math.or(math.sll((ushort)width,3), math.sll((ushort)@class,5) , math.sll((ushort)index, 10)), out RegSpec _);
    }
}
