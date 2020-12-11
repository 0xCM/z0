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
        public static T read<T>(ReadOnlySpan<byte> src)
            where T : struct
                => memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref T read<T>(Span<byte> src)
            => ref memory.read<T>(src);
    }
}