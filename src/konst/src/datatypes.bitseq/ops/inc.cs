//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using Q = Z0;

    partial struct BitSeq
    {
        [MethodImpl(Inline), Op]
        public static uint7 inc(uint7 x)
            => !x.IsMax ? new uint7(memory.add(x.data, 1), false) : Q.uint7.Min;

        [MethodImpl(Inline), Op]
        public static uint8T inc(uint8T x)
            => !x.IsMax ? new uint8T(memory.add(x.data, 1)) : Q.uint8T.Min;
    }
}