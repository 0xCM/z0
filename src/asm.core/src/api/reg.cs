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

    partial struct asm
    {
        [MethodImpl(Inline)]
        public static RegOp<T> reg<T>(T src)
            where T : unmanaged, IRegOp
                => new RegOp<T>(src);

        [MethodImpl(Inline), Op]
        public static RegOp reg(RegWidth width, RegClass @class, RegIndex r)
            => AsmRegs.reg(width, @class, r);

        [MethodImpl(Inline), Op]
        public static RegOp reg(RegWidthIndex width, RegClass @class, RegIndex r)
            => AsmRegs.reg(width, @class, r);
    }
}