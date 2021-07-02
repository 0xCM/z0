//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;

    partial struct memory
    {
        [MethodImpl(Inline)]
        public static T[] array<T>(IEnumerable<T> src)
            => core.array(src);

        [MethodImpl(Inline)]
        public static T[] array<T>(List<T> src)
            => core.array(src);

        [MethodImpl(Inline)]
        public static T[] array<T>(Span<T> src)
            => core.array(src);

        [MethodImpl(Inline)]
        public static T[] array<T>(params T[] src)
            => core.array(src);
    }
}