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
        public static T[] array<T>(Span<T> src)
            => memory.array(src);

        [MethodImpl(Inline)]
        public static T[] array<T>(params T[] src)
            => memory.array(src);
    }
}