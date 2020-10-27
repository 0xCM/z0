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
        public static ref T subtract<T>(in T src, long count)
            => ref memory.subtract(src,count);

        [MethodImpl(Inline)]
        public static ref T subtract<T>(in T src, ulong count)
            => ref memory.subtract(src,count);
    }
}