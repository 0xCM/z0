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
        public static ref ushort first16<T>(Span<T> src)
            where T : unmanaged
                => ref memory.first16(src);

        [MethodImpl(Inline)]
        public static ref readonly ushort first16<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ref memory.first16(src);
    }
}