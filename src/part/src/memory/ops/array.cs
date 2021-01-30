//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    partial struct memory
    {
        [MethodImpl(Inline)]
        public static T[] array<T>(IEnumerable<T> src)
            => root.array(src);

        [MethodImpl(Inline)]
        public static T[] array<T>(List<T> src)
            => root.array(src);

        [MethodImpl(Inline)]
        public static T[] array<T>(Span<T> src)
            => root.array(src);

        [MethodImpl(Inline)]
        public static T[] array<T>(params T[] src)
            => root.array(src);
    }
}