//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CalcHosts;
    using static memory;
    using static SFx;
    using static ApiClassKind;

    partial struct Calcs
    {
        [MethodImpl(Inline), Factory(Div), Closures(AllNumeric)]
        public static Div<T> div<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Div, Closures(Integers)]
        public static Span<T> div<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(Calcs.div<T>(), l, r, dst);

    }
}