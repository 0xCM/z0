//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static math;

    partial struct AsmRegs
    {
        [MethodImpl(Inline), Op]
        public static RegOp reg(RegWidth width, RegClass @class, RegIndexCode r)
            => new RegOp(or((byte)index(width), sll((ushort)@class, 5), sll((ushort)r, 10)));

        [MethodImpl(Inline), Op]
        public static RegOp reg(RegWidthIndex width, RegClass @class, RegIndexCode r)
            => new RegOp(or((byte)width, sll((ushort)@class, 5), sll((ushort)r, 10)));
    }
}