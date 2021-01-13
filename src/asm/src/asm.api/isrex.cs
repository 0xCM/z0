//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static BitSeq4;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static bool isrex(byte src)
            => (uint4)(src >> 4) == b0100;
    }
}