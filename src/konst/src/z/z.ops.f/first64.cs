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
        public static ref ulong first64<T>(Span<T> src)
            where T : unmanaged
                => ref memory.first64(src);

        [MethodImpl(Inline)]
        public static ref readonly ulong first64<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ref memory.first64(src);

        [MethodImpl(Inline)]
        public static ref readonly long first64i(ReadOnlySpan<byte> src)
            => ref memory.first64i(src);
    }
}