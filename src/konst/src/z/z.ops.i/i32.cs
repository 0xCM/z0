//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static unsafe int i32(bool src)
            => memory.i32(src);

        [MethodImpl(Inline)]
        public static ref int i32<T>(in T src)
            => ref memory.i32(src);
    }
}