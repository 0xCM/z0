//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Typed;

    partial struct BitNumbers
    {
        [MethodImpl(Inline), Op]
        public static uint8T movlo(uint4 src, uint8T dst)
            => movzx(dst.Hi, w8) | movzx(src, w8);

        [MethodImpl(Inline), Op]
        public static uint8T movhi(uint4 src, uint8T dst)
            => movzx(dst.Lo, w8) | movzx(src, w8);
    }
}