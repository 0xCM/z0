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
        public static ref char c16<T>(in T src)
            => ref memory.c16(src);

        [MethodImpl(Inline)]
        public static ref char c16<T>(in T src, int offset)
            => ref memory.c16<T>(src, offset);
    }
}