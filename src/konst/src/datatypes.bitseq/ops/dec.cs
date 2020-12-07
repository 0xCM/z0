//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct BitSeq
    {
        [MethodImpl(Inline), Op]
        public static uint7 dec(uint7 x)
            => !x.IsMin ? new uint7(Bytes.sub(x.data, 1), false) : Z0.uint7.Max;

        [MethodImpl(Inline), Op]
        public static uint8T dec(uint8T x)
            => !x.IsMin ? new uint8T(Bytes.sub(x.data, 1)) : Z0.uint8T.Max;
    }
}