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
        public static ref uint first32<T>(Span<T> src)
            where T : unmanaged
                => ref memory.first32(src);

        [MethodImpl(Inline)]
        public static ref readonly uint first32<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ref memory.first32(src);
    }
}