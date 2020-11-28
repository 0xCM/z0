//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static unsafe uint u32(bool src)
            => memory.u32(src);

        [MethodImpl(Inline)]
        public static ref uint u32<T>(in T src)
            => ref memory.u32(src);
    }
}