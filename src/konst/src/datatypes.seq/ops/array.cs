//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Seq
    {
        [MethodImpl(NotInline)]
        static T[] array<T>(IEnumerable<T> src)
            => src.Array();

        [MethodImpl(NotInline)]
        static T[] array<T>(IList<T> src)
            => src.ToArray();

        [MethodImpl(NotInline)]
        static T[] array<T>(ReadOnlySpan<T> src)
            => src.ToArray();

        [MethodImpl(NotInline)]
        static T[] array<T>(Span<T> src)
            => src.ToArray();

        [MethodImpl(NotInline)]
        static T[] EmptyArray<T>()
            => Array.Empty<T>();
    }
}