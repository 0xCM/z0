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

    partial struct core
    {
        [MethodImpl(Inline)]
        public static T[] array<T>(IEnumerable<T> src)
            => sys.array(src);

        [MethodImpl(Inline)]
        public static T[] array<T>(List<T> src)
            => sys.array(src);

        [MethodImpl(Inline)]
        public static T[] array<T>(Span<T> src)
            => sys.array(src);

        [MethodImpl(Inline)]
        public static T[] array<T>(params T[] src)
            => src;
    }
}