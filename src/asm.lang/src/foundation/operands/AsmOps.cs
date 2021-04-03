//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct AsmOps
    {
        [MethodImpl(Inline), Op]
        public static AsmRegOp reg(RegWidth width, RegClass @class, RegIndex index)
            => new AsmRegOp(width,@class,index);
    }

}